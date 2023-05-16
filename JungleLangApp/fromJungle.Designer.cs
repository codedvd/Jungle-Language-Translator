namespace JungleLangApp
{
    partial class fromJungle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromJungle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.convertJ = new System.Windows.Forms.Button();
            this.translateEg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jungEg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backTJ = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
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
            this.label3.Location = new System.Drawing.Point(637, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 29);
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
            this.label2.Location = new System.Drawing.Point(146, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "TRANSLATING FROM JUNGLE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(-14, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 45);
            this.panel2.TabIndex = 3;
            // 
            // convertJ
            // 
            this.convertJ.BackColor = System.Drawing.Color.Red;
            this.convertJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertJ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.convertJ.Location = new System.Drawing.Point(481, 304);
            this.convertJ.Name = "convertJ";
            this.convertJ.Size = new System.Drawing.Size(111, 37);
            this.convertJ.TabIndex = 12;
            this.convertJ.Text = "CONVERT";
            this.convertJ.UseVisualStyleBackColor = false;
            // 
            // translateEg
            // 
            this.translateEg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateEg.Location = new System.Drawing.Point(235, 173);
            this.translateEg.Multiline = true;
            this.translateEg.Name = "translateEg";
            this.translateEg.Size = new System.Drawing.Size(357, 105);
            this.translateEg.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "English Words:";
            // 
            // jungEg
            // 
            this.jungEg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jungEg.Location = new System.Drawing.Point(235, 80);
            this.jungEg.Multiline = true;
            this.jungEg.Name = "jungEg";
            this.jungEg.Size = new System.Drawing.Size(357, 65);
            this.jungEg.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insert Jungled Pharse:";
            // 
            // backTJ
            // 
            this.backTJ.BackColor = System.Drawing.Color.Red;
            this.backTJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backTJ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backTJ.Location = new System.Drawing.Point(46, 304);
            this.backTJ.Name = "backTJ";
            this.backTJ.Size = new System.Drawing.Size(90, 37);
            this.backTJ.TabIndex = 13;
            this.backTJ.Text = "BACK";
            this.backTJ.UseVisualStyleBackColor = false;
            this.backTJ.Click += new System.EventHandler(this.backTJ_Click);
            // 
            // fromJungle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 378);
            this.Controls.Add(this.backTJ);
            this.Controls.Add(this.convertJ);
            this.Controls.Add(this.translateEg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jungEg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fromJungle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fromJungle";
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
        private System.Windows.Forms.Button convertJ;
        private System.Windows.Forms.TextBox translateEg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jungEg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backTJ;
    }
}