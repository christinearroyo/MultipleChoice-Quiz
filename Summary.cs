using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.DataFormats;

namespace Multiple_Choice_Quiz
{
    public partial class Summary : Form
    {

        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            lblYourAnswer1.Text = Form1.userAnswer;
            lblYourAnswer2.Text = Form2.userAnswer;
            lblYourAnswer3.Text = Form3.userAnswer;


            int score = 0;
            if (Form1.userAnswer == Form1.correctAnswer)
            {
                lblRemarks1.Text = "Correct";
                score++;
            }
            else
            {
                lblRemarks1.Text = "Wrong";
            }
            if (Form2.userAnswer == Form2.correctAnswer)
            {
                lblRemarks2.Text = "Correct";
                score++;
            }
            else
            {
                lblRemarks2.Text = "Wrong";
            }
            if (Form3.userAnswer == Form3.correctAnswer)
            {
                lblRemarks3.Text = "Correct";
                score++;
            }
            else
            {
                lblRemarks3.Text = "Wrong";
            }


            int ratingScore;
            switch (score)
            {
                case 3:
                    ratingScore = 100;
                    break;
                case 2:
                    ratingScore = 90;
                    break;
                case 1:
                    ratingScore = 80;
                    break;
                default:
                    ratingScore = 50;
                    break;
            }

            lblScore.Text = "Your score is " + score + " out of 3";
            lblResult.Text = "Rating is " + ratingScore;

        }
    }
}
