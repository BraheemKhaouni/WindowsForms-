namespace Hamburger
{
    partial class Hamburger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hamburger));
            this.pnlSize = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.pnlToppings = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chbVegetables = new System.Windows.Forms.CheckBox();
            this.chbSauces = new System.Windows.Forms.CheckBox();
            this.chbCheese = new System.Windows.Forms.CheckBox();
            this.chbFriedOnions = new System.Windows.Forms.CheckBox();
            this.pnlCrustTybe = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFishPatty = new System.Windows.Forms.RadioButton();
            this.rbChickenPatty = new System.Windows.Forms.RadioButton();
            this.rbHalalPatty = new System.Windows.Forms.RadioButton();
            this.rbBeefPatty = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPatty = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSize.SuspendLayout();
            this.pnlToppings.SuspendLayout();
            this.pnlCrustTybe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSize
            // 
            this.pnlSize.Controls.Add(this.label2);
            this.pnlSize.Controls.Add(this.rbLarge);
            this.pnlSize.Controls.Add(this.rbMedium);
            this.pnlSize.Controls.Add(this.rbSmall);
            this.pnlSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSize.ForeColor = System.Drawing.Color.White;
            this.pnlSize.Location = new System.Drawing.Point(45, 67);
            this.pnlSize.Name = "pnlSize";
            this.pnlSize.Size = new System.Drawing.Size(118, 188);
            this.pnlSize.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.ForeColor = System.Drawing.Color.LimeGreen;
            this.rbLarge.Location = new System.Drawing.Point(21, 149);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(73, 24);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "50";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.ForeColor = System.Drawing.Color.LimeGreen;
            this.rbMedium.Location = new System.Drawing.Point(21, 108);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(89, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "40";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.ForeColor = System.Drawing.Color.LimeGreen;
            this.rbSmall.Location = new System.Drawing.Point(21, 67);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(71, 24);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "30";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // pnlToppings
            // 
            this.pnlToppings.Controls.Add(this.label4);
            this.pnlToppings.Controls.Add(this.chbVegetables);
            this.pnlToppings.Controls.Add(this.chbSauces);
            this.pnlToppings.Controls.Add(this.chbCheese);
            this.pnlToppings.Controls.Add(this.chbFriedOnions);
            this.pnlToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlToppings.ForeColor = System.Drawing.Color.White;
            this.pnlToppings.Location = new System.Drawing.Point(221, 67);
            this.pnlToppings.Name = "pnlToppings";
            this.pnlToppings.Size = new System.Drawing.Size(146, 224);
            this.pnlToppings.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "Topping";
            // 
            // chbVegetables
            // 
            this.chbVegetables.AutoSize = true;
            this.chbVegetables.ForeColor = System.Drawing.Color.LightCoral;
            this.chbVegetables.Location = new System.Drawing.Point(13, 153);
            this.chbVegetables.Name = "chbVegetables";
            this.chbVegetables.Size = new System.Drawing.Size(119, 24);
            this.chbVegetables.TabIndex = 3;
            this.chbVegetables.Tag = "10";
            this.chbVegetables.Text = "Vegetables";
            this.chbVegetables.UseVisualStyleBackColor = true;
            this.chbVegetables.CheckedChanged += new System.EventHandler(this.chbVegetables_CheckedChanged);
            // 
            // chbSauces
            // 
            this.chbSauces.AutoSize = true;
            this.chbSauces.ForeColor = System.Drawing.Color.LightCoral;
            this.chbSauces.Location = new System.Drawing.Point(13, 110);
            this.chbSauces.Name = "chbSauces";
            this.chbSauces.Size = new System.Drawing.Size(88, 24);
            this.chbSauces.TabIndex = 2;
            this.chbSauces.Tag = "10";
            this.chbSauces.Text = "Sauces";
            this.chbSauces.UseVisualStyleBackColor = true;
            this.chbSauces.CheckedChanged += new System.EventHandler(this.chbSauces_CheckedChanged);
            // 
            // chbCheese
            // 
            this.chbCheese.AutoSize = true;
            this.chbCheese.ForeColor = System.Drawing.Color.LightCoral;
            this.chbCheese.Location = new System.Drawing.Point(13, 196);
            this.chbCheese.Name = "chbCheese";
            this.chbCheese.Size = new System.Drawing.Size(89, 24);
            this.chbCheese.TabIndex = 1;
            this.chbCheese.Tag = "10";
            this.chbCheese.Text = "Cheese";
            this.chbCheese.UseVisualStyleBackColor = true;
            this.chbCheese.CheckedChanged += new System.EventHandler(this.chbCheese_CheckedChanged);
            // 
            // chbFriedOnions
            // 
            this.chbFriedOnions.AutoSize = true;
            this.chbFriedOnions.ForeColor = System.Drawing.Color.LightCoral;
            this.chbFriedOnions.Location = new System.Drawing.Point(13, 67);
            this.chbFriedOnions.Name = "chbFriedOnions";
            this.chbFriedOnions.Size = new System.Drawing.Size(130, 24);
            this.chbFriedOnions.TabIndex = 0;
            this.chbFriedOnions.Tag = "10";
            this.chbFriedOnions.Text = "Fried Onions";
            this.chbFriedOnions.UseVisualStyleBackColor = true;
            this.chbFriedOnions.CheckedChanged += new System.EventHandler(this.chbFriedOnions_CheckedChanged);
            // 
            // pnlCrustTybe
            // 
            this.pnlCrustTybe.Controls.Add(this.label5);
            this.pnlCrustTybe.Controls.Add(this.rbFishPatty);
            this.pnlCrustTybe.Controls.Add(this.rbChickenPatty);
            this.pnlCrustTybe.Controls.Add(this.rbHalalPatty);
            this.pnlCrustTybe.Controls.Add(this.rbBeefPatty);
            this.pnlCrustTybe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCrustTybe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCrustTybe.Location = new System.Drawing.Point(390, 67);
            this.pnlCrustTybe.Name = "pnlCrustTybe";
            this.pnlCrustTybe.Size = new System.Drawing.Size(157, 224);
            this.pnlCrustTybe.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "Patty";
            // 
            // rbFishPatty
            // 
            this.rbFishPatty.AutoSize = true;
            this.rbFishPatty.ForeColor = System.Drawing.Color.Orange;
            this.rbFishPatty.Location = new System.Drawing.Point(16, 151);
            this.rbFishPatty.Name = "rbFishPatty";
            this.rbFishPatty.Size = new System.Drawing.Size(107, 24);
            this.rbFishPatty.TabIndex = 6;
            this.rbFishPatty.TabStop = true;
            this.rbFishPatty.Tag = "60";
            this.rbFishPatty.Text = "Fish Patty";
            this.rbFishPatty.UseVisualStyleBackColor = true;
            this.rbFishPatty.CheckedChanged += new System.EventHandler(this.rbFishPatty_CheckedChanged);
            // 
            // rbChickenPatty
            // 
            this.rbChickenPatty.AutoSize = true;
            this.rbChickenPatty.ForeColor = System.Drawing.Color.Orange;
            this.rbChickenPatty.Location = new System.Drawing.Point(16, 193);
            this.rbChickenPatty.Name = "rbChickenPatty";
            this.rbChickenPatty.Size = new System.Drawing.Size(137, 24);
            this.rbChickenPatty.TabIndex = 5;
            this.rbChickenPatty.TabStop = true;
            this.rbChickenPatty.Tag = "35";
            this.rbChickenPatty.Text = "Chicken Patty";
            this.rbChickenPatty.UseVisualStyleBackColor = true;
            this.rbChickenPatty.CheckedChanged += new System.EventHandler(this.rbChickenPatty_CheckedChanged);
            // 
            // rbHalalPatty
            // 
            this.rbHalalPatty.AutoSize = true;
            this.rbHalalPatty.ForeColor = System.Drawing.Color.Orange;
            this.rbHalalPatty.Location = new System.Drawing.Point(16, 109);
            this.rbHalalPatty.Name = "rbHalalPatty";
            this.rbHalalPatty.Size = new System.Drawing.Size(114, 24);
            this.rbHalalPatty.TabIndex = 4;
            this.rbHalalPatty.TabStop = true;
            this.rbHalalPatty.Tag = "50";
            this.rbHalalPatty.Text = "Halal Patty";
            this.rbHalalPatty.UseVisualStyleBackColor = true;
            this.rbHalalPatty.CheckedChanged += new System.EventHandler(this.rbHalalPatty_CheckedChanged);
            // 
            // rbBeefPatty
            // 
            this.rbBeefPatty.AutoSize = true;
            this.rbBeefPatty.ForeColor = System.Drawing.Color.Orange;
            this.rbBeefPatty.Location = new System.Drawing.Point(16, 67);
            this.rbBeefPatty.Name = "rbBeefPatty";
            this.rbBeefPatty.Size = new System.Drawing.Size(111, 24);
            this.rbBeefPatty.TabIndex = 3;
            this.rbBeefPatty.TabStop = true;
            this.rbBeefPatty.Tag = "45";
            this.rbBeefPatty.Text = "Beef Patty";
            this.rbBeefPatty.UseVisualStyleBackColor = true;
            this.rbBeefPatty.CheckedChanged += new System.EventHandler(this.rbBeefPatty_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(605, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(719, 157);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(116, 36);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "00:00 $";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(751, 405);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(84, 33);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(611, 405);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(84, 33);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 55);
            this.label3.TabIndex = 8;
            this.label3.Text = "Make Your Humborger";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(552, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 336);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPatty);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.lblTopping);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(45, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summry";
            // 
            // lblPatty
            // 
            this.lblPatty.AutoSize = true;
            this.lblPatty.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatty.ForeColor = System.Drawing.Color.White;
            this.lblPatty.Location = new System.Drawing.Point(113, 109);
            this.lblPatty.Name = "lblPatty";
            this.lblPatty.Size = new System.Drawing.Size(72, 21);
            this.lblPatty.TabIndex = 16;
            this.lblPatty.Text = "Patty..";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(113, 66);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(58, 21);
            this.lblSize.TabIndex = 15;
            this.lblSize.Text = "Size..";
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopping.ForeColor = System.Drawing.Color.White;
            this.lblTopping.Location = new System.Drawing.Point(102, 28);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(85, 21);
            this.lblTopping.TabIndex = 14;
            this.lblTopping.Text = "No,Think";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Patty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Topping";
            // 
            // Hamburger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCrustTybe);
            this.Controls.Add(this.pnlToppings);
            this.Controls.Add(this.pnlSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hamburger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hamburger";
            this.Load += new System.EventHandler(this.Hamburger_Load);
            this.pnlSize.ResumeLayout(false);
            this.pnlSize.PerformLayout();
            this.pnlToppings.ResumeLayout(false);
            this.pnlToppings.PerformLayout();
            this.pnlCrustTybe.ResumeLayout(false);
            this.pnlCrustTybe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Panel pnlToppings;
        private System.Windows.Forms.CheckBox chbVegetables;
        private System.Windows.Forms.CheckBox chbSauces;
        private System.Windows.Forms.CheckBox chbCheese;
        private System.Windows.Forms.CheckBox chbFriedOnions;
        private System.Windows.Forms.Panel pnlCrustTybe;
        private System.Windows.Forms.RadioButton rbHalalPatty;
        private System.Windows.Forms.RadioButton rbBeefPatty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbFishPatty;
        private System.Windows.Forms.RadioButton rbChickenPatty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPatty;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTopping;
    }
}

