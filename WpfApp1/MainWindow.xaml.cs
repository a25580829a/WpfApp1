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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num;
            bool succes = int.TryParse(textbox.Text, out num);
            if (!succes)
            {
                MessageBox.Show("輸入錯誤，請輸入正整數");
            }
            else
            {
                int a = 0;
                string ans = $"小於等於{num}的質數為:";
                string aa = "";
                ans += "2";
                for (int i = 3; i <= num; i++)
                {
                    a = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            a++;
                        }
                    }
                    if (a == 2)
                    {
                        ans += ", ";
                        ans += $"{i}";
                        aa += $"\n{i}的倍數:";
                        for (int k = 1; k <= (num / i); k++)
                        {
                            aa += $"{i * k}";
                            if (k != (num / i)) { aa += ", "; }
                            else { aa += "。"; }
                        }
                    }
                }
                ans += "。";
                textbox2.Text = $"{ans}{aa}";

            }
        }
    }
}
