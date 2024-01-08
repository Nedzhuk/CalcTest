using cal.Func;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int arif = -1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox CB = (ComboBox)sender;
            arif = CB.SelectedIndex;
            Result.Text = null;
            if (CB.SelectedIndex == 0)
            {
                Symbol.Text = "+";
                First.Visibility = Visibility.Visible;
            }
            if (CB.SelectedIndex == 1)
            {
                Symbol.Text = "-";
                First.Visibility = Visibility.Visible;
            }
            if (CB.SelectedIndex == 2)
            {
                Symbol.Text = "/";
                First.Visibility = Visibility.Visible;
            }
            if (CB.SelectedIndex == 3)
            {
                Symbol.Text = "*";
                First.Visibility = Visibility.Visible;
            }
            if (CB.SelectedIndex == 4)
            {
                Symbol.Text = "√";
                First.Visibility = Visibility.Collapsed;
            }
        }

        private void Digit_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox TB = (TextBox)sender;

            StringBuilder stringBuilder = new StringBuilder(TB.Text);
            for (int i = stringBuilder.Length - 1; i >= 0; i--)
                if (!char.IsDigit(stringBuilder[i]))
                    stringBuilder.Remove(i, 1);
            TB.Text = stringBuilder.ToString();
            TB.CaretIndex = TB.Text.Length;

            //Add add = new("5", "5");
            //(10, add.Result)
        }

        private void GoResult_Click(object sender, RoutedEventArgs e)
        {
            switch (arif)
            {
                case 0:
                    {
                        Add add = new Add(First.Text, Second.Text);
                        Result.Text = add.Result.ToString();
                    }
                    break;
                case 1:
                    {
                        Sub sub = new Sub(First.Text, Second.Text);
                        Result.Text = sub.Result.ToString();
                    }
                    break;
                case 2:
                    {
                        Mul mul = new Mul(First.Text, Second.Text);
                        Result.Text = mul.Result.ToString();
                    }
                    break;
                case 3:
                    {
                        Div div = new Div(First.Text ,Second.Text);
                        Result.Text = div.Result.ToString();
                    }
                    break;
                case 4:
                    {
                        Root root = new Root(Second.Text);
                        Result.Text = root.Result.ToString();
                    }
                    break;
                default:
                    {
                        Result.Text = "Сложение, вычитание... или, может быть, отчисление?";
                    }
                    break;
            }
            if(First.Text.Length == 0 || Second.Text.Length == 0) 
            {
                if ((arif != -1 && arif != 4) || (Second.Text.Length == 0 && arif == 4))
                    Result.Text = "Результат - бесконечность. Креативно, но лучше проверьте входные данные";
            }
        }
    }
}