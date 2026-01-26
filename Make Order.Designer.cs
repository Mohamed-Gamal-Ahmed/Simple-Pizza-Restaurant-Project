namespace Pizza____Poject
{
    partial class FrmMakeOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.ResetOrder = new System.Windows.Forms.Button();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeout = new System.Windows.Forms.RadioButton();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbSizeValue = new System.Windows.Forms.Label();
            this.lbToppingsValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbNumberofPizza = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbSize.ForeColor = System.Drawing.Color.White;
            this.gbSize.Location = new System.Drawing.Point(466, 105);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 126);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(24, 92);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(66, 23);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Location = new System.Drawing.Point(24, 58);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(83, 23);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(24, 24);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(66, 23);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbCrustType.ForeColor = System.Drawing.Color.White;
            this.gbCrustType.Location = new System.Drawing.Point(466, 279);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(200, 110);
            this.gbCrustType.TabIndex = 1;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(6, 68);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(107, 23);
            this.rbThickCrust.TabIndex = 1;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "20";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThink_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Location = new System.Drawing.Point(6, 34);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(101, 23);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(388, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderPizza.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnOrderPizza.Location = new System.Drawing.Point(466, 508);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(119, 39);
            this.btnOrderPizza.TabIndex = 3;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // ResetOrder
            // 
            this.ResetOrder.BackColor = System.Drawing.Color.Transparent;
            this.ResetOrder.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ResetOrder.Location = new System.Drawing.Point(687, 508);
            this.ResetOrder.Name = "ResetOrder";
            this.ResetOrder.Size = new System.Drawing.Size(119, 39);
            this.ResetOrder.TabIndex = 4;
            this.ResetOrder.Text = "Recet Order";
            this.ResetOrder.UseVisualStyleBackColor = false;
            this.ResetOrder.Click += new System.EventHandler(this.ResetOrder_Click);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkGreenPepper);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbToppings.ForeColor = System.Drawing.Color.White;
            this.gbToppings.Location = new System.Drawing.Point(675, 102);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(233, 129);
            this.gbToppings.TabIndex = 5;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkGreenPepper.Location = new System.Drawing.Point(132, 90);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(106, 21);
            this.chkGreenPepper.TabIndex = 5;
            this.chkGreenPepper.Tag = "5";
            this.chkGreenPepper.Text = "GreenPepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            this.chkGreenPepper.CheckedChanged += new System.EventHandler(this.chkGreenPepper_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkOlives.Location = new System.Drawing.Point(132, 58);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(62, 21);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkOnion.Location = new System.Drawing.Point(132, 26);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(63, 21);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkTomatoes.Location = new System.Drawing.Point(6, 89);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(88, 21);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkMushrooms.Location = new System.Drawing.Point(7, 58);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(98, 21);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkExtraChees.Location = new System.Drawing.Point(7, 27);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(101, 21);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rbTakeout);
            this.gbWhereToEat.Controls.Add(this.rbEatin);
            this.gbWhereToEat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbWhereToEat.ForeColor = System.Drawing.Color.White;
            this.gbWhereToEat.Location = new System.Drawing.Point(681, 279);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(200, 110);
            this.gbWhereToEat.TabIndex = 2;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeout
            // 
            this.rbTakeout.AutoSize = true;
            this.rbTakeout.Location = new System.Drawing.Point(102, 53);
            this.rbTakeout.Name = "rbTakeout";
            this.rbTakeout.Size = new System.Drawing.Size(92, 23);
            this.rbTakeout.TabIndex = 1;
            this.rbTakeout.TabStop = true;
            this.rbTakeout.Text = "Take Out";
            this.rbTakeout.UseVisualStyleBackColor = true;
            this.rbTakeout.CheckedChanged += new System.EventHandler(this.rbTakeout_CheckedChanged);
            // 
            // rbEatin
            // 
            this.rbEatin.AutoSize = true;
            this.rbEatin.Checked = true;
            this.rbEatin.Location = new System.Drawing.Point(6, 45);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(69, 23);
            this.rbEatin.TabIndex = 0;
            this.rbEatin.TabStop = true;
            this.rbEatin.Text = "Eat In";
            this.rbEatin.UseVisualStyleBackColor = true;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Size:";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.BackColor = System.Drawing.Color.Transparent;
            this.lbToppings.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lbToppings.ForeColor = System.Drawing.Color.Transparent;
            this.lbToppings.Location = new System.Drawing.Point(14, 97);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(89, 22);
            this.lbToppings.TabIndex = 8;
            this.lbToppings.Text = "Toppings:";
            // 
            // lbSizeValue
            // 
            this.lbSizeValue.AutoSize = true;
            this.lbSizeValue.BackColor = System.Drawing.Color.Transparent;
            this.lbSizeValue.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbSizeValue.ForeColor = System.Drawing.Color.Transparent;
            this.lbSizeValue.Location = new System.Drawing.Point(119, 65);
            this.lbSizeValue.Name = "lbSizeValue";
            this.lbSizeValue.Size = new System.Drawing.Size(55, 17);
            this.lbSizeValue.TabIndex = 9;
            this.lbSizeValue.Text = "Medium";
            // 
            // lbToppingsValue
            // 
            this.lbToppingsValue.BackColor = System.Drawing.Color.Transparent;
            this.lbToppingsValue.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbToppingsValue.ForeColor = System.Drawing.Color.Transparent;
            this.lbToppingsValue.Location = new System.Drawing.Point(47, 130);
            this.lbToppingsValue.Name = "lbToppingsValue";
            this.lbToppingsValue.Size = new System.Drawing.Size(225, 53);
            this.lbToppingsValue.TabIndex = 10;
            this.lbToppingsValue.Text = "No Toppings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Crust Type:";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.lbCrustType.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbCrustType.ForeColor = System.Drawing.Color.Transparent;
            this.lbCrustType.Location = new System.Drawing.Point(170, 213);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(71, 17);
            this.lbCrustType.TabIndex = 12;
            this.lbCrustType.Text = "Thin Crust";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Where To Eat:";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.lbWhereToEat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbWhereToEat.ForeColor = System.Drawing.Color.Transparent;
            this.lbWhereToEat.Location = new System.Drawing.Point(187, 267);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(64, 17);
            this.lbWhereToEat.TabIndex = 14;
            this.lbWhereToEat.Text = "Take Out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.Location = new System.Drawing.Point(14, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Price:";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalPrice.Font = new System.Drawing.Font("Stencil", 20F);
            this.lbTotalPrice.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbTotalPrice.Location = new System.Drawing.Point(154, 397);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(46, 32);
            this.lbTotalPrice.TabIndex = 16;
            this.lbTotalPrice.Text = "$0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.numericUpDown1.Location = new System.Drawing.Point(65, 352);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbNumberofPizza
            // 
            this.lbNumberofPizza.AutoSize = true;
            this.lbNumberofPizza.BackColor = System.Drawing.Color.Transparent;
            this.lbNumberofPizza.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbNumberofPizza.ForeColor = System.Drawing.Color.Transparent;
            this.lbNumberofPizza.Location = new System.Drawing.Point(46, 308);
            this.lbNumberofPizza.Name = "lbNumberofPizza";
            this.lbNumberofPizza.Size = new System.Drawing.Size(154, 24);
            this.lbNumberofPizza.TabIndex = 18;
            this.lbNumberofPizza.Text = "Number of Pizza";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbTotalPrice);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbNumberofPizza);
            this.groupBox1.Controls.Add(this.lbSizeValue);
            this.groupBox1.Controls.Add(this.lbToppings);
            this.groupBox1.Controls.Add(this.lbToppingsValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbWhereToEat);
            this.groupBox1.Controls.Add(this.lbCrustType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(914, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 449);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summar Order";
            // 
            // FrmMakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza____Poject.Properties.Resources.pizza_pepperoni_banner_free_space_text_mockup_fast_food_top_view_empty_professional_phonography_997345_18773;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.ResetOrder);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FrmMakeOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMakeOrder_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button ResetOrder;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeout;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbSizeValue;
        private System.Windows.Forms.Label lbToppingsValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbNumberofPizza;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}