using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleCalculator
{
    public partial class MainPage : ContentPage
    {
        string info = "";
        double val1 = Double.NaN;
        double val2 = Double.NaN;
        bool firstTime = true;
        int Action;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Zero_Clicked(object sender, EventArgs e)
        {
            DisplayNumberOnScreen("0");
        }

        private void One_Clicked(object sender, EventArgs e)
        {
            DisplayNumberOnScreen("1");
        }
        private void Two_Clicked(object sender, EventArgs e)
        {
            DisplayNumberOnScreen("2");
        }
        private void Three_Clicked(object sender, EventArgs e)
        {
            DisplayNumberOnScreen("3");
        }
        private void Four_Clicked(object sender, EventArgs e)
        {
            DisplayNumberOnScreen("4");
        }
        private void Five_Clicked(object sender, EventArgs e)
        {
            DisplayNumberOnScreen("5");
        }
        private void Six_Clicked(object sender, EventArgs e)
        {
            DisplayNumberOnScreen("6");
        }
        private void Seven_Clicked(object sender, EventArgs e)
        {
            DisplayNumberOnScreen("7");
        }
        private void Eight_Clicked(object sender, EventArgs e)
        {
            DisplayNumberOnScreen("8");
        }
        private void Nine_Clicked(object sender, EventArgs e)
        {
            DisplayNumberOnScreen("9");
        }
        private void Dot_Clicked(object sender, EventArgs e)
        {
            DisplayNumberOnScreen(".");
        }
        private void Add_Clicked(object sender, EventArgs e)
        {
            Compute();
            Action = 0;
            Result.Text = Result.Text + "+";
            info = "";
        }
        private void Minus_Clicked(object sender, EventArgs e)
        {
            Compute();
            Action = 1;
            Result.Text = Result.Text + "-";
            info = "";
        }
        private void Multiply_Clicked(object sender, EventArgs e)
        {
            Compute();
            Action = 2;
            Result.Text = Result.Text + "x";
            info = "";
        }
        private void Divide_Clicked(object sender, EventArgs e)
        {
            Compute();
            Action = 3;
            Result.Text = val1.ToString() + "/";
            info = "";
        }
        private void Delete_Clicked(object sender, EventArgs e)
        {
            Result.Text = "0";
            ClearAll();
        }
        private void Equal_Clicked(object sender, EventArgs e)
        {
            if(!Double.IsNaN(val1))
            {
                Compute();
                Action = 4;
                Result.Text = val1.ToString();
                info = "";
            }

        }

        private void ClearAll()
        {
            firstTime = true;
            val1 = Double.NaN;
            val2 = Double.NaN;
            info = "";
        }
        private void DisplayNumberOnScreen(string number)
        {
            if(firstTime)
            {
                Result.Text = number;
                info = number;
                firstTime = false;
            
            }
            else
            {
                Result.Text = Result.Text + number;
                info = info + number;
            }

        }
        private void Compute()
        {
            try
            {
                if (!Double.IsNaN(val1))
                {
                    val2 = Double.Parse(info);

                    switch (Action)
                    {
                        case 0:
                            val1 = val1 + val2;
                            break;
                        case 1:
                            val1 = val1 - val2;
                            break;
                        case 2:
                            val1 = val1 * val2;
                            break;
                        case 3:
                            val1 = val1 / val2;
                            break;
                        case 4:
                            break;
                    }
                }
                else
                {
                    val1 = Double.Parse(info);
                }

            }
            catch(Exception ex)
            {

            }

        }
    }
}
