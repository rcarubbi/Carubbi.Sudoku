using System;
using System.Collections.Generic;
using System.Text;

namespace Carubbi.Sudoku.DLX.Test
{
	public class Header : Node {
		private int size;
		private int name;

		/// <summary>
		/// Name of the column
		/// </summary>
		public int Name {
			get { return this.name; }
			set { this.name=value; }
		}

		/// <summary>
		/// Size of the column
		/// </summary>
		public int Size {
			get { return size; }
			set { size = value; }
		}

		public Header() : this(0) { }

		public Header(int name) {
			this.name=name;
			this.size=0;
			this.head=this;
		}

	}
}
