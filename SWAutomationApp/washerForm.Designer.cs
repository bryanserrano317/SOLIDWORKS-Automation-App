namespace automationapp
{
    partial class washerForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.outsidetxt = new System.Windows.Forms.TextBox();
            this.insidetxt = new System.Windows.Forms.TextBox();
            this.thicknesstxt = new System.Windows.Forms.TextBox();
            this.build_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.staticIntroText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outsidetxt
            // 
            this.outsidetxt.Location = new System.Drawing.Point(12, 77);
            this.outsidetxt.Name = "outsidetxt";
            this.outsidetxt.Size = new System.Drawing.Size(100, 22);
            this.outsidetxt.TabIndex = 0;
            this.outsidetxt.TextChanged += new System.EventHandler(this.outsidetxt_TextChanged);
            // 
            // insidetxt
            // 
            this.insidetxt.Location = new System.Drawing.Point(12, 138);
            this.insidetxt.Name = "insidetxt";
            this.insidetxt.Size = new System.Drawing.Size(100, 22);
            this.insidetxt.TabIndex = 1;
            // 
            // thicknesstxt
            // 
            this.thicknesstxt.Location = new System.Drawing.Point(12, 195);
            this.thicknesstxt.Name = "thicknesstxt";
            this.thicknesstxt.Size = new System.Drawing.Size(100, 22);
            this.thicknesstxt.TabIndex = 2;
            // 
            // build_button
            // 
            this.build_button.BackColor = System.Drawing.Color.White;
            this.build_button.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.build_button.Location = new System.Drawing.Point(12, 244);
            this.build_button.Name = "build_button";
            this.build_button.Size = new System.Drawing.Size(182, 53);
            this.build_button.TabIndex = 3;
            this.build_button.Text = "Start Build!";
            this.build_button.UseVisualStyleBackColor = false;
            this.build_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Outside Diameter";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(167, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Inside Diameter";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(156, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Thickness";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(118, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "mm";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(118, 138);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "mm";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(118, 77);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "mm";
            // 
            // staticIntroText
            // 
            this.staticIntroText.BackColor = System.Drawing.Color.White;
            this.staticIntroText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staticIntroText.Font = new System.Drawing.Font("3ds", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticIntroText.Location = new System.Drawing.Point(12, 12);
            this.staticIntroText.Name = "staticIntroText";
            this.staticIntroText.ReadOnly = true;
            this.staticIntroText.Size = new System.Drawing.Size(329, 23);
            this.staticIntroText.TabIndex = 11;
            this.staticIntroText.Text = "Washer Design";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::automationapp.Properties.Resources.Screenshot_2022_02_03_120626;
            this.pictureBox1.Location = new System.Drawing.Point(213, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // washerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 319);
            this.Controls.Add(this.staticIntroText);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.build_button);
            this.Controls.Add(this.thicknesstxt);
            this.Controls.Add(this.insidetxt);
            this.Controls.Add(this.outsidetxt);
            this.Name = "washerForm";
            this.Text = "SOLIDWORKS Automation - Washer";
            this.Load += new System.EventHandler(this.washerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox outsidetxt;
        private System.Windows.Forms.TextBox insidetxt;
        private System.Windows.Forms.TextBox thicknesstxt;
        private System.Windows.Forms.Button build_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox staticIntroText;
    }
}