/*
 * Created by SharpDevelop.
 * User: PAUL
 * Date: 2/16/2020
 * Time: 11:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace StudentInfo
{
    /// <summary>
    /// Description of Form2.
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }


        void Button3Click(object sender, EventArgs e)
        {
            var myform = new ABOUT();
            myform.Show();
            this.Hide();
        }
        void Button2Click(object sender, EventArgs e)
        {

        }
        void Form2Load(object sender, EventArgs e)
        {

        }
        void Button1Click(object sender, EventArgs e)
        {
            var myform = new Form1();
            myform.Show();
            this.Hide();
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
            var myform = new EDIT();
            myform.Show();
            this.Hide();
        }
    }
}
