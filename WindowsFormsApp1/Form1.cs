using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mathing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Result(object sender, EventArgs e)
        {
            string error = "";
            if (!(double.TryParse(textBoxA.Text, out double a) && 
                  double.TryParse(textBoxB.Text, out double b) && 
                  double.TryParse(textBoxC.Text, out double c)))
            {
                return;
            }
                
            double[] result = QU.Result(double.Parse(textBoxA.Text), 
                                        double.Parse(textBoxB.Text), 
                                        double.Parse(textBoxC.Text), out error);
            string resultStr = string.Join("\n", result);
            MessageBox.Show(resultStr, error);
        }
    }
}
