using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Multiple_Choice_Quiz
{
    public partial class Form3 : Form
    {
        public static string userAnswer { get; set; }
        public static string correctAnswer { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                userAnswer = radioButton1.Text;
                correctAnswer = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                userAnswer = radioButton2.Text;
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
            Summary Submit = new Summary();
            Submit.Show();
        }
    }
}
