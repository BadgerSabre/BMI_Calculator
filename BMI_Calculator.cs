using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class BMI_Calculator : Form
    {
        double userHeight { get; set; }
        double userWeight { get; set; }
        double userAge { get; set; }
        double userBMI { get; set; }
        bool metricToggle { get; set; }
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

            if (userHeight > 0 && userWeight > 0 && userAge > 0)
            {
                userBMI = (userWeight / (userHeight * userHeight)) * 703;
                // Display result
                BMIResult.Text = $"{userBMI}";
            } 
            else
            {
                errorMessageDisplay.Text = "Invalid User Input. Please try again!";
            }

        }
    }
}
