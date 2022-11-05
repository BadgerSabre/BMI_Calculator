using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class BMI_Calculator : Form
    {
        private double userHeight;
        private double userWeight;
        private double userAge;
        private float userBMI;
        public BMI_Calculator()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            calculateBtn.Text = "Hello world!";
        }
    }
}
