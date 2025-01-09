namespace ShoppingCart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkCoffee = new CheckBox();
            chkGreentea = new CheckBox();
            CostBox1 = new RichTextBox();
            CostBox2 = new RichTextBox();
            PieceBox1 = new RichTextBox();
            PieceBox2 = new RichTextBox();
            TotalBox = new RichTextBox();
            label1 = new Label();
            CheckOutbutton = new Button();
            label2 = new Label();
            cash1 = new RichTextBox();
            label3 = new Label();
            Change = new RichTextBox();
            label4 = new Label();
            One_t = new RichTextBox();
            label5 = new Label();
            five_h = new RichTextBox();
            label6 = new Label();
            One_h = new RichTextBox();
            label7 = new Label();
            fifty = new RichTextBox();
            label8 = new Label();
            twenty = new RichTextBox();
            label9 = new Label();
            five = new RichTextBox();
            label10 = new Label();
            ten = new RichTextBox();
            label11 = new Label();
            one = new RichTextBox();
            button1 = new Button();
            Baverage = new GroupBox();
            Food = new GroupBox();
            PieceBox4 = new RichTextBox();
            PieceBox3 = new RichTextBox();
            CostBox4 = new RichTextBox();
            CostBox3 = new RichTextBox();
            chkFriedChicken = new CheckBox();
            chkPizza = new CheckBox();
            groupBox1 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            Food_disc = new RichTextBox();
            chkAll_disc = new CheckBox();
            Bav_disc = new RichTextBox();
            All_disc = new RichTextBox();
            chkFood_disc = new CheckBox();
            chkBaverage_disc = new CheckBox();
            label15 = new Label();
            twentyfive_stng = new RichTextBox();
            label16 = new Label();
            fifty_stng = new RichTextBox();
            label17 = new Label();
            ten_stng = new RichTextBox();
            label18 = new Label();
            zerozero_five = new RichTextBox();
            label19 = new Label();
            zerozero_one = new RichTextBox();
            Baverage.SuspendLayout();
            Food.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chkCoffee
            // 
            chkCoffee.AutoSize = true;
            chkCoffee.Location = new Point(15, 19);
            chkCoffee.Name = "chkCoffee";
            chkCoffee.Size = new Size(75, 24);
            chkCoffee.TabIndex = 0;
            chkCoffee.Text = "Coffee";
            chkCoffee.UseVisualStyleBackColor = true;
            chkCoffee.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkGreentea
            // 
            chkGreentea.AutoSize = true;
            chkGreentea.Location = new Point(15, 58);
            chkGreentea.Name = "chkGreentea";
            chkGreentea.Size = new Size(98, 24);
            chkGreentea.TabIndex = 1;
            chkGreentea.Text = "Green Tea";
            chkGreentea.UseVisualStyleBackColor = true;
            chkGreentea.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // CostBox1
            // 
            CostBox1.Enabled = false;
            CostBox1.Location = new Point(205, 19);
            CostBox1.Name = "CostBox1";
            CostBox1.Size = new Size(129, 33);
            CostBox1.TabIndex = 2;
            CostBox1.Text = "";
            CostBox1.TextChanged += CostBox1_TextChanged;
            // 
            // CostBox2
            // 
            CostBox2.Enabled = false;
            CostBox2.Location = new Point(205, 58);
            CostBox2.Name = "CostBox2";
            CostBox2.Size = new Size(129, 33);
            CostBox2.TabIndex = 3;
            CostBox2.Text = "";
            // 
            // PieceBox1
            // 
            PieceBox1.Enabled = false;
            PieceBox1.Location = new Point(340, 19);
            PieceBox1.Name = "PieceBox1";
            PieceBox1.Size = new Size(129, 33);
            PieceBox1.TabIndex = 4;
            PieceBox1.Text = "";
            // 
            // PieceBox2
            // 
            PieceBox2.Enabled = false;
            PieceBox2.Location = new Point(340, 58);
            PieceBox2.Name = "PieceBox2";
            PieceBox2.Size = new Size(129, 33);
            PieceBox2.TabIndex = 5;
            PieceBox2.Text = "";
            // 
            // TotalBox
            // 
            TotalBox.Location = new Point(659, 33);
            TotalBox.Name = "TotalBox";
            TotalBox.ScrollBars = RichTextBoxScrollBars.None;
            TotalBox.Size = new Size(129, 33);
            TotalBox.TabIndex = 6;
            TotalBox.Text = "";
            TotalBox.TextChanged += TotalBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 46);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 7;
            label1.Text = "Total";
            // 
            // CheckOutbutton
            // 
            CheckOutbutton.Location = new Point(546, 123);
            CheckOutbutton.Name = "CheckOutbutton";
            CheckOutbutton.Size = new Size(116, 67);
            CheckOutbutton.TabIndex = 8;
            CheckOutbutton.Text = "Checkout";
            CheckOutbutton.UseVisualStyleBackColor = true;
            CheckOutbutton.Click += CheckOutbutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 85);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 10;
            label2.Text = "Cash";
            label2.Click += label2_Click;
            // 
            // cash1
            // 
            cash1.Location = new Point(659, 72);
            cash1.Name = "cash1";
            cash1.Size = new Size(129, 33);
            cash1.TabIndex = 9;
            cash1.Text = "";
            cash1.TextChanged += cash1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(574, 236);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 12;
            label3.Text = "Change";
            // 
            // Change
            // 
            Change.Location = new Point(659, 223);
            Change.Name = "Change";
            Change.Size = new Size(129, 33);
            Change.TabIndex = 11;
            Change.Text = "";
            Change.TextChanged += richTextBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 317);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 14;
            label4.Text = "1000";
            // 
            // One_t
            // 
            One_t.Location = new Point(574, 304);
            One_t.Name = "One_t";
            One_t.Size = new Size(94, 33);
            One_t.TabIndex = 13;
            One_t.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(537, 355);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 16;
            label5.Text = "500";
            label5.Click += label5_Click;
            // 
            // five_h
            // 
            five_h.Location = new Point(574, 343);
            five_h.Name = "five_h";
            five_h.Size = new Size(94, 33);
            five_h.TabIndex = 15;
            five_h.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(537, 395);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 18;
            label6.Text = "100";
            // 
            // One_h
            // 
            One_h.Location = new Point(574, 382);
            One_h.Name = "One_h";
            One_h.Size = new Size(94, 33);
            One_h.TabIndex = 17;
            One_h.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(543, 434);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 20;
            label7.Text = "50";
            // 
            // fifty
            // 
            fifty.Location = new Point(574, 421);
            fifty.Name = "fifty";
            fifty.Size = new Size(94, 33);
            fifty.TabIndex = 19;
            fifty.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(543, 473);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 22;
            label8.Text = "20";
            // 
            // twenty
            // 
            twenty.Location = new Point(574, 460);
            twenty.Name = "twenty";
            twenty.Size = new Size(94, 33);
            twenty.TabIndex = 21;
            twenty.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(694, 277);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 26;
            label9.Text = "5";
            // 
            // five
            // 
            five.Location = new Point(721, 265);
            five.Name = "five";
            five.Size = new Size(94, 33);
            five.TabIndex = 25;
            five.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(539, 511);
            label10.Name = "label10";
            label10.Size = new Size(25, 20);
            label10.TabIndex = 24;
            label10.Text = "10";
            // 
            // ten
            // 
            ten.Location = new Point(574, 498);
            ten.Name = "ten";
            ten.Size = new Size(94, 33);
            ten.TabIndex = 23;
            ten.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(694, 316);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 28;
            label11.Text = "1";
            // 
            // one
            // 
            one.Location = new Point(721, 304);
            one.Name = "one";
            one.Size = new Size(94, 33);
            one.TabIndex = 27;
            one.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(694, 123);
            button1.Name = "button1";
            button1.Size = new Size(120, 67);
            button1.TabIndex = 29;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Baverage
            // 
            Baverage.Controls.Add(PieceBox2);
            Baverage.Controls.Add(PieceBox1);
            Baverage.Controls.Add(CostBox2);
            Baverage.Controls.Add(CostBox1);
            Baverage.Controls.Add(chkGreentea);
            Baverage.Controls.Add(chkCoffee);
            Baverage.Location = new Point(35, 23);
            Baverage.Name = "Baverage";
            Baverage.Size = new Size(485, 109);
            Baverage.TabIndex = 44;
            Baverage.TabStop = false;
            Baverage.Text = "Baverage";
            Baverage.Enter += Baverage_Enter;
            // 
            // Food
            // 
            Food.Controls.Add(PieceBox4);
            Food.Controls.Add(PieceBox3);
            Food.Controls.Add(CostBox4);
            Food.Controls.Add(CostBox3);
            Food.Controls.Add(chkFriedChicken);
            Food.Controls.Add(chkPizza);
            Food.Location = new Point(35, 147);
            Food.Name = "Food";
            Food.Size = new Size(485, 109);
            Food.TabIndex = 45;
            Food.TabStop = false;
            Food.Text = "Food";
            // 
            // PieceBox4
            // 
            PieceBox4.Enabled = false;
            PieceBox4.Location = new Point(340, 58);
            PieceBox4.Name = "PieceBox4";
            PieceBox4.Size = new Size(129, 33);
            PieceBox4.TabIndex = 5;
            PieceBox4.Text = "";
            // 
            // PieceBox3
            // 
            PieceBox3.Enabled = false;
            PieceBox3.Location = new Point(340, 19);
            PieceBox3.Name = "PieceBox3";
            PieceBox3.Size = new Size(129, 33);
            PieceBox3.TabIndex = 4;
            PieceBox3.Text = "";
            // 
            // CostBox4
            // 
            CostBox4.Enabled = false;
            CostBox4.Location = new Point(205, 58);
            CostBox4.Name = "CostBox4";
            CostBox4.Size = new Size(129, 33);
            CostBox4.TabIndex = 3;
            CostBox4.Text = "";
            // 
            // CostBox3
            // 
            CostBox3.Enabled = false;
            CostBox3.Location = new Point(205, 19);
            CostBox3.Name = "CostBox3";
            CostBox3.Size = new Size(129, 33);
            CostBox3.TabIndex = 2;
            CostBox3.Text = "";
            // 
            // chkFriedChicken
            // 
            chkFriedChicken.AutoSize = true;
            chkFriedChicken.Location = new Point(15, 58);
            chkFriedChicken.Name = "chkFriedChicken";
            chkFriedChicken.Size = new Size(119, 24);
            chkFriedChicken.TabIndex = 1;
            chkFriedChicken.Text = "Fried Chicken";
            chkFriedChicken.UseVisualStyleBackColor = true;
            chkFriedChicken.CheckedChanged += chkFriedChicken_CheckedChanged;
            // 
            // chkPizza
            // 
            chkPizza.AutoSize = true;
            chkPizza.Location = new Point(15, 19);
            chkPizza.Name = "chkPizza";
            chkPizza.Size = new Size(65, 24);
            chkPizza.TabIndex = 0;
            chkPizza.Text = "Pizza";
            chkPizza.UseVisualStyleBackColor = true;
            chkPizza.CheckedChanged += chkPizza_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(Food_disc);
            groupBox1.Controls.Add(chkAll_disc);
            groupBox1.Controls.Add(Bav_disc);
            groupBox1.Controls.Add(All_disc);
            groupBox1.Controls.Add(chkFood_disc);
            groupBox1.Controls.Add(chkBaverage_disc);
            groupBox1.Location = new Point(35, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 142);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Discount";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(458, 104);
            label14.Name = "label14";
            label14.Size = new Size(21, 20);
            label14.TabIndex = 49;
            label14.Text = "%";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(458, 65);
            label13.Name = "label13";
            label13.Size = new Size(21, 20);
            label13.TabIndex = 48;
            label13.Text = "%";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(458, 26);
            label12.Name = "label12";
            label12.Size = new Size(21, 20);
            label12.TabIndex = 47;
            label12.Text = "%";
            label12.Click += label12_Click_1;
            // 
            // Food_disc
            // 
            Food_disc.Enabled = false;
            Food_disc.Location = new Point(327, 97);
            Food_disc.Name = "Food_disc";
            Food_disc.Size = new Size(129, 33);
            Food_disc.TabIndex = 8;
            Food_disc.Text = "";
            // 
            // chkAll_disc
            // 
            chkAll_disc.AutoSize = true;
            chkAll_disc.Location = new Point(15, 26);
            chkAll_disc.Name = "chkAll_disc";
            chkAll_disc.Size = new Size(49, 24);
            chkAll_disc.TabIndex = 6;
            chkAll_disc.Text = "All";
            chkAll_disc.UseVisualStyleBackColor = true;
            chkAll_disc.CheckedChanged += chkAll_disc_CheckedChanged;
            // 
            // Bav_disc
            // 
            Bav_disc.Enabled = false;
            Bav_disc.Location = new Point(327, 58);
            Bav_disc.Name = "Bav_disc";
            Bav_disc.Size = new Size(129, 33);
            Bav_disc.TabIndex = 5;
            Bav_disc.Text = "";
            // 
            // All_disc
            // 
            All_disc.Enabled = false;
            All_disc.Location = new Point(327, 19);
            All_disc.Name = "All_disc";
            All_disc.Size = new Size(129, 33);
            All_disc.TabIndex = 4;
            All_disc.Text = "";
            All_disc.TextChanged += richTextBox2_TextChanged_1;
            // 
            // chkFood_disc
            // 
            chkFood_disc.AutoSize = true;
            chkFood_disc.Location = new Point(15, 99);
            chkFood_disc.Name = "chkFood_disc";
            chkFood_disc.Size = new Size(127, 24);
            chkFood_disc.TabIndex = 1;
            chkFood_disc.Text = "Food Discount";
            chkFood_disc.UseVisualStyleBackColor = true;
            chkFood_disc.CheckedChanged += chkFood_disc_CheckedChanged;
            // 
            // chkBaverage_disc
            // 
            chkBaverage_disc.AutoSize = true;
            chkBaverage_disc.Location = new Point(15, 61);
            chkBaverage_disc.Name = "chkBaverage_disc";
            chkBaverage_disc.Size = new Size(155, 24);
            chkBaverage_disc.TabIndex = 0;
            chkBaverage_disc.Text = "Baverage Discount";
            chkBaverage_disc.UseVisualStyleBackColor = true;
            chkBaverage_disc.CheckedChanged += checkBox2_CheckedChanged_1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(675, 395);
            label15.Name = "label15";
            label15.Size = new Size(36, 20);
            label15.TabIndex = 50;
            label15.Text = "0.25";
            // 
            // twentyfive_stng
            // 
            twentyfive_stng.Location = new Point(721, 382);
            twentyfive_stng.Name = "twentyfive_stng";
            twentyfive_stng.Size = new Size(94, 33);
            twentyfive_stng.TabIndex = 49;
            twentyfive_stng.Text = "";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(675, 355);
            label16.Name = "label16";
            label16.Size = new Size(36, 20);
            label16.TabIndex = 48;
            label16.Text = "0.50";
            // 
            // fifty_stng
            // 
            fifty_stng.Location = new Point(721, 343);
            fifty_stng.Name = "fifty_stng";
            fifty_stng.Size = new Size(94, 33);
            fifty_stng.TabIndex = 47;
            fifty_stng.Text = "";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(675, 434);
            label17.Name = "label17";
            label17.Size = new Size(36, 20);
            label17.TabIndex = 52;
            label17.Text = "0.10";
            // 
            // ten_stng
            // 
            ten_stng.Location = new Point(720, 421);
            ten_stng.Name = "ten_stng";
            ten_stng.Size = new Size(94, 33);
            ten_stng.TabIndex = 51;
            ten_stng.Text = "";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(675, 473);
            label18.Name = "label18";
            label18.Size = new Size(36, 20);
            label18.TabIndex = 54;
            label18.Text = "0.05";
            // 
            // zerozero_five
            // 
            zerozero_five.Location = new Point(720, 460);
            zerozero_five.Name = "zerozero_five";
            zerozero_five.Size = new Size(94, 33);
            zerozero_five.TabIndex = 53;
            zerozero_five.Text = "";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(675, 511);
            label19.Name = "label19";
            label19.Size = new Size(36, 20);
            label19.TabIndex = 56;
            label19.Text = "0.01";
            // 
            // zerozero_one
            // 
            zerozero_one.Location = new Point(720, 498);
            zerozero_one.Name = "zerozero_one";
            zerozero_one.Size = new Size(94, 33);
            zerozero_one.TabIndex = 55;
            zerozero_one.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 543);
            Controls.Add(label19);
            Controls.Add(zerozero_one);
            Controls.Add(label18);
            Controls.Add(zerozero_five);
            Controls.Add(label17);
            Controls.Add(ten_stng);
            Controls.Add(label15);
            Controls.Add(twentyfive_stng);
            Controls.Add(label16);
            Controls.Add(fifty_stng);
            Controls.Add(groupBox1);
            Controls.Add(Food);
            Controls.Add(Baverage);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(one);
            Controls.Add(label9);
            Controls.Add(five);
            Controls.Add(label10);
            Controls.Add(ten);
            Controls.Add(label8);
            Controls.Add(twenty);
            Controls.Add(label7);
            Controls.Add(fifty);
            Controls.Add(label6);
            Controls.Add(One_h);
            Controls.Add(label5);
            Controls.Add(five_h);
            Controls.Add(label4);
            Controls.Add(One_t);
            Controls.Add(label3);
            Controls.Add(Change);
            Controls.Add(label2);
            Controls.Add(cash1);
            Controls.Add(CheckOutbutton);
            Controls.Add(label1);
            Controls.Add(TotalBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Baverage.ResumeLayout(false);
            Baverage.PerformLayout();
            Food.ResumeLayout(false);
            Food.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkCoffee;
        private CheckBox chkGreentea;
        private RichTextBox CostBox1;
        private RichTextBox CostBox2;
        private RichTextBox PieceBox1;
        private RichTextBox PieceBox2;
        private RichTextBox TotalBox;
        private Label label1;
        private Button CheckOutbutton;
        private Label label2;
        private RichTextBox cash1;
        private Label label3;
        private RichTextBox Change;
        private Label label4;
        private RichTextBox One_t;
        private Label label5;
        private RichTextBox five_h;
        private Label label6;
        private RichTextBox One_h;
        private Label label7;
        private RichTextBox fifty;
        private Label label8;
        private RichTextBox twenty;
        private Label label9;
        private RichTextBox five;
        private Label label10;
        private RichTextBox ten;
        private Label label11;
        private RichTextBox one;
        private Button button1;
        private GroupBox Baverage;
        private GroupBox Food;
        private RichTextBox PieceBox4;
        private RichTextBox PieceBox3;
        private RichTextBox CostBox4;
        private RichTextBox CostBox3;
        private CheckBox chkFriedChicken;
        private CheckBox chkPizza;
        private GroupBox groupBox1;
        private RichTextBox Food_disc;
        private CheckBox chkAll_disc;
        private RichTextBox Bav_disc;
        private RichTextBox All_disc;
        private CheckBox chkFood_disc;
        private CheckBox chkBaverage_disc;
        private Label label12;
        private Label label14;
        private Label label13;
        private Label label15;
        private RichTextBox twentyfive_stng;
        private Label label16;
        private RichTextBox fifty_stng;
        private Label label17;
        private RichTextBox ten_stng;
        private Label label18;
        private RichTextBox zerozero_five;
        private Label label19;
        private RichTextBox zerozero_one;
    }
}
