using System;
using System.Collections.Generic;
using System.Text;

namespace Carubbi.Sudoku.DLX.Test
{

	public class Node {
		// neighbours
		protected Node left;
		protected Node right;
		protected Node up;
		protected Node down;

		// column header
		protected Header head;

		protected int row;		

		/// <summary>
		/// The row of this node
		/// </summary>
		public int Row {
			get { return this.row; }
			set { this.row=value; }
		}
						
		/// <summary>
		/// Column Header
		/// </summary>
		public Header Head {
			get { return this.head; }
			set { this.head = value; }
		}

		/// <summary>
		/// Down neighbour
		/// </summary>
		public Node Down {
			get { return this.down; }
			set { this.down = value; }
		}	

		/// <summary>
		/// Up neighbour
		/// </summary>
		public Node Up {
			get { return this.up; }
			set { this.up = value; }
		}

		/// <summary>
		/// Left neighbour
		/// </summary>
		public Node Left {
			get { return this.left;	}
			set { this.left=value; }
		}		

		/// <summary>
		/// Right neighbour
		/// </summary>
		public Node Right {
			get { return this.right; }
			set { this.right = value; }
		}

		public Node() : this(-1 , null) { }

		public Node(int row) : this(row, null) { }

		public Node(int row , Header head) {
			this.left=this;
			this.right=this;
			this.up=this;
			this.down=this;			
			this.row=row;
			this.head=head;			
		}
	
	}
}
