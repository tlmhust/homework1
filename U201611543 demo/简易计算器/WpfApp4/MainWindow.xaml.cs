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
using System.IO;

namespace WpfApp4
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string Number1 = null, Number2 = null, flag = null;
        List<string> expressions = new List<string>();
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if(flag==null)
            {
                Number1 += "7";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "7";
                label1.Content = Number2;
            }
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 += "8";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "8";
                label1.Content = Number2;
            }
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 += "9";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "9";
                label1.Content = Number2;
            }
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 += "4";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "4";
                label1.Content = Number2;
            }
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 += "5";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "5";
                label1.Content = Number2;
            }
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 += "6";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "6";
                label1.Content = Number2;
            }
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 += "1";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "1";
                label1.Content = Number2;
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 += "2";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "2";
                label1.Content = Number2;
            }
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 += "3";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "3";
                label1.Content = Number2;
            }
        }
        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 += "0";
                label1.Content = Number1;
            }
            else
            {
                Number2 += "0";
                label1.Content = Number2;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                Number1 += ".";
                label1.Content = Number1;
            }
            else
            {
                Number2 += ".";
                label1.Content = Number2;
            }
        }
        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            flag = "+";
            
        }
        private void Button_sub_Click(object sender, RoutedEventArgs e)
        {
            flag = "-";
           
        }
        private void Button_mul_Click(object sender, RoutedEventArgs e)
        {
            flag = "*";
            
        }
        private void Button_div_Click(object sender, RoutedEventArgs e)
        {
            flag = "/";
          
        }

        private void Button_del_Click(object sender, RoutedEventArgs e)
        {
            if (flag == null)
            {
                if (Number1 != null)
                {
                    if (Number1.Length > 0)
                        Number1 = Number1.Remove(Number1.Length - 1);
                    label1.Content = Number1;
                }
            }
            else
            {
                if (Number2 != null)
                {
                    if (Number2.Length > 0)
                        Number2 = Number2.Remove(Number2.Length - 1);
                    label1.Content = Number2;
                }
            }
        }

        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            Number1 = null;
            Number2 = null;
            flag = null;
            label1.Content = "0";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FileStream resultfile = new FileStream("result.txt", FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(resultfile);
            foreach (string a in expressions)
            {
                streamWriter.WriteLine(a);
            }
            streamWriter.Close();
        }     
        private void Button_equ_Click(object sender, RoutedEventArgs e)
        {
            switch(flag)
            {
                case "+":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) + Convert.ToDouble(Number2));
                    expressions.Add(Number1 + "+" + Number2 + "=" + label1.Content);
                    break;
                case "-":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) - Convert.ToDouble(Number2));
                    expressions.Add(Number1 + "-" + Number2 + "=" + label1.Content);
                    break;
                case "*":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) * Convert.ToDouble(Number2));
                    expressions.Add(Number1 + "*" + Number2 + "=" + label1.Content);
                    break;
                case "/":
                    label1.Content = Convert.ToString(Convert.ToDouble(Number1) / Convert.ToDouble(Number2));
                    expressions.Add(Number1 + "/" + Number2 + "=" + label1.Content);
                    break;
            }
            Number1 = null;
            Number2 = null;
            flag = null;
        }
       
        public MainWindow()
        {
            InitializeComponent();
        }

        
    }
}
