using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mini_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        static int score = 0;
        static int currentQuiz = 0;
        static int countQuiz = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Quiz> myQuiz = new List<Quiz>
{
    new Quiz(){ _ID = 1, _quiz = Resource.quiz1, _correctChoice = false, _uri1 = Resource.Manchester_United, _uri2 = Resource.Liverpool },
        new Quiz() { _ID = 2, _quiz = Resource.quiz2, _correctChoice = true,_uri1= Resource.Arsenal,_uri2= Resource.Manchester_United},
        new Quiz(){_ID = 3, _quiz =Resource.quiz3, _correctChoice = false, _uri1 = Resource.Chelsea, _uri2 =Resource.Arsenal },
        new Quiz(){_ID = 4, _quiz =Resource.quiz4, _correctChoice = true, _uri1 = Resource.Southampton,_uri2 = Resource.Everton },
        new Quiz(){_ID = 5, _quiz = Resource.quiz5, _correctChoice=false, _uri1 = Resource.Real_Madrid, _uri2 = Resource.AC_Milan },
        new Quiz(){ _ID = 6, _quiz = Resource.quiz6, _correctChoice=true, _uri1 = Resource.Arsenal, _uri2 = Resource.Liverpool },
        new Quiz(){ _ID = 7, _quiz = Resource.quiz7, _correctChoice=true, _uri1 = Resource.Manchester_City, _uri2 = Resource.Barcelona },
        new Quiz(){ _ID = 8, _quiz = Resource.quiz8, _correctChoice=false, _uri1 = Resource.Manchester_United, _uri2 = Resource.Manchester_City },
        new Quiz(){ _ID = 9, _quiz = Resource.quiz9, _correctChoice = false, _uri1 = Resource.Arsenal, _uri2 = Resource.Manchester_United },
        new Quiz(){ _ID = 10, _quiz = Resource.quiz10, _correctChoice = true, _uri1 = Resource.Manchester_United, _uri2 = Resource.Liverpool }
    };
        public class Quiz
        {
            public int _ID;
            public String _quiz;
            public bool _correctChoice;    // 0 - button1, 1 - button2
            public String _uri1, _uri2; // store uri of image
        }

        private void buttonChoice1_Click(object sender, RoutedEventArgs e)
        {
            countQuiz++;
            if (countQuiz > 10)
            {
                ChildWindow childWindow = new ChildWindow();
                childWindow.txtFinalScore.Text = score.ToString() + "/10";
                childWindow.ShowDialog();
                score = 0;
                txtShowScore.Text = score.ToString();
                currentQuiz = 0;
                countQuiz = 0;
                return;
            }
            
            if (myQuiz[currentQuiz]._correctChoice == false)
            {
                score++;
                txtShowScore.Text = score.ToString();
            }

            Random rnd = new Random();
            int i = rnd.Next(0,9);


            txtbckShowQuiz.Text = myQuiz[i]._quiz;
            imgChoice1.BeginInit();
            imgChoice1.Source = new BitmapImage(new Uri(myQuiz[i]._uri1, UriKind.RelativeOrAbsolute));
            imgChoice1.EndInit();

            imgChoice2.BeginInit();
            imgChoice2.Source = new BitmapImage(new Uri(myQuiz[i]._uri2, UriKind.RelativeOrAbsolute));
            imgChoice2.EndInit();
            currentQuiz = i;
        }

        private void buttonChoice2_Click(object sender, RoutedEventArgs e)
        {
            countQuiz++;
            if (countQuiz > 10)
            {
                ChildWindow childWindow = new ChildWindow();
                childWindow.txtFinalScore.Text = score.ToString() + "/10";
                childWindow.ShowDialog();
                score = 0;
                score = 0;
                txtShowScore.Text = score.ToString();
                currentQuiz = 0;
                countQuiz = 0;
                return;
            }

            if (myQuiz[currentQuiz]._correctChoice == true)
            {
                score++;
                txtShowScore.Text = score.ToString();
            }
         
            Random rnd = new Random();
            int i = rnd.Next(0, 9);
            txtbckShowQuiz.Text = myQuiz[i]._quiz;
            imgChoice1.BeginInit();
            imgChoice1.Source = new BitmapImage(new Uri(myQuiz[i]._uri1, UriKind.RelativeOrAbsolute));
            imgChoice1.EndInit();

            imgChoice2.BeginInit();
            imgChoice2.Source = new BitmapImage(new Uri(myQuiz[i]._uri2, UriKind.RelativeOrAbsolute));
            imgChoice2.EndInit();
            currentQuiz = i;

            
        }
    }

}
