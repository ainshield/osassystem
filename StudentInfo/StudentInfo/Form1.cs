/*
 * Created by SharpDevelop.
 * User: PAUL
 * Date: 2/16/2020
 * Time: 10:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace StudentInfo
{
    /// <summary>
    /// Description of Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void Form1Load(object sender, EventArgs e)
        {

        }
        void TextBox2TextChanged(object sender, EventArgs e)
        {

        }
        void Button1Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                var myform = new Form2();
                myform.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password!");
            }
        }
        void Button2Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }
    }
}
