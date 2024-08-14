
namespace VectorDistAndAngleCalculator_vs2019
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
            this.p1Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p2Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.distTxt = new System.Windows.Forms.TextBox();
            this.alphaTxt = new System.Windows.Forms.TextBox();
            this.betaTxt = new System.Windows.Forms.TextBox();
            this.gammaTxt = new System.Windows.Forms.TextBox();
            this.startCalculateBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.projGammaTxt = new System.Windows.Forms.TextBox();
            this.projBetaTxt = new System.Windows.Forms.TextBox();
            this.projAlphaTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // p1Txt
            // 
            this.p1Txt.Location = new System.Drawing.Point(96, 22);
            this.p1Txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p1Txt.Name = "p1Txt";
            this.p1Txt.Size = new System.Drawing.Size(192, 26);
            this.p1Txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Point2";
            // 
            // p2Txt
            // 
            this.p2Txt.Location = new System.Drawing.Point(96, 78);
            this.p2Txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p2Txt.Name = "p2Txt";
            this.p2Txt.Size = new System.Drawing.Size(192, 26);
            this.p2Txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alpha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Beta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gamma";
            // 
            // distTxt
            // 
            this.distTxt.Location = new System.Drawing.Point(30, 316);
            this.distTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.distTxt.Name = "distTxt";
            this.distTxt.Size = new System.Drawing.Size(129, 26);
            this.distTxt.TabIndex = 8;
            // 
            // alphaTxt
            // 
            this.alphaTxt.Location = new System.Drawing.Point(349, 316);
            this.alphaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alphaTxt.Name = "alphaTxt";
            this.alphaTxt.Size = new System.Drawing.Size(122, 26);
            this.alphaTxt.TabIndex = 9;
            this.alphaTxt.TextChanged += new System.EventHandler(this.alphaTxt_TextChanged);
            // 
            // betaTxt
            // 
            this.betaTxt.Location = new System.Drawing.Point(508, 316);
            this.betaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.betaTxt.Name = "betaTxt";
            this.betaTxt.Size = new System.Drawing.Size(140, 26);
            this.betaTxt.TabIndex = 10;
            // 
            // gammaTxt
            // 
            this.gammaTxt.Location = new System.Drawing.Point(701, 316);
            this.gammaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gammaTxt.Name = "gammaTxt";
            this.gammaTxt.Size = new System.Drawing.Size(152, 26);
            this.gammaTxt.TabIndex = 11;
            // 
            // startCalculateBtn
            // 
            this.startCalculateBtn.Location = new System.Drawing.Point(40, 175);
            this.startCalculateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startCalculateBtn.Name = "startCalculateBtn";
            this.startCalculateBtn.Size = new System.Drawing.Size(206, 55);
            this.startCalculateBtn.TabIndex = 12;
            this.startCalculateBtn.Text = "Start Calculating";
            this.startCalculateBtn.UseVisualStyleBackColor = true;
            this.startCalculateBtn.Click += new System.EventHandler(this.startCalculateBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(353, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "*Separate x,y,z with commas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Direction Cosine";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Projection method";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Method";
            // 
            // projGammaTxt
            // 
            this.projGammaTxt.Location = new System.Drawing.Point(701, 392);
            this.projGammaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projGammaTxt.Name = "projGammaTxt";
            this.projGammaTxt.Size = new System.Drawing.Size(152, 26);
            this.projGammaTxt.TabIndex = 19;
            // 
            // projBetaTxt
            // 
            this.projBetaTxt.Location = new System.Drawing.Point(508, 392);
            this.projBetaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projBetaTxt.Name = "projBetaTxt";
            this.projBetaTxt.Size = new System.Drawing.Size(140, 26);
            this.projBetaTxt.TabIndex = 18;
            // 
            // projAlphaTxt
            // 
            this.projAlphaTxt.Location = new System.Drawing.Point(349, 392);
            this.projAlphaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projAlphaTxt.Name = "projAlphaTxt";
            this.projAlphaTxt.Size = new System.Drawing.Size(122, 26);
            this.projAlphaTxt.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 548);
            this.Controls.Add(this.projGammaTxt);
            this.Controls.Add(this.projBetaTxt);
            this.Controls.Add(this.projAlphaTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startCalculateBtn);
            this.Controls.Add(this.gammaTxt);
            this.Controls.Add(this.betaTxt);
            this.Controls.Add(this.alphaTxt);
            this.Controls.Add(this.distTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p2Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1Txt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p1Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p2Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox distTxt;
        private System.Windows.Forms.TextBox alphaTxt;
        private System.Windows.Forms.TextBox betaTxt;
        private System.Windows.Forms.TextBox gammaTxt;
        private System.Windows.Forms.Button startCalculateBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox projGammaTxt;
        private System.Windows.Forms.TextBox projBetaTxt;
        private System.Windows.Forms.TextBox projAlphaTxt;
    }
}

