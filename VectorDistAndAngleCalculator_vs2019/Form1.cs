using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorDistAndAngleCalculator_vs2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void startCalculateBtn_Click(object sender, EventArgs e)
        {
            // Get points data
            double[] p1Splitted = p1Txt.Text.Split(',').Select(double.Parse).ToArray();
            Point p1 = new Point(p1Splitted[0], p1Splitted[1], p1Splitted[2]);

            double[] p2Splitted = p2Txt.Text.Split(',').Select(double.Parse).ToArray();
            Point p2 = new Point(p2Splitted[0], p2Splitted[1], p2Splitted[2]);

            // Calculate and display distance
            distTxt.Text = Calculator3D.GetDist2Points(p1, p2).ToString();

            // Get and display direction cosines
            var (alpha, beta, gamma) = Calculator3D.GetDirectionCosines(p1, p2);

            alphaTxt.Text = alpha.ToString();
            betaTxt.Text = beta.ToString();
            gammaTxt.Text = gamma.ToString();

            // Get and display direction cosines
            var (alpha_proj, beta_proj, gamma_proj) = Calculator3D.GetAnglesWithProjection(p1, p2);

            projAlphaTxt.Text = alpha_proj.ToString();
            projBetaTxt.Text = beta_proj.ToString();
            projGammaTxt.Text = gamma_proj.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void alphaTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
