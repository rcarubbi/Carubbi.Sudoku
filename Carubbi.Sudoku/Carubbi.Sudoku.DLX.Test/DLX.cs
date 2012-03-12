using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;


namespace Carubbi.Sudoku.DLX.Test
{
	public class DLX {

		protected Header[] columns;  // an array of Header objects
		protected NodePointer[] rows;  // an array of NodePointer objects
		protected Stack sol;
		protected Header h;
		protected int totSolutions;
		public int[,] solution;
		public bool gotSolution;
								
		public DLX() {
			this.h=new Header(0);
			this.sol=new Stack();
			this.totSolutions=0;
		}

		/// <summary>
		/// Prints a solution. This method can be overridden
		/// </summary>
		public virtual void PrintSolution() {
			if (sol.Count==0) {
				Console.WriteLine("No solution present.");
				return;
			}
			Console.WriteLine("Writing a solution");
			IEnumerator ien=sol.GetEnumerator();
			while (ien.MoveNext()) {
				Console.WriteLine(((Node)ien.Current).Row.ToString());
			}
		}

		#region build Methods

		/// <summary>
		/// Loads a 0,1 matrix from an input file
		/// The input file must be filled with a rectangular matrix of 1's and 0's.
		/// </summary>
		/// <param name="fileName">The path to the input file</param>
		public void LoadInputFile(string fileName) {
			FileStream fs=new FileStream(fileName, FileMode.Open , FileAccess.Read);
			StreamReader sr=new StreamReader(fs);
			StringCollection sc=new StringCollection();
			string s=string.Empty;
			while ((s=sr.ReadLine())!=null) {
				if (s.Trim()!=string.Empty) {
					sc.Add(s.Trim());
				}
			}
			sr.Close();
			fs.Close();

			int col=sc[0].Length;
			int numRow=sc.Count;
			BuildSkeleton(numRow , col);

			for (int i=0; i<sc.Count; i++) {
				AppendRow(sc[i].ToString(),i);
			}
			
		}

		/// <summary>
		/// Builds the rows and columns arrays. This method mustn't be called if LoadInputFile is called
		/// </summary>
		/// <param name="r">Number of rows</param>
		/// <param name="c">Number of columns</param>
		public void BuildSkeleton(int r , int c) {
			columns = new Header[c];
			rows = new NodePointer[r];
			// columns
			for (int i=0; i<c; i++) {
				columns[i]=new Header(i);
				columns[i].Left=h.Left;
				columns[i].Right=h;
				h.Left.Right=columns[i];
				h.Left=columns[i];
			}

			// rows
			for (int i=0; i<r; i++) {
				rows[i]=new NodePointer();
			}			
		}

		/// <summary>
		/// Appends one row to the matrix
		/// </summary>
		/// <param name="r">The string representation of the row (e.g. 01010100011)</param>
		/// <param name="row">The number of the row</param>
		public void AppendRow(string r , int row) {
			if (r.Length>columns.Length || row>=rows.Length) {
				throw new IndexOutOfRangeException("Position of nodes longer than the columns header");
			}
			if (r.Length==0) {
				throw new InvalidDataException("Array pos can't be empty");
			}
			Node first=null;
			Node t=null;

			for (int i=0; i<r.Length; i++) {
				if (r[i]=='1') {
					if (first!=null) {
						t=new Node(row);
						// left - right
						t.Left=first.Left;
						t.Right=first;
						first.Left.Right=t;
						first.Left=t;

						// up - down
						t.Down=columns[i];
						t.Up=columns[i].Up;
						columns[i].Up.Down=t;
						columns[i].Up=t;
						// head
						t.Head=columns[i];
						t.Head.Size++;
					} else {
						first=new Node(row);
						first.Head=columns[i];
						first.Head.Size++;
						first.Down=columns[i];
						first.Up=columns[i].Up;
						columns[i].Up.Down=first;
						columns[i].Up=first;
						// pointer
						rows[row].N=first;
					}
				}
			}
		}

		/// <summary>
		/// Appends one row to the matrix
		/// </summary>
		/// <param name="pos">Array filled with the positions of the columns where to append the nodes</param>
		/// <param name="row">The number of the row</param>
		public void AppendRow(int[] pos , int row) {
			if (pos[pos.Length-1]>=columns.Length || row>=rows.Length) {
				throw new IndexOutOfRangeException("Position of nodes longer than the columns header");
			}
			if (pos.Length==0) {
				throw new InvalidDataException("Array pos can't be empty");
			}

			Node first=new Node(row);
			first.Head=columns[pos[0]];
			first.Head.Size++;
			first.Down=columns[pos[0]];
			first.Up=columns[pos[0]].Up;
			columns[pos[0]].Up.Down=first;
			columns[pos[0]].Up=first;
			rows[row].N=first;
			for (int i=1; i<pos.Length; i++) {
				Node t=new Node(row);
				// left - right
				t.Left=first.Left;
				t.Right=first;
				first.Left.Right=t;
				first.Left=t;

				// up - down
				t.Down=columns[pos[i]];
				t.Up=columns[pos[i]].Up;
				columns[pos[i]].Up.Down=t;
				columns[pos[i]].Up=t;
				// head
				t.Head=columns[pos[i]];
				t.Head.Size++;
			}
		}
				
		#endregion

		#region Selection Methods

		/// <summary>
		/// Finds the minimum sized header in order to minimize the branches for the solution tree
		/// </summary>
		/// <returns>The minimum sized header</returns>
		protected Header FindMin() {
			int min=int.MaxValue;
			Header ret=null;
			Header j=(Header)h.Right;
			while (j!=h) {
				if (j.Size<min) {
					min=j.Size;
					ret=j;
				}
				j=(Header)j.Right;
			}
			return ret;
		}

		/// <summary>
		/// Covers one column (with Knuth DLX cover method) given the Header
		/// </summary>
		/// <param name="c">The column to cover</param>
		protected void CoverColumn(Header c) { 
			// header unplugging
			c.Left.Right=c.Right;
			c.Right.Left=c.Left;
			
			// nodes unplugging
			Node i=c.Down;
			Node j=null;
			while (i!=c) {
				j=i.Right;
				while (j!=i) {
					j.Up.Down=j.Down;
					j.Down.Up=j.Up;
					j.Head.Size--;
					j=j.Right;
				}
				i=i.Down;
			}
		}

		/// <summary>
		/// Covers one column (with Knuth DLX cover method) given the index
		/// </summary>
		/// <param name="index">The index in columns[] for the column to cover</param>
		protected void CoverColumn(int index) {
			CoverColumn(columns[index]);
		}

		/// <summary>
		/// Uncovers one column (with Knuth DLX cover method) given the Header
		/// </summary>
		/// <param name="c">The column to uncover</param>
		protected void UncoverColumn(Header c) { 
			// nodes plugging
			Node i=c.Up;
			Node j=null;
			while (i!=c) {
				j=i.Left;
				while (j!=i) {
					j.Up.Down=j;
					j.Down.Up=j;
					j.Head.Size++;
					j=j.Left;
				}
				i=i.Up;
			}

			// header plugging
			c.Left.Right=c;
			c.Right.Left=c;
		}

		/// <summary>
		/// Uncover one column (with Knuth DLX cover method) given the index
		/// </summary>
		/// <param name="index">The index in columns[] of the column to uncover</param>
		protected void UncoverColumn(int index) {
			UncoverColumn(columns[index]);
		}

		/// <summary>
		/// Selects one row to force solution
		/// </summary>
		/// <param name="index">The index in rows[] of the row to select</param>
		public void SelectRow(int index) {
			Node n=rows[index].N;
			sol.Push(n);
			do {
				CoverColumn(n.Head);
				n=n.Right;
			} while (n!=rows[index].N);
		}

		/// <summary>
		/// Unselects the last row pushed in the sol stack
		/// </summary>
		public void UnselectRow() {
			Node n=((Node)sol.Pop()).Left;
			do {
				UncoverColumn(n.Head);
				n=n.Left;
			} while (n!=rows[n.Row].N);
			UncoverColumn(n.Head);
		}

		/// <summary>
		/// Selects multiple rows
		/// </summary>
		/// <param name="index">Indexes in rows[] of the rows to select</param>
		public void SelectMultipleRows(int[] index) { 
			for (int i=0; i<index.Length; i++) {
				SelectRow(index[i]);
			}
		}

		/// <summary>
		/// Unselects all rows pushed in stack
		/// </summary>
		public void UnselectAllRows() {
			while (sol.Count>0) {
				UnselectRow();
			}
		}

		#endregion

		#region Solving algorithm

		/// <summary>
		/// Calls the SolveRecurse method (this can be modified e.g. to work with threads)
		/// </summary>
		public void Solve() {
			sol.Clear();
			totSolutions=0;
			SolveRecurse();
			UnselectAllRows();
			Console.WriteLine("Done. Solutions found: "+totSolutions);
		}

		/// <summary>
		/// The original Knuth DLX algorithm 
		/// </summary>
		protected virtual void SolveRecurse() {
			if (h.Right==h) {
				totSolutions++;
				return;
			}
			Header c=FindMin();
			
			if (c.Size==0) return; // not a good solution

			CoverColumn(c);
			Node r=c.Down;
			Node j=null;
			while (r!=c) {
				sol.Push(r);
				j=r.Right;
				while (j!=r) {
					CoverColumn(j.Head);
					j=j.Right;
				}
				SolveRecurse();
				r=(Node)sol.Pop();
				c=r.Head;
				j=r.Left;
				while (j!=r) {
					UncoverColumn(j.Head);
					j=j.Left;
				}
				r=r.Down;
			}
			UncoverColumn(c);
		}


		/// <summary>
		/// The Knuth DLX algorithm with solution Printing
		/// </summary>
		protected virtual void SolveRecurseAndPrint() {
			if (h.Right==h) {
				totSolutions++;
				PrintSolution();
				return;
			}
			Header c=FindMin();

			if (c.Size==0) return; // not a good solution

			CoverColumn(c);
			Node r=c.Down;
			Node j=null;
			while (r!=c) {
				sol.Push(r);
				j=r.Right;
				while (j!=r) {
					CoverColumn(j.Head);
					j=j.Right;
				}
				SolveRecurseAndPrint();
				r=(Node)sol.Pop();
				c=r.Head;
				j=r.Left;
				while (j!=r) {
					UncoverColumn(j.Head);
					j=j.Left;
				}
				r=r.Down;
			}
			UncoverColumn(c);
		}

		/// <summary>
		/// The Knuth DLX algorithm with stopping possibility
		/// </summary>
		/// <param name="stopAt">The number of solution to find before stopping</param>
		/// <param name="dim">The dimension of the solution matrix</param>
		protected virtual void SolveRecurseAndStop(int stopAt, int dim) {
			if (gotSolution) return;
			if (h.Right==h) {
				solution=new int[dim , dim];
				int val;
				int row;
				int col;
				// I have a solution, i put it in solution[,] before stack is popped by returns
				IEnumerator ien=sol.GetEnumerator();
				while (ien.MoveNext()) {
					row=((Node)ien.Current).Row;
					val=row%dim;
					col=((row-val)/dim)%dim;
					solution[row/(dim*dim) , col]=val+1;
				}
				totSolutions++;
				if (totSolutions==stopAt) gotSolution=true;
				return;
			}
			Header c=FindMin();

			if (c.Size==0) return; // not a good solution

			CoverColumn(c);
			Node r=c.Down;
			Node j=null;
			while (r!=c) {
				sol.Push(r);
				j=r.Right;
				while (j!=r) {
					CoverColumn(j.Head);
					j=j.Right;
				}
				SolveRecurseAndStop(stopAt, dim);
				r=(Node)sol.Pop();
				c=r.Head;
				j=r.Left;
				while (j!=r) {
					UncoverColumn(j.Head);
					j=j.Left;
				}
				r=r.Down;
			}
			UncoverColumn(c);
		}

		#endregion


	}
	
	
}
