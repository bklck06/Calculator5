using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator5
{
    public partial class Form1 : Form
    {
        double FirstNumber;

        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Ekran1label_Click(object sender, EventArgs e)
        {

        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (Ekran1label.Text == "0" && Ekran1label.Text == null)

            {

                Ekran1label.Text = "1";

            }

            else

            {

                Ekran1label.Text = Ekran1label.Text + "1";

            }
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (Ekran1label.Text == "0" && Ekran1label.Text == null)

            {

                Ekran1label.Text = "2";

            }

            else

            {

                Ekran1label.Text = Ekran1label.Text + "2";

            }
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (Ekran1label.Text == "0" && Ekran1label.Text == null)

            {

                Ekran1label.Text = "3";

            }

            else

            {

                Ekran1label.Text = Ekran1label.Text + "3";

            }
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (Ekran1label.Text == "0" && Ekran1label.Text == null)

            {

                Ekran1label.Text = "4";

            }

            else

            {

                Ekran1label.Text = Ekran1label.Text + "4";

            }
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (Ekran1label.Text == "0" && Ekran1label.Text == null)

            {

                Ekran1label.Text = "5";

            }

            else

            {

                Ekran1label.Text = Ekran1label.Text + "5";

            }
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (Ekran1label.Text == "0" && Ekran1label.Text == null)

            {

                Ekran1label.Text = "6";

            }

            else

            {

                Ekran1label.Text = Ekran1label.Text + "6";

            }
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (Ekran1label.Text == "0" && Ekran1label.Text == null)

            {

                Ekran1label.Text = "7";

            }

            else

            {

                Ekran1label.Text = Ekran1label.Text + "7";

            }
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (Ekran1label.Text == "0" && Ekran1label.Text == null)

            {

                Ekran1label.Text = "8";

            }

            else

            {

                Ekran1label.Text = Ekran1label.Text + "8";

            }
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (Ekran1label.Text == "0" && Ekran1label.Text == null)

            {

                Ekran1label.Text = "9";

            }

            else

            {

                Ekran1label.Text = Ekran1label.Text + "9";

            }
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (Ekran1label.Text == "0" && Ekran1label.Text == null)

            {

                Ekran1label.Text = "0";

            }

            else

            {

                Ekran1label.Text = Ekran1label.Text + "0";

            }
        }

        private void virgülbutton_Click(object sender, EventArgs e)
        {
            Ekran1label.Text = Ekran1label.Text + ",";
        }

        private void toplamabutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Ekran1label.Text);

            Ekran1label.Text = null;

            Operation = "+";
        }

        private void cikarmabutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Ekran1label.Text);

            Ekran1label.Text = null;

            Operation = "-";
        }

        private void Sonucbulbutton_Click(object sender, EventArgs e)
        {
            double SecondNumber;

            double Result;
            SecondNumber = Convert.ToDouble(Ekran1label.Text);



            if (Operation == "+")

            {

                Result = (FirstNumber + SecondNumber);

                Ekran1label.Text = Convert.ToString(Result);

                FirstNumber = Result;

            }

            if (Operation == "-")

            {

                Result = (FirstNumber - SecondNumber);

                Ekran1label.Text = Convert.ToString(Result);

                FirstNumber = Result;



            }

            if (Operation == "*")

            {

                Result = (FirstNumber * SecondNumber);

                Ekran1label.Text = Convert.ToString(Result);

                FirstNumber = Result;

            }

            if (Operation == "/")

                if (SecondNumber == 0)

                {

                    Ekran1label.Text = "Gecersiz";

                }

                else

                {

                    Result = (FirstNumber / SecondNumber);

                    Ekran1label.Text = Convert.ToString(Result);

                    FirstNumber = Result;

                }
        }

        private void bolmebutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Ekran1label.Text);

            Ekran1label.Text = null;

            Operation = "/";
        }

        private void carpmabutton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Ekran1label.Text);

            Ekran1label.Text = null;

            Operation = "*";
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            Ekran1label.Text = " ";
        }
    }
    }

