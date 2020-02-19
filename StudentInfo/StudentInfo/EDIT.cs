/*
 * Created by SharpDevelop.
 * User: PAUL
 * Date: 2/16/2020
 * Time: 2:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentInfo
{
	/// <summary>
	/// Description of EDIT.
	/// </summary>
	public partial class EDIT : Form
	{
		public EDIT()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button2Click(object sender, EventArgs e)
		{
	var myform = new  Form2();
			myform.Show();
			this.Hide();
		}
		void Button3Click(object sender, EventArgs e)
		{
	var myform = new  ABOUT();
			myform.Show();
			this.Hide();
		}
		void Button4Click(object sender, EventArgs e)
		{
	var myform = new  ADDSTUDENT();
			myform.Show();
			this.Hide();
		}
		void Button5Click(object sender, EventArgs e)
		{
	var myform = new  VIEW();
			myform.Show();
			this.Hide();
		}
		void Button1Click(object sender, EventArgs e)
		{
	var myform = new  Form1();
			myform.Show();
			this.Hide();
		}
	}
}
