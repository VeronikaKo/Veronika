
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
	/// <summary>
	/// Description of menu.
	/// </summary>
	public partial class menu : Form
	{

		private bool cen=true;
		public menu()
		{
			
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{

			this.DialogResult= DialogResult.OK;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Rules aut=new Rules();
			this.Hide();
			if(aut.ShowDialog()== DialogResult.OK)
			{
				this.Visible=true;
				
			}else this.Visible=true;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
            DialogResult dr = MessageBox.Show("Do you want to finish the game?", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            { this.DialogResult= DialogResult.Cancel;}
		
			
		}
	}
}
