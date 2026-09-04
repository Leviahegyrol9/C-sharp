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
            List<string> lines = new List<string>();
            Question question = null;
            Random rnd = new Random();

            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
                {                  
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        if (line != string.Empty)
                        {
                            lines.Add(line);
                        }
                    }
                }

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
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return questions;
        }
    }
}
