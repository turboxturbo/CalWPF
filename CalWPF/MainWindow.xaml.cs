using System;
using System.Collections.Generic;
using System.Data;
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

namespace CalWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string currentoutput {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (outputTB.Text == "Error")
            {
                outputTB.Text = "";
            }
            Button clickbutton = (Button)sender;
            outputTB.Text += clickbutton.Content.ToString();
            currentoutput = outputTB.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (outputTB.Text == "Error")
                {
                    outputTB.Text = "";
                }
                var output = new DataTable().Compute(outputTB.Text.Replace(',', '.'), null).ToString(); 
                output = output.Replace(',', '.');
                outputTB.Text = output;
            }
            catch
            {
                outputTB.Text = "Error";
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            outputTB.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if(outputTB.Text.Length > 0)
            {
                outputTB.Text = outputTB.Text.Remove(outputTB.Text.Length - 1);
                currentoutput = outputTB.Text;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            outputTB.Text = currentoutput;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                if (outputTB.Text.Length > 0)
                {
                    currentoutput = outputTB.Text;
                    var output = new DataTable().Compute(outputTB.Text.Replace(',', '.'), null).ToString();
                    outputTB.Text = Math.Sqrt(double.Parse(output)).ToString().Replace(',', '.');
                }
            }
            catch
            {
                outputTB.Text = "Error";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                if (outputTB.Text.Length > 0)
                {
                    currentoutput = outputTB.Text;
                    var output = new DataTable().Compute(outputTB.Text.Replace(',', '.'), null).ToString();
                    outputTB.Text = Math.Log10(double.Parse(output)).ToString().Replace(',', '.');
                }
            }
            catch
            {
                outputTB.Text = "Error";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) //sin
        {
            try
            {
                if (outputTB.Text.Length > 0)
                {
                    currentoutput = outputTB.Text;
                    var output = new DataTable().Compute(outputTB.Text.Replace(',', '.'), null).ToString();
                    outputTB.Text = Math.Sin(double.Parse(output)).ToString().Replace(',', '.');
                    
                }
            }
            catch
            {
                outputTB.Text = "Error";
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            try
            {
                if (outputTB.Text.Length > 0)
                {
                    currentoutput = outputTB.Text;
                    var output = new DataTable().Compute(outputTB.Text.Replace(',', '.'), null).ToString();
                    outputTB.Text = Math.Cos(double.Parse(output)).ToString().Replace(',', '.');
                }
            }
            catch
            {
                outputTB.Text = "Error";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            try
            {
                if (outputTB.Text == "Error")
                {
                    outputTB.Text = "";
                }
                currentoutput = outputTB.Text;
                var output = new DataTable().Compute(outputTB.Text.Replace(',', '.'), null).ToString();
                var number = Convert.ToDouble(output);
                var result = Math.Pow(number, 2);  
                outputTB.Text = result.ToString().Replace(',', '.');
            }
            catch
            {
                outputTB.Text = "Error";
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            try
            {
                if (outputTB.Text.Length > 0)
                {
                    currentoutput = outputTB.Text;
                    var output = new DataTable().Compute(outputTB.Text.Replace(',', '.'), null).ToString();
                    outputTB.Text = Math.Log(double.Parse(output)).ToString().Replace(',', '.'); 
                }
            }
            catch
            {
                outputTB.Text = "Error";
            }
        }
    }
}
