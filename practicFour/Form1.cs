using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            try {

                corn.BackColor = Color.White;
                answer.BackColor = Color.White;
                bob.BackColor = Color.White;
                double ChanceLow, ChanceHigh, ChanceStable, CornHighNew, CornStableNew, CornLowNew, BobHighNew, BobStableNew, BobLowNew, answerNew;
                fillingInVariables(out ChanceLow, out ChanceHigh, out ChanceStable, out CornHighNew, out CornStableNew, out CornLowNew, out BobHighNew, out BobStableNew, out BobLowNew);
                priceVariables(ChanceLow, ChanceHigh, ChanceStable, CornHighNew, CornStableNew, CornLowNew, BobHighNew, BobStableNew, BobLowNew);

                corn.Text = Convert.ToString((ChanceHigh * CornHighNew) + (ChanceStable * CornStableNew) + (ChanceLow * CornLowNew));
                bob.Text = Convert.ToString((ChanceHigh * BobHighNew) + (ChanceStable * BobStableNew) + (ChanceLow * BobLowNew));

                double cornResault = (ChanceHigh * CornHighNew) + (ChanceStable * CornStableNew) + (ChanceLow * CornLowNew);
                double bobResault = (ChanceHigh * BobHighNew) + (ChanceStable * BobStableNew) + (ChanceLow * BobLowNew);

                if (cornResault > bobResault)
                {
                    answer.Text = "Кукуруза";
                    answer.BackColor = Color.Green;
                    corn.BackColor = Color.Green;

                }
                else if (cornResault < bobResault)
                {
                    answer.Text = "Бобы";
                    answer.BackColor = Color.Green;
                    bob.BackColor = Color.Green;
                }
                else
                {
                    answer.Text = "Выгода одинаковая";
                    answer.BackColor = Color.Yellow;
                    bob.BackColor = Color.Green;
                    corn.BackColor = Color.Green;

                }
            }
            catch
            {
                MessageBox.Show("Неккоректные данные!!!");
            }

        }

        private void priceVariables(double ChanceLow, double ChanceHigh, double ChanceStable, double CornHighNew, double CornStableNew, double CornLowNew, double BobHighNew, double BobStableNew, double BobLowNew)
        {
            a1.Text = Convert.ToString(ChanceHigh * CornHighNew);
            b1.Text = Convert.ToString(ChanceStable * CornStableNew);
            c1.Text = Convert.ToString(ChanceLow * CornLowNew);

            a2.Text = Convert.ToString(ChanceHigh * BobHighNew);
            b2.Text = Convert.ToString(ChanceStable * BobStableNew);
            c2.Text = Convert.ToString(ChanceLow * BobLowNew);
        }

        private void fillingInVariables(out double ChanceLow, out double ChanceHigh, out double ChanceStable, out double CornHighNew, out double CornStableNew, out double CornLowNew, out double BobHighNew, out double BobStableNew, out double BobLowNew)
        {
            ChanceLow = Convert.ToDouble(lowPrice.Text);
            ChanceHigh = Convert.ToDouble(highPrice.Text);
            ChanceStable = Convert.ToDouble(stablePrice.Text);

            CornHighNew = Convert.ToDouble(cornHigh.Text);
            CornStableNew = Convert.ToDouble(CornStable.Text);
            CornLowNew = Convert.ToDouble(CornLow.Text);

            BobHighNew = Convert.ToDouble(BobHigh.Text);
            BobStableNew = Convert.ToDouble(BobStable.Text);
            BobLowNew = Convert.ToDouble(BobLow.Text);
        }
    }
}
