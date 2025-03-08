using System.Net.Mail;
using System.Xml.Linq;

namespace Multiple_Choice_Quiz
{
    public partial class Form1 : Form
    {
        public static string userAnswer { get; set; }
        public static string correctAnswer{ get; set; }
        public Form1()
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
            }
            else if (radioButton3.Checked)
            {
                userAnswer = radioButton3.Text;
                correctAnswer = radioButton3.Text;
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
            Form2 NextForm2 = new Form2();
            NextForm2.Show();
        }
    }
}
