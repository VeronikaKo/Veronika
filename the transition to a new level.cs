
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace sudoku
{
	/// <summary>
	/// Description of the_transition_to_a_new_level.
	/// </summary>
	public partial class the_transition_to_a_new_level : Form
	{
		private string str;
		private string lev;
		public the_transition_to_a_new_level(string znak,string level)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			str=znak;
			lev=level;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	public	void save ()
		{
			string tmp="";
			string tmp1=" ";
			string url= string.Format(@"{0}\{1}","file","level.tt");
			variants variant=new variants();
			open_TO_file filet=new open_TO_file();
			filet.GoToLevel("level.tt");
			for(int i=1;i<=12;i++)
			{
				if(str==variant.SSR[i])
				{
					i++;
					tmp="radioButton"+i.ToString();
					break;
				}
			}
			for(int i=0;i<6;i++)
			{
				tmp1 +=filet.Mas[i]+"\r\n";
				tmp1=tmp1.Trim(' ');
				if(filet.Mas[i]==lev)
				{
					
					i=i+1;
					filet.Mas[i]+=',';
					filet.Mas[i]+=tmp+",\r\n";
					tmp1 +=filet.Mas[i];
				}
			}
			StreamWriter sev=new StreamWriter(url);
			sev.Write(tmp1);
			sev.Close();
	
		
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			save();
			this.DialogResult= DialogResult.OK;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.DialogResult= DialogResult.Retry;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.DialogResult=DialogResult.No;
			save();
		}
		
	}
}
