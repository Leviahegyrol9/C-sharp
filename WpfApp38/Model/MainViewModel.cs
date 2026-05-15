using System.Windows.Input;
using ViewModels.BaseClass;

namespace WpfApp38
{
    public class MainViewModel : ViewModelBase
    {
        private string studentName = "";
        private int score = 1;
        private string gradeText = "";
        private string evaluationText = "";

        public string StudentName
        {
            get => studentName;
            set
            {
                studentName = value;
                OnPropertyChanged();
            }
        }

        public int Score
        {
            get => score;
            set
            {
                score = value;
                OnPropertyChanged();
            }
        }

        public string GradeText
        {
            get => gradeText;
            set
            {
                gradeText = value;
                OnPropertyChanged();
            }
        }

        public string EvaluationText
        {
            get => evaluationText;
            set
            {
                evaluationText = value;
                OnPropertyChanged();
            }
        }

        public ICommand EvaluateCommand { get; set; }
        public ICommand ExitCommand { get; set; }

        public MainViewModel()
        {
            EvaluateCommand = new RelayCommand(Evaluate);
            ExitCommand = new RelayCommand(Exit);
        }

        private void Evaluate(object obj)
        {
            int grade;
            string text;

            if (Score >= 86)
            {
                grade = 5;
                text = "jeles";
            }
            else if (Score >= 71)
            {
                grade = 4;
                text = "jó";
            }
            else if (Score >= 51)
            {
                grade = 3;
                text = "közepes";
            }
            else if (Score >= 41)
            {
                grade = 2;
                text = "elégséges";
            }
            else
            {
                grade = 1;
                text = "elégtelen";
            }

            GradeText = $"A jegy: {grade}";
            EvaluationText = $"{StudentName} diák {text} eredményt ért el.";
        }

        private void Exit(object obj)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}