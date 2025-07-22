namespace WindowsFormsApp5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.DRINKS1 = new WindowsFormsApp5.DRINKS1();
            this.BURGER1 = new WindowsFormsApp5.BURGER1();
            this.DEAL4 = new WindowsFormsApp5.DEAL4();
            this.BURGER2 = new WindowsFormsApp5.BURGER2();
            this.firstex3 = new WindowsFormsApp5.firstex3();
            this.firstex2 = new WindowsFormsApp5.firstex2();
            this.firstex1 = new WindowsFormsApp5.firstex1();
            this.cart1 = new WindowsFormsApp5.cart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 651);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.sidepanel.Location = new System.Drawing.Point(3, 80);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(14, 65);
            this.sidepanel.TabIndex = 2;
            this.sidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(16, 481);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(227, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "CART";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(16, 381);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "DEALS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(16, 183);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "BURGERS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(16, 280);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "DRINKS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(16, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(532, 572);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(286, 67);
            this.button9.TabIndex = 15;
            this.button9.Text = "NEXT";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 40);
            this.panel2.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(810, -1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(54, 46);
            this.button10.TabIndex = 0;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(532, 572);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(286, 67);
            this.button6.TabIndex = 4;
            this.button6.Text = "NEXT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(180)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(372, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "MEGA DEALS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(180)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(374, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 60);
            this.label2.TabIndex = 9;
            this.label2.Text = "BURGERS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(532, 572);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(286, 67);
            this.button7.TabIndex = 10;
            this.button7.Text = "NEXT";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(532, 572);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(286, 67);
            this.button8.TabIndex = 11;
            this.button8.Text = "BACK";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // DRINKS1
            // 
            this.DRINKS1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DRINKS1.Location = new System.Drawing.Point(282, 126);
            this.DRINKS1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DRINKS1.Name = "DRINKS1";
            this.DRINKS1.Size = new System.Drawing.Size(760, 420);
            this.DRINKS1.TabIndex = 16;
            // 
            // BURGER1
            // 
            this.BURGER1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BURGER1.Location = new System.Drawing.Point(282, 126);
            this.BURGER1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BURGER1.Name = "BURGER1";
            this.BURGER1.Size = new System.Drawing.Size(760, 420);
            this.BURGER1.TabIndex = 15;
            // 
            // DEAL4
            // 
            this.DEAL4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DEAL4.Location = new System.Drawing.Point(282, 126);
            this.DEAL4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DEAL4.Name = "DEAL4";
            this.DEAL4.Size = new System.Drawing.Size(760, 420);
            this.DEAL4.TabIndex = 14;
            // 
            // BURGER2
            // 
            this.BURGER2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BURGER2.Location = new System.Drawing.Point(282, 126);
            this.BURGER2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BURGER2.Name = "BURGER2";
            this.BURGER2.Size = new System.Drawing.Size(760, 420);
            this.BURGER2.TabIndex = 8;
            // 
            // firstex3
            // 
            this.firstex3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstex3.Location = new System.Drawing.Point(282, 126);
            this.firstex3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstex3.Name = "firstex3";
            this.firstex3.Size = new System.Drawing.Size(760, 420);
            this.firstex3.TabIndex = 5;
            // 
            // firstex2
            // 
            this.firstex2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstex2.Location = new System.Drawing.Point(282, 126);
            this.firstex2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstex2.Name = "firstex2";
            this.firstex2.Size = new System.Drawing.Size(760, 420);
            this.firstex2.TabIndex = 3;
            // 
            // firstex1
            // 
            this.firstex1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstex1.Location = new System.Drawing.Point(282, 126);
            this.firstex1.Margin = new System.Windows.Forms.Padding(0);
            this.firstex1.Name = "firstex1";
            this.firstex1.Size = new System.Drawing.Size(760, 420);
            this.firstex1.TabIndex = 2;
            // 
            // cart1
            // 
            this.cart1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cart1.Location = new System.Drawing.Point(282, 125);
            this.cart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cart1.Name = "cart1";
            this.cart1.Size = new System.Drawing.Size(760, 421);
            this.cart1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(180)))), ((int)(((byte)(18)))));
            this.label3.Location = new System.Drawing.Point(372, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(565, 60);
            this.label3.TabIndex = 13;
            this.label3.Text = "DRINKS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(180)))), ((int)(((byte)(18)))));
            this.label4.Location = new System.Drawing.Point(372, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(565, 60);
            this.label4.TabIndex = 18;
            this.label4.Text = "CART";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 651);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cart1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.DRINKS1);
            this.Controls.Add(this.BURGER1);
            this.Controls.Add(this.DEAL4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BURGER2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstex3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.firstex2);
            this.Controls.Add(this.firstex1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel sidepanel;
        private firstex1 firstex1;
        private firstex2 firstex2;
        private System.Windows.Forms.Button button6;
        private firstex3 firstex3;
        private System.Windows.Forms.Label label1;
        private BURGER2 BURGER2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private DEAL4 DEAL4;
        private System.Windows.Forms.Button button9;
        private BURGER1 BURGER1;
        private DRINKS1 DRINKS1;
        private cart cart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button10;
    }
}

