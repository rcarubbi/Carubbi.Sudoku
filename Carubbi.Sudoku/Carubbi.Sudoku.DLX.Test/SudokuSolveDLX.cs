using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Collections;

namespace Carubbi.Sudoku.DLX.Test
{
    public class SudokuSolveDLX : Carubbi.Sudoku.DLX.Test.DLX
    {

		
		//////////////////////////////////////////////////////
		//////////////////////////////////////////////////////
		/// Constraints: 
		/// 4 columns group: <r,c> <d,r> <d,c> <d,b>
		/// 1 : r*dim+c
		/// 2 : (dim*dim) + r*dim + d = dim*(r+dim) + d
		/// 3 : (2*dim*dim) + c*dim + d = dim*(2*dim+c) + d
		/// 4 : (3*dim*dim) + b*dim + d = dim*(3*dim+b) + d
		/// --------------------------------------------------
		/// Retrieving row informations
		/// row= r*dim*dim + c*dim + d
		/// d=row%dim
		/// c=(row/dim)%dim
		/// r=row/(dim*dim)
		/// --------------------------------------------------
		/// In general, we have to pay attention to the fact 
		/// that r, c and d are in [0-8] but in a real sudoku
		/// the numbers are in [1-9].
		/// This leads to a simple conversion in 2 places.
		/// In the SetStartingGrid method we have:
		/// 
		/// SelectRow(r*dim*dim+c*dim+(grid[r , c]-1));
		/// 
		/// and in the PrintSolution overridden method
		/// we have:
		/// 
		/// Console.Write((s[i*dim+j]+1).ToString().PadRight(2));
		/// ---------------------------------------------------
		/// To solve a sudoku:
		/// SudokuSolveDLX sdlx=new SudokuSolveDLX(dim);
		/// sdlx.BuildSudokuMatrix();
		/// sdlx.SetStartingGrid(...);
		/// sdlx.SolveSudoku(...);
		/// sdlx.UnselectAllRows();
		/// 
		//////////////////////////////////////////////////////
		//////////////////////////////////////////////////////
		
		protected int dim; //grid dimension
		private int bDim; // single block dimension
		
		/// <summary>
		/// Dimension of the sudoku grid
		/// </summary>
		public int Dim {
			get { return dim; }
			set { dim=value; }
		}

		public SudokuSolveDLX(int dim) {
			this.dim=dim;
			bDim=(int)Math.Sqrt(dim);
		}

		/// <summary>
		/// Builds the sudoku matrix calling DLX.BuildSkeleton and setting the dim*dim*dim rows
		/// </summary>
		public void BuildSudokuMatrix() {
			// skeleton first
			BuildSkeleton(dim*dim*dim , 4*dim*dim);

			//appending all the rows then
			int b=0;
			for (int r=0; r<dim; r++) {
				for (int c=0; c<dim; c++) {
					// set the block
					b=(r/bDim)*bDim+(c/bDim);
					for (int d=0; d<dim; d++) {
						AppendRow(new int[] {r*dim+c, dim*(dim+r)+d, dim*(c+2*dim)+d, dim*(b+3*dim)+d }, r*dim*dim+c*dim+d);
					}
				}
			}
		}

		/// <summary>
		/// Given a int[,] it selects the givens in the sudoku matrix
		/// </summary>
		/// <param name="grid">The grid of givens</param>
		public void SetStartingGrid(int[,] grid) {
			try {
				for (int r=0; r<dim; r++) {
					for (int c=0; c<dim; c++) {
						if (grid[r , c]!=0) {
							SelectRow(r*dim*dim+c*dim+(grid[r , c]-1));
						}
					}
				}
			} catch (Exception ex) {
				System.Diagnostics.Trace.WriteLine("From SetStartingGrid(int[,]):\n"+ex.Message);
			}
		}

		/// <summary>
		/// Given a string[] it selects the givens in the sudoku matrix
		/// </summary>
		/// <param name="grid">The grid of givens (like "123456789","321654987","...")</param>
		public void SetStartingGrid(string[] grid) {
			try {
				int[,] g=new int[dim , dim];
				for (int i=0; i<dim; i++) {
					for (int j=0; j<dim; j++) {
						g[i , j]=int.Parse(""+grid[i][j]);
					}
				}
				SetStartingGrid(g);
			} catch (Exception ex) {
				System.Diagnostics.Trace.WriteLine("From SetStartingGrid(string[]):\n"+ex.Message);
			}
		}

		/// <summary>
		/// Solves the sudoku
		/// </summary>
		/// <param name="sm">The method used to solve the sudoku</param>
		/// <returns>True if a unique solution is found</returns>
		public bool SolveSudoku(SolveMethod sm) {
			totSolutions=0;
			if (sm==SolveMethod.PrintSolutions) {
				SolveRecurseAndPrint();
			} else if (sm==SolveMethod.StopAtFirst) {
				gotSolution=false;
				SolveRecurseAndStop(1,dim);
			} else if (sm==SolveMethod.StopAtSecond) {
				gotSolution=false;
				SolveRecurseAndStop(2,dim);
			} else {
				SolveRecurse();
			}
			if (sm==SolveMethod.PrintSolutions) Console.WriteLine("Found "+totSolutions+" solution"+(totSolutions>1?"s":""));
			UnselectAllRows();
			return (totSolutions==1);
		}

		

		
		/// <summary>
		/// Prints out the solution
		/// </summary>
		public override void PrintSolution() {
			Console.WriteLine("Solution # "+totSolutions+"\n");
			int[] s=new int[sol.Count];
			IEnumerator ien=sol.GetEnumerator();
			int index=0;
			while (ien.MoveNext()) {
				s[index++]=((Node)ien.Current).Row;
			}
			Array.Sort(s);
			for (int i=0; i<s.Length; i++) {
				s[i]=s[i]%dim;
			}

			for (int i=0; i<dim; i++) {
				for (int j=0; j<dim; j++) {
					Console.Write((s[i*dim+j]+1).ToString().PadRight(2));
				}
				Console.WriteLine();
			}
			Console.WriteLine();			
		}
		
		

	}

	/// <summary>
	/// Solving methods
	/// </summary>
	public enum SolveMethod {
		Silent,
		PrintSolutions,
		StopAtFirst,
		StopAtSecond
	}
}
