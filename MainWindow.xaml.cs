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

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OneButtonClick(object render, RoutedEventArgs e)
        {
            ResultLabel.Content += "1"; 
        }
        private void TwoButtonClick(object render, RoutedEventArgs e)
        {
            ResultLabel.Content += "2";
        }
        private void ThreeButtonClick(object render, RoutedEventArgs e)
        {
            ResultLabel.Content += "3";
        }
        private void FourButtonClick(object render, RoutedEventArgs e)
        {
            ResultLabel.Content += "4";
        }
        private void FiveButtonClick(object render, RoutedEventArgs e)
        {
            ResultLabel.Content += "5";
        }
        private void SixButtonClick(object render, RoutedEventArgs e)
        {
            ResultLabel.Content += "6";
        }
        private void SevenButtonClick(object render, RoutedEventArgs e)
        {
            ResultLabel.Content += "7";
        }
        private void EightButtonClick(object render, RoutedEventArgs e)
        {
            ResultLabel.Content += "8";
        }
        private void NineButtonClick(object render, RoutedEventArgs e)
        {
            ResultLabel.Content += "9";
        }

        private void PercentButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content += "%";
        }

        private void CE_ButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void C_ButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "";
        }

        private void X_ButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "";
        }

        private void FractionButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "1/" + ResultLabel.Content;
        }

        private void SquareButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content += "^2";
        }

        private void RootButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content += "√";
        }

        private void DivideButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content += "/";
        }

        private void MultiplyButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content += "*";
        }

        private void MinusButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content += "-";
        }

        private void PlusButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content += "+";
        }

        private void EqualsButtonClick(object sender, RoutedEventArgs e)
        {
            ShowResult();
        }

        private void ShowResult()
        {
            char[] exp = MakeExpressionArray();
            String expression = ResultLabel.Content.ToString();
            
            for(var i=0; i < exp.Length; i++)
            {
                switch (exp[i].ToString())
                {
                    case "+":
                        Plus(Int32.Parse(expression.Substring(0, i)), 
                            Int32.Parse(expression.Substring(i + 1)));
                        break;
                    case "-":
                        Minus(Int32.Parse(expression.Substring(0, i)),
                            Int32.Parse(expression.Substring(i + 1)));
                        break;
                    case "*":
                        Multiply(Int32.Parse(expression.Substring(0, i)), 
                            Int32.Parse(expression.Substring(i + 1)));
                        break;
                    case "/":
                        Divide(Int32.Parse(expression.Substring(0, i)),
                            Int32.Parse(expression.Substring(i + 1)));
                        break;
                    case "^":
                        Square(Int32.Parse(expression.Substring(0, i)),
                            Int32.Parse(expression.Substring(i + 1)));
                        break;
                    case "√":
                        SquareRoot(Int32.Parse(expression.Substring(i+1)));
                        break;

                }
            }
        }

        private void SquareRoot(int v)
        {
            ResultLabel.Content = Math.Sqrt(v);
        }

        private void Square(int v1, int v2)
        {
            ResultLabel.Content = Math.Pow(v1, v2);
        }

        private char[] MakeExpressionArray()
        {
            String expression;
            if (ResultLabel.Content != null)
            {
                expression = ResultLabel.Content.ToString();
            }
            else
            {
                expression = "";
            }

            return expression.ToCharArray();
        }

        private void Divide(int firstNumberAct, int secondNumberAct)
        {
            ResultLabel.Content = firstNumberAct / secondNumberAct;
        }

        private void Multiply(int firstNumberAct, int secondNumberAct)
        {
            ResultLabel.Content = firstNumberAct * secondNumberAct;
        }

        private void Minus(int firstNumberAct, int secondNumberAct)
        {
            ResultLabel.Content = firstNumberAct - secondNumberAct;
        }

        private void Plus(int firstNumberAct, int secondNumberAct)
        {
            ResultLabel.Content = firstNumberAct + secondNumberAct;
        }

        private void CommaButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content += ",";
        }

        private void ZeroButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content += "0";
        }

        private void PlusAndMinusButtonClick(object sender, RoutedEventArgs e)
        {
            //TODO()
        }
    }
}