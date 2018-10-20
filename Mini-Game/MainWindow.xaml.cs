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

        public MainWindow()
        {
            InitializeComponent();

            //Quiz myQuizes1 = new Quiz(1, Resource.quiz1, false, Resource.Manchester_United, Resource.Liverpool);
            //Quiz myQuizes2 = new Quiz(2, Resource.quiz2, true, Resource.Arsenal, Resource.Manchester_United);
            //myQuizes[3] = new Quiz(3, Resource.quiz3, false, Resource.Chelsea, Resource.Arsenal);
            //myQuizes[4] = new Quiz(4, Resource.quiz4, true, Resource.Southampton, Resource.Everton);
            //myQuizes[5] = new Quiz(5, Resource.quiz5, false, Resource.Real_Madrid, Resource.AC_Milan);
            //myQuizes[6] = new Quiz(6, Resource.quiz6, true, Resource.Arsenal, Resource.Liverpool);
            //myQuizes[7] = new Quiz(7, Resource.quiz7, true, Resource.Manchester_City, Resource.Barcelona);
            //myQuizes[8] = new Quiz(8, Resource.quiz8, false, Resource.Manchester_United, Resource.Manchester_City);
            //myQuizes[9] = new Quiz(9, Resource.quiz9, false, Resource.Arsenal, Resource.Manchester_United);
            //myQuizes[10] = new Quiz(10, Resource.quiz10, true, Resource.Manchester_United, Resource.Liverpool);

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
            Random rnd = new Random();
            int i = rnd.Next(0,9);
            txtbckShowQuiz.Text = myQuiz[i]._quiz;
            imgChoice1.BeginInit();
            imgChoice1.Source = new BitmapImage(new Uri(myQuiz[i]._uri1, UriKind.RelativeOrAbsolute));
            imgChoice1.EndInit();

            imgChoice2.BeginInit();
            imgChoice2.Source = new BitmapImage(new Uri(myQuiz[i]._uri2, UriKind.RelativeOrAbsolute));
            imgChoice2.EndInit();
        }

        private void buttonChoice2_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 9);
            txtbckShowQuiz.Text = myQuiz[i]._quiz;
            imgChoice1.BeginInit();
            imgChoice1.Source = new BitmapImage(new Uri(myQuiz[i]._uri1, UriKind.RelativeOrAbsolute));
            imgChoice1.EndInit();

            imgChoice2.BeginInit();
            imgChoice2.Source = new BitmapImage(new Uri(myQuiz[i]._uri2, UriKind.RelativeOrAbsolute));
            imgChoice2.EndInit();
        }
    }

}
