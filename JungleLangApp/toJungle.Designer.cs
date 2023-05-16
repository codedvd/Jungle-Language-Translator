namespace JungleLangApp
{
    partial class toJungle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toJungle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.englishPh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.translateEP = new System.Windows.Forms.TextBox();
            this.convertE = new System.Windows.Forms.Button();
            this.backTE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-14, -21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 84);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(157, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "TRANSLATING FROM ENGLISH";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(-14, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 45);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert English Pharse:";
            // 
            // englishPh
            // 
            this.englishPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishPh.Location = new System.Drawing.Point(230, 105);
            this.englishPh.Multiline = true;
            this.englishPh.Name = "englishPh";
            this.englishPh.Size = new System.Drawing.Size(357, 65);
            this.englishPh.TabIndex = 4;
            this.englishPh.TextChanged += new System.EventHandler(this.englishPh_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jungled Words:";
            // 
            // translateEP
            // 
            this.translateEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateEP.Location = new System.Drawing.Point(230, 198);
            this.translateEP.Multiline = true;
            this.translateEP.Name = "translateEP";
            this.translateEP.Size = new System.Drawing.Size(357, 105);
            this.translateEP.TabIndex = 6;
            this.translateEP.TextChanged += new System.EventHandler(this.translateEP_TextChanged);
            // 
            // convertE
            // 
            this.convertE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.convertE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.convertE.Location = new System.Drawing.Point(475, 318);
            this.convertE.Name = "convertE";
            this.convertE.Size = new System.Drawing.Size(111, 37);
            this.convertE.TabIndex = 7;
            this.convertE.Text = "CONVERT";
            this.convertE.UseVisualStyleBackColor = false;
            this.convertE.Click += new System.EventHandler(this.button1_Click);
            // 
            // backTE
            // 
            this.backTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backTE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backTE.Location = new System.Drawing.Point(41, 318);
            this.backTE.Name = "backTE";
            this.backTE.Size = new System.Drawing.Size(90, 37);
            this.backTE.TabIndex = 14;
            this.backTE.Text = "BACK";
            this.backTE.UseVisualStyleBackColor = false;
            this.backTE.Click += new System.EventHandler(this.backTE_Click);
            // 
            // toJungle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 378);
            this.Controls.Add(this.backTE);
            this.Controls.Add(this.convertE);
            this.Controls.Add(this.translateEP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.englishPh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "toJungle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "toJungle";
            this.Load += new System.EventHandler(this.toJungle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox englishPh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox translateEP;
        private System.Windows.Forms.Button convertE;
        private System.Windows.Forms.Button backTE;
    }
}