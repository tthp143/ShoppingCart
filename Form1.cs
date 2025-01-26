using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Web;
using static System.Net.WebRequestMethods;

namespace ShoppingCart
{
    
    public partial class Form1 : Form
    {
        Item1 itemcoffee = new Item1();
        Item1 itemgreentea = new Item1();
        Item1 itempizza = new Item1();
        Item1 itemfriedchicken = new Item1();
        discount itemdiscount = new discount();
        public Form1()
        {
            InitializeComponent();
            
            //Coffee
            itemcoffee.name = "Coffee";
            itemcoffee.price = 50 ;
            itemcoffee.quantity = 0;
            CostBox1.Text = itemcoffee.price.ToString();
            PieceBox1.Text = itemcoffee.quantity.ToString();
            CostBox1.ReadOnly = true;
            itemcoffee.check = chkCoffee.Checked;

            //Greantea
            itemgreentea.name = "Greentea";
            itemgreentea.price = 45;
            itemgreentea.quantity = 0;
            CostBox2.Text = itemgreentea.price.ToString();
            PieceBox2.Text = itemgreentea .quantity.ToString();
            CostBox2.ReadOnly = true;
            itemgreentea.check = chkGreentea.Checked;

            //Pizza
            itempizza.name = "Pizza";
            itempizza.price = 100;
            itempizza.quantity = 0;
            CostBox3.Text = itempizza.price.ToString();
            PieceBox3.Text = itempizza .quantity.ToString();
            CostBox3.ReadOnly = true;
            itempizza.check = chkPizza.Checked;

            //Fried Chicken
            itemfriedchicken.name = "Fried Chicken";
            itemfriedchicken.price = 50;
            itemfriedchicken.quantity = 0;
            CostBox4.Text = itemfriedchicken.price.ToString();
            PieceBox4.Text = itemfriedchicken.quantity.ToString();
            CostBox4.ReadOnly = true;
            itemfriedchicken.check = chkFriedChicken.Checked;

            //All Discount
            itemdiscount.name = "Alldiscount";
            itemdiscount.percent = 0;
            All_disc.Text = itemdiscount.percent.ToString();
            itemdiscount.check = chkAll_disc.Checked;

            //Baverage Discount
            itemdiscount.name = "Baveragediscount";
            itemdiscount.percent = 0;
            Bav_disc.Text = itemdiscount.percent.ToString();
            itemdiscount.check = chkBaverage_disc.Checked;

            //Food Discount
            itemdiscount.name = "Fooddiscount";
            itemdiscount.percent = 0;
            Food_disc.Text = itemdiscount.percent.ToString();
            itemdiscount.check = chkFood_disc.Checked;



        }

        private double TotalPrice(double beveragePrice, double foodPrice)
        {

            double totalPrice = beveragePrice + foodPrice;


            return totalPrice;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked)
            {
                CostBox1.Enabled = true;
                PieceBox1.Enabled = true;
            }
            else
            {
                CostBox1.Enabled = false;
                PieceBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreentea.Checked)
            {
                CostBox2.Enabled = true;
                PieceBox2.Enabled = true;
            }
            else
            {
                CostBox2.Enabled = false;
                PieceBox2.Enabled = false;
            }
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
            string inputC3 = CostBox3.Text;
            string inputP3 = PieceBox3.Text;
            string inputC4 = CostBox4.Text;
            string inputP4 = PieceBox4.Text;

            double Cf_cost = 0;
            double Cf_piece = 0;
            double Gt_cost = 0;
            double Gt_piece = 0;
            double Piz_cost = 0;
            double Piz_piece = 0;
            double Friedchick_cost = 0;
            double Friedchick_piece = 0;


            try
            {
                if (chkCoffee.Checked)
                {
                    Cf_cost = double.Parse(inputC1);
                    Cf_piece = double.Parse(inputP1);

                }
                if (chkGreentea.Checked)
                {
                    Gt_cost = double.Parse(inputC2);
                    Gt_piece = double.Parse(inputP2);

                }
                if (chkPizza.Checked)
                {
                    Piz_cost = double.Parse(inputC3);
                    Piz_piece = double.Parse(inputP3);

                }
                if (chkFriedChicken.Checked)
                {
                    Friedchick_cost = double.Parse(inputC4);
                    Friedchick_piece = double.Parse(inputP4);

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณาใส่ราคา และ จำนวนชิ้น ให้ครบด้วยครับ/ค่ะ");

            }

            double sum1 = Cf_cost * Cf_piece;
            double sum2 = Gt_cost * Gt_piece;
            double sum3 = Piz_cost * Piz_piece;
            double sum4 = Friedchick_cost * Friedchick_piece;
            double sumBav = sum1 + sum2;
            double sumFood = sum3 + sum4;
            double allsum = TotalPrice(sumBav, sumFood);
            TotalBox.Text = allsum.ToString();








            if (chkAll_disc.Checked)
            {
                double All_discount = 0;
                try
                {
                    All_discount = int.Parse(All_disc.Text);
                    All_discount = allsum - (allsum * All_discount / 100);
                    TotalBox.Text = All_discount.ToString();

                }
                catch (FormatException)
                {
                    MessageBox.Show("กรุณาใส่ส่วนลดในช่องด้วยครับ/ค่ะ");
                }
            }

            if (chkBaverage_disc.Checked)
            {
                double Baverage_discount = 0;
                double SumBav_discount = 0;
                try
                {
                    Baverage_discount = int.Parse(Bav_disc.Text);
                    Baverage_discount = sumBav - (sumBav * Baverage_discount / 100);
                    SumBav_discount = Baverage_discount + sumFood;
                    TotalBox.Text = SumBav_discount.ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("กรุณาใส่ส่วนลดในช่องด้วยครับ/ค่ะ");
                }

            }
            if (chkFood_disc.Checked)
            {
                double Food_discount = 0;
                double SumFood_discount = 0;
                try
                {
                    Food_discount = int.Parse(Food_disc.Text);
                    Food_discount = sumFood - (sumFood * Food_discount / 100);
                    SumFood_discount = Food_discount + sumBav;
                    TotalBox.Text = SumFood_discount.ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("กรุณาใส่ส่วนลดในช่องด้วยครับ/ค่ะ");
                }

            }

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



            double cash = 0;
            try
            {
                cash = double.Parse(cash1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณาใส่จำนวนเงินด้วยครับ/ค่ะ");
            }

            
            string total = TotalBox.Text;
            double totalfill = double.Parse(total);
            double sum = cash - totalfill;
            Change.Text = sum.ToString();


            double One_thousand = 0;
            double five_hundred = 0;
            double One_hundred = 0;
            double fifty_thb = 0;
            double twenty_thb = 0;
            double ten_thb = 0;
            double five_thb = 0;
            double one_thb = 0;
            double fifty_stang = 0;
            double twentyfive_stang = 0;
            double ten_stang = 0;
            double zero_five = 0;
            double zero_one = 0;

            while (sum > 0.001)
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
                else if (sum >= 0.50)
                {
                    sum -= 0.50;
                    fifty_stang++;
                }
                else if (sum >= 0.25)
                {
                    sum -= 0.25;
                    twentyfive_stang++;
                }
                else if (sum >= 0.10)
                {
                    sum -= 0.10;
                    ten_stang++;
                }
                else if (sum >= 0.05)
                {
                    sum -= 0.05;
                    zero_five++;
                }
                else if (sum >= 0.01)
                {
                    sum -= 0.01;
                    zero_one++;
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
            fifty_stng.Text = fifty_stang.ToString();
            twentyfive_stng.Text = twentyfive_stang.ToString();
            ten_stng.Text = ten_stang.ToString();
            zerozero_five.Text = zero_five.ToString();
            zerozero_one.Text = zero_one.ToString();


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

        private void Baverage_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBaverage_disc.Checked)
            {
                chkAll_disc.Checked = false;
                chkFood_disc.Checked = false;
                Bav_disc.Enabled = true;
            }

            else
            {
                Bav_disc.Enabled = false;
            }
        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkAll_disc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll_disc.Checked)
            {
                chkBaverage_disc.Checked = false;
                chkFood_disc.Checked = false;
                All_disc.Enabled = true;
            }

            else
            {
                All_disc.Enabled = false;
            }
        }

        private void chkFood_disc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFood_disc.Checked)
            {
                chkAll_disc.Checked = false;
                chkBaverage_disc.Checked = false;
                Food_disc.Enabled = true;
            }

            else
            {
                Food_disc.Enabled = false;
            }
        }

        private void chkPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPizza.Checked)
            {
                CostBox3.Enabled = true;
                PieceBox3.Enabled = true;
            }
            else
            {
                CostBox3.Enabled = false;
                PieceBox3.Enabled = false;
            }
        }

        private void chkFriedChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFriedChicken.Checked)
            {
                CostBox4.Enabled = true;
                PieceBox4.Enabled = true;
            }
            else
            {
                CostBox4.Enabled = false;
                PieceBox4.Enabled = false;
            }
        }

        private void cash1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
