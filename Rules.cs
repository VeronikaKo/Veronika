
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
	
	public partial class Rules : Form
	{
		public Rules()
		{

			InitializeComponent();
		
		}
		
		void OKClick(object sender, EventArgs e)
		{
				
			this.DialogResult= DialogResult.OK;
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rules_Load(object sender, EventArgs e)
        {

        }
    }
}
