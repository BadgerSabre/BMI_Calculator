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
        private double userHeight { get; set; }
        private double userWeight;
        private double userAge;
        private float userBMI;
        public BMI_Calculator()
        {
            InitializeComponent();
        }
        private double getUserHeight()
        {
            double userInputFeetOrMeters = Convert.ToDouble(textBoxHeightFeetorMeters.Text);
            double userInputInchesOrCentimeters = Convert.ToDouble(textBoxHeightInchesOrCm.Text);
            return userHeight = (userInputFeetOrMeters * 12) + userInputInchesOrCentimeters;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            userHeight = getUserHeight();
            calculateBtn.Text = $"{userHeight}";
        }
    }
}
