using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talalos
{
    public partial class Form1 : Form
    {
        List<Question> questions = QuestionIO.GetQuestions(path);
        int healthPoint = 5;
        const string path = "questions.txt";
        public Form1()
        {
            InitializeComponent();

            hp.Text = healthPoint.ToString();

            if (questions.Count < 9)
            {
                MessageBox.Show($"Minimum 9 kérdés legyen!\nJelenleg {questions.Count} kérdés van.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            foreach (Question question in questions)
            {
                questionsCb.Items.Add(question.QuestionName);
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (healthPoint == 0)
            {
                resultInfo.Text = "Nincs több életed!";
                resultInfo.ForeColor = Color.Red;
            }
            else if (questionsCb.Items.Count == 0)
            {
                resultInfo.Text = "Nyertél";
                resultInfo.ForeColor = Color.Green;
            }
            else if (result.Text == string.Empty || questionsCb.SelectedItem == null)
            {
                resultInfo.Text = "Írj be valamit!";
                resultInfo.ForeColor = Color.Black;
            }
            else
            {
                Question actualQuestion = questions.Where(q => q.QuestionName == questionsCb.SelectedItem.ToString()).Single();

                if (actualQuestion.QuestionAnswer.ToLower() == result.Text.ToLower())
                {
                    resultInfo.Text = string.Empty;

                    result.Text = string.Empty;

                    questionsCb.Items.Remove(questionsCb.SelectedItem);

                    foreach (PictureBox pB in pictureBox.Controls)
                    {
                        if (!pB.Visible)
                        {
                            pB.Visible = true;
                            break;
                        }
                    }

                    if (questionsCb.Items.Count == 0)
                    {
                        resultInfo.Text = "Nyertél";
                        resultInfo.ForeColor = Color.Green;
                    }
                }
                else
                {
                    resultInfo.Text = "Helytelen válasz!";
                    resultInfo.ForeColor = Color.Red;
                    healthPoint--;

                    if (healthPoint == 0) sadPic.Visible = true;                  

                    hp.Text = healthPoint.ToString();
                }
            }            
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            sadPic.Visible = false;

            questionsCb.Items.Clear();

            foreach (PictureBox pB in pictureBox.Controls)
            {
                if (pB.Visible)
                {
                    pB.Visible = false;
                }
            }

            foreach (Question question in questions)
            {
                questionsCb.Items.Add(question.QuestionName);
            }

            healthPoint = 5;
            resultInfo.Text = string.Empty;
            result.Text = string.Empty;

            hp.Text = healthPoint.ToString();
        }
    }
}
