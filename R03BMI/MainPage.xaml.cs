using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A06 小山　楓太";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String heigth = heighit.Text;
            String weigth = weighit.Text;
            try
            {
                double h = double.Parse(heigth);
                double w = double.Parse(weigth);
                string zyoutai;

                if (h > 10)
                {
                    h = h / 100;
                }
                if (w > 10000)
                {
                    w = w / 1000;
                }
                double BMI = Math.Round(w / (h * h), 1);

                if (BMI < 18.5)
                {
                    zyoutai = "低体重（痩せ）";

                }
                else if (BMI < 25.0)
                {
                    zyoutai = "普通体重";
                }
                else if (BMI < 30.0)
                {
                    zyoutai = "肥満度(1度)";
                }
                else if (BMI < 35.0)
                {
                    zyoutai = "肥満度(2度)";
                }
                else if (BMI < 40.0)
                {
                    zyoutai = "肥満度(3度)";
                }
                else
                {
                    zyoutai = "肥満度(4度)";
                }
                result.Text = "BMIは" + BMI + "で、体形は" + zyoutai + "す。";
            }catch(FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "!!!";
            }

            }
        }
    }

