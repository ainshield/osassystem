/*
 * Created by SharpDevelop.
 * User: PAUL
 * Date: 2/16/2020
 * Time: 12:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentInfo
{
	/// <summary>
	/// Description of ABOUT.
	/// </summary>
	public partial class ABOUT : Form
	{
		public ABOUT()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
	var myform = new Form1();
			myform.Show();
			this.Hide();
		}
		void Button2Click(object sender, EventArgs e)
		{
	var myform = new Form2();
			myform.Show();
			this.Hide();
		}
		void ABOUTLoad(object sender, EventArgs e)
		{
	
		}
		void Button4Click(object sender, EventArgs e)
		{
		var myform = new ADDSTUDENT();
			myform.Show();
			this.Hide();
		}
		void Button5Click(object sender, EventArgs e)
		{
	var myform = new VIEW();
			myform.Show();
			this.Hide();
		}
		void Button6Click(object sender, EventArgs e)
		{
		var myform = new  EDIT();
			myform.Show();
			this.Hide();
		}
	}
}
