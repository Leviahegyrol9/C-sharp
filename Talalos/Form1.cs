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
        bool run = true;
        int healthPoint = 5;
        const string path = "questions.txt";
        public Form1()
        {
            InitializeComponent();

            hp.Text = healthPoint.ToString();

            if (questions.Count < 9)
            {
                MessageBox.Show($"Minimum 9 kérdés legyen!\nJelenleg {questions.Count} kérdés van.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                run = false;
            }

            foreach (Question question in questions)
            {
                questionsCb.Items.Add(question.QuestionName);
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {          
            if (healthPoint == 0) resultInfo.Text = "Nincs több életed!";
            else if (result.Text == string.Empty || questionsCb.SelectedItem == null) resultInfo.Text = "Írj be valamit!";
            else if (questionsCb.Items.Count == 0) resultInfo.Text = "Nyertél";
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
                }
                else
                {
                    resultInfo.Text = "Helytelen válasz!";
                    healthPoint--;

                    if (healthPoint == 0) sadPic.Visible = true;
                    hp.Text = healthPoint.ToString();
                }
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!run)
            {
                Application.Exit();
            }
        }
    }
}
