/*
 * Created by SharpDevelop.
 * User: PAUL
 * Date: 2/16/2020
 * Time: 12:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentInfo
{
	/// <summary>
	/// Description of ADDSTUDENT.
	/// </summary>
	public partial class ADDSTUDENT : Form
	{
		public static string passingText1, passingText2, passingText3,passingText4,passingText5,passingText6,passingText7,passingText8;
		public ADDSTUDENT()
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
			var myform = new  Form1();
			myform.Show();
			this.Hide();
		}
		void ADDSTUDENTLoad(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			var myform = new ABOUT();
			myform.Show();
			this.Hide();
		}
		void Button2Click(object sender, EventArgs e)
		{
			var myform = new Form2();
			myform.Show();
			this.Hide();
		}
		void TextBox16TextChanged(object sender, EventArgs e)
		{
	
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
		void Button7Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
			textBox8.Text = "";
			textBox9.Text = "";
			textBox10.Text = "";
			textBox11.Text = "";
			textBox12.Text = "";
			textBox13.Text = "";
			textBox14.Text = "";
			textBox15.Text = "";
			textBox16.Text = "";
			textBox17.Text = "";
			comboBox1.Text = "";
			comboBox2.Text = "";
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox1.TabIndex = 0;
			comboBox1.Items.AddRange(new object[] {"Jr.","Sr.","I","II","III","IV","V"});
		}
		void Button8Click(object sender, EventArgs e)
		{
			passingText1 = textBox1.Text;
			passingText2 = textBox2.Text;
			passingText3 = textBox3.Text;
			passingText4 = textBox4.Text;
			passingText5 = textBox11.Text;
			passingText6 = comboBox1.Text;
			passingText7 = comboBox2.Text;
			passingText8 = comboBox3.Text;
			VIEW VIEW = new VIEW ();
		
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
			textBox8.Text = "";
			textBox9.Text = "";
			textBox10.Text = "";
			textBox11.Text = "";
			textBox12.Text = "";
			textBox13.Text = "";
			textBox14.Text = "";
			textBox15.Text = "";
			textBox16.Text = "";
			textBox17.Text = "";
			comboBox1.Text = "";
			comboBox2.Text = "";
		}
	}
}
