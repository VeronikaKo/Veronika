/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 09.07.2012
 * Time: 1:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
	/// <summary>
	/// Description of butun.
	/// </summary>
	public partial class ChooseNum : Form
	{
		private string figure;
		public ChooseNum()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void strn(string str)
		{
			figure=str;
			  this.DialogResult = DialogResult.OK;
			 
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			strn("1");
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			strn("2");
		
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			strn("3");
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			strn("4");
		
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			strn("5");
			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			strn("6");
		
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			strn("7");
		
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			strn("8");
		
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			strn("9");
			
		}
		public string STR()
		{
			return figure;
		}
		
		void ButtonnLoad(object sender, EventArgs e)
		{
			
		}
		
		void ButunFormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult= DialogResult.No;
			strn("");
		}
	}
}
