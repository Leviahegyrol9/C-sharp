using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talalos
{
    public class QuestionIO
    {
        public static List<Question> GetQuestions(string path)
        {
            List<Question> questions = new List<Question>();
            Question question = null;
            Random rnd = new Random();

            try
            {
                string[] lines = File.ReadAllLines(path);

                HashSet<string> shuffledLines = lines.Skip(1).OrderBy(i => rnd.Next()).ToHashSet();

                foreach (string line in shuffledLines.Take(9))
                {
                    string[] datas = line.Split(';');

                    question = new Question
                    {
                        QuestionName = datas[0],
                        QuestionAnswer = datas[1]
                    };

                    questions.Add(question);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return questions;
        }
    }
}
