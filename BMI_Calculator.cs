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
        private double userWeight { get; set; }
        private double userAge { get; set; }
        private double userBMI { get; set; }
        private bool metricToggle = false;
        public BMI_Calculator()
        {
            InitializeComponent();
        }
        // Methods to capture user input
        private double getUserHeight()
        {
            double userInputFeetOrMeters = Convert.ToDouble(textBoxHeightFeetorMeters.Text);
            double userInputInchesOrCentimeters = Convert.ToDouble(textBoxHeightInchesOrCm.Text);
            return userHeight = (userInputFeetOrMeters * 12) + userInputInchesOrCentimeters;
        }

        private double getUserWeight()
        {
            double userInputWeight = Convert.ToDouble(textBoxWeightLbOrKg.Text);
            return userWeight = userInputWeight;
        }

        private double getUserAge()
        {
            double userInputAge = Convert.ToDouble(textBoxAge.Text);
            return userAge = userInputAge;
        }
        // Method to calculate BMI onClick
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            userHeight = getUserHeight();
            userWeight = getUserWeight();
            userAge = getUserAge();
            userBMI = (userWeight / (userHeight * userHeight)) * 703;

            // Display result
            BMIResult.Text = $"{userBMI}";
        }
    }
}
