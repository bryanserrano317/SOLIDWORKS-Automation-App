namespace automationapp
{
    partial class boltForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lengthDim = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.staticIntroText = new System.Windows.Forms.TextBox();
            this.thicknessDim = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 89);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Build!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lengthDim
            // 
            this.lengthDim.Location = new System.Drawing.Point(12, 72);
            this.lengthDim.Name = "lengthDim";
            this.lengthDim.Size = new System.Drawing.Size(165, 22);
            this.lengthDim.TabIndex = 3;
            this.lengthDim.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(-12, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Length";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(152, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "mm";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::automationapp.Properties.Resources.Screenshot_2022_02_03_120016;
            this.pictureBox2.Location = new System.Drawing.Point(282, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // staticIntroText
            // 
            this.staticIntroText.BackColor = System.Drawing.Color.White;
            this.staticIntroText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staticIntroText.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticIntroText.Location = new System.Drawing.Point(12, 17);
            this.staticIntroText.Name = "staticIntroText";
            this.staticIntroText.ReadOnly = true;
            this.staticIntroText.Size = new System.Drawing.Size(193, 23);
            this.staticIntroText.TabIndex = 12;
            this.staticIntroText.Text = "Bolt Design";
            // 
            // thicknessDim
            // 
            this.thicknessDim.Location = new System.Drawing.Point(12, 127);
            this.thicknessDim.Name = "thicknessDim";
            this.thicknessDim.Size = new System.Drawing.Size(165, 22);
            this.thicknessDim.TabIndex = 13;
            this.thicknessDim.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(152, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(101, 23);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "mm";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(-1, 100);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(101, 23);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Thickness";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boltForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 261);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.thicknessDim);
            this.Controls.Add(this.staticIntroText);
            this.Controls.Add(this.lengthDim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Name = "boltForm";
            this.Text = "SOLIDWORKS Automation - Bolt (Hardware)";
            this.Load += new System.EventHandler(this.screwForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lengthDim;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox staticIntroText;
        private System.Windows.Forms.TextBox thicknessDim;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}