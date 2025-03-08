using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Choice_Quiz
{
    public partial class Form2 : Form
    {
        public static string userAnswer { get; set; }
        public static string correctAnswer { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                userAnswer = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                userAnswer = radioButton2.Text;
                correctAnswer = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                userAnswer = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                userAnswer = radioButton4.Text;
            }
            else
            {
                userAnswer = "No answer selected";
            }

            this.Hide();
            Form3 NextForm3 = new Form3();
            NextForm3.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 BackForm1 = new Form1();
            BackForm1.Show();
        }
    }
}
