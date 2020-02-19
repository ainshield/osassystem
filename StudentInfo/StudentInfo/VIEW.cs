/*
 * Created by SharpDevelop.
 * User: PAUL
 * Date: 2/16/2020
 * Time: 1:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace StudentInfo
{
    /// <summary>
    /// Description of VIEW.
    /// </summary>
    public partial class VIEW : Form
    {

        public VIEW()
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
            var myform = new Form2();
            myform.Show();
            this.Hide();
        }
        void Button1Click(object sender, EventArgs e)
        {
            var myform = new Form1();
            myform.Show();
            this.Hide();
        }
        void Button3Click(object sender, EventArgs e)
        {
            var myform = new ABOUT();
            myform.Show();
            this.Hide();
        }
        void Button4Click(object sender, EventArgs e)
        {
            var myform = new ADDSTUDENT();
            myform.Show();
            this.Hide();
        }
        void Button6Click(object sender, EventArgs e)
        {
            var myform = new EDIT();
            myform.Show();
            this.Hide();
        }
        void Panel1Paint(object sender, PaintEventArgs e)
        {

        }
        void SplitContainer1SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Lastname"].Value.ToString();
                textBox2.Text = row.Cells["Firstname"].Value.ToString();
                textBox3.Text = row.Cells["Middle Initial"].Value.ToString();
                textBox4.Text = row.Cells["Extension"].Value.ToString();
                textBox5.Text = row.Cells["Gender"].Value.ToString();
                textBox6.Text = row.Cells["Address"].Value.ToString();
                textBox7.Text = row.Cells["Course"].Value.ToString();
                textBox8.Text = row.Cells["Year level"].Value.ToString();
            }
        }
        void TextBox5TextChanged(object sender, EventArgs e)
        {

        }
        void TextBox1TextChanged(object sender, EventArgs e)
        {

        }
        void VIEWLoad(object sender, EventArgs e)
        {
            textBox1.Text = ADDSTUDENT.passingText1;
            textBox2.Text = ADDSTUDENT.passingText2;
            textBox3.Text = ADDSTUDENT.passingText3;
            textBox4.Text = ADDSTUDENT.passingText4;
            textBox5.Text = ADDSTUDENT.passingText5;
            textBox6.Text = ADDSTUDENT.passingText6;
            textBox7.Text = ADDSTUDENT.passingText7;
            textBox8.Text = ADDSTUDENT.passingText8;
        }
        void Button7Click(object sender, EventArgs e)
        {

        }

    }
}
