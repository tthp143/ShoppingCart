using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Web;
using static System.Net.WebRequestMethods;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CostBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckOutbutton_Click(object sender, EventArgs e)
        {

            string inputC1 = CostBox1.Text;
            string inputP1 = PieceBox1.Text;
            string inputC2 = CostBox2.Text;
            string inputP2 = PieceBox2.Text;

            double Cf_c1 = 0;
            double Cf_p1 = 0;
            double Gt_c1 = 0;
            double Gt_p1 = 0;

            try
            {
                if (chkCoffee1.Checked)
                {
                    Cf_c1 = double.Parse(inputC1);
                    Cf_p1 = double.Parse(inputP1);

                }
                if (chkGreentea1.Checked)
                {
                    Gt_c1 = double.Parse(inputC2);
                    Gt_p1 = double.Parse(inputP2);

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ãÊèºè¤ÃººÑ¡§ÑÇ");

            }
            double sum1 = Cf_c1 * Cf_p1;
            double sum2 = Gt_c1 * Gt_p1;
            double sum = sum1 + sum2;
            TotalBox.Text = sum.ToString();












        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string total = TotalBox.Text;
            string cash = cash1.Text;
            double totalfill = double.Parse(total);
            double cashfill = double.Parse(cash);
            double sum = cashfill - totalfill;
            Change1.Text = sum.ToString();

            double One_thousand = 0;
            double five_hundred = 0;
            double One_hundred = 0;
            double fifty_thb = 0;
            double twenty_thb = 0;
            double ten_thb = 0;
            double five_thb = 0;
            double one_thb = 0;

            while (sum > 0)
            {
                if (sum >= 1000)
                {
                    sum -= 1000;
                    One_thousand++;
                }
                else if (sum >= 500)
                {
                    sum -= 500;
                    five_hundred++;
                }
                else if (sum >= 100)
                {
                    sum -= 100;
                    One_hundred++;
                }
                else if (sum >= 50)
                {
                    sum -= 50;
                    fifty_thb++;
                }
                else if (sum >= 20)
                {
                    sum -= 20;
                    twenty_thb++;
                }
                else if (sum >= 10)
                {
                    sum -= 10;
                    ten_thb++;
                }
                else if (sum >= 5)
                {
                    sum -= 5;
                    five_thb++;
                }
                else if (sum >= 1)
                {
                    sum -= 1;
                    one_thb++;
                }


            }

            One_t.Text = One_thousand.ToString();
            five_h.Text = five_hundred.ToString();
            One_h.Text = One_hundred.ToString();
            fifty.Text = fifty_thb.ToString();
            twenty.Text = twenty_thb.ToString();
            ten.Text = ten_thb.ToString();
            five.Text = five_thb.ToString();
            one.Text = one_thb.ToString();
        }





        private void TotalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
