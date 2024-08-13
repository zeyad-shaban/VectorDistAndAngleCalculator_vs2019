
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
            this.SuspendLayout();
            // 
            // p1Txt
            // 
            this.p1Txt.Location = new System.Drawing.Point(85, 18);
            this.p1Txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p1Txt.Name = "p1Txt";
            this.p1Txt.Size = new System.Drawing.Size(171, 22);
            this.p1Txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Point2";
            // 
            // p2Txt
            // 
            this.p2Txt.Location = new System.Drawing.Point(85, 62);
            this.p2Txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p2Txt.Name = "p2Txt";
            this.p2Txt.Size = new System.Drawing.Size(171, 22);
            this.p2Txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alpha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Beta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gamma";
            // 
            // distTxt
            // 
            this.distTxt.Location = new System.Drawing.Point(27, 253);
            this.distTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.distTxt.Name = "distTxt";
            this.distTxt.Size = new System.Drawing.Size(115, 22);
            this.distTxt.TabIndex = 8;
            // 
            // alphaTxt
            // 
            this.alphaTxt.Location = new System.Drawing.Point(172, 253);
            this.alphaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alphaTxt.Name = "alphaTxt";
            this.alphaTxt.Size = new System.Drawing.Size(109, 22);
            this.alphaTxt.TabIndex = 9;
            // 
            // betaTxt
            // 
            this.betaTxt.Location = new System.Drawing.Point(314, 253);
            this.betaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.betaTxt.Name = "betaTxt";
            this.betaTxt.Size = new System.Drawing.Size(125, 22);
            this.betaTxt.TabIndex = 10;
            // 
            // gammaTxt
            // 
            this.gammaTxt.Location = new System.Drawing.Point(485, 253);
            this.gammaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gammaTxt.Name = "gammaTxt";
            this.gammaTxt.Size = new System.Drawing.Size(136, 22);
            this.gammaTxt.TabIndex = 11;
            // 
            // startCalculateBtn
            // 
            this.startCalculateBtn.Location = new System.Drawing.Point(36, 140);
            this.startCalculateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startCalculateBtn.Name = "startCalculateBtn";
            this.startCalculateBtn.Size = new System.Drawing.Size(183, 44);
            this.startCalculateBtn.TabIndex = 12;
            this.startCalculateBtn.Text = "Start Calculating";
            this.startCalculateBtn.UseVisualStyleBackColor = true;
            this.startCalculateBtn.Click += new System.EventHandler(this.startCalculateBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(314, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "*Separate x,y,z with commas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 438);
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
    }
}

