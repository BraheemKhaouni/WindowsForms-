namespace _01_Task
{
    partial class HappyForm
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
            this.pbHappy = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHappy)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHappy
            // 
            this.pbHappy.Image = global::_01_Task.Properties.Resources.customer_service1;
            this.pbHappy.Location = new System.Drawing.Point(48, 12);
            this.pbHappy.Name = "pbHappy";
            this.pbHappy.Size = new System.Drawing.Size(273, 273);
            this.pbHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHappy.TabIndex = 0;
            this.pbHappy.TabStop = false;
            this.pbHappy.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(138, 291);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // HappyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(378, 338);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbHappy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HappyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbHappy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHappy;
        private System.Windows.Forms.Button btnOK;
    }
}