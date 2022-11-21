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
            if(String.IsNullOrEmpty(textBoxHeightFeetorMeters.Text) || String.IsNullOrEmpty(textBoxHeightInchesOrCm.Text))
            {
                return userHeight = 0;
            }
            else
            {
                if (metricToggle)
                {
                    double userInputFeetOrMeters = Convert.ToDouble(textBoxHeightFeetorMeters.Text);
                    double userInputInchesOrCentimeters = Convert.ToDouble(textBoxHeightInchesOrCm.Text);
                    return userHeight = (userInputFeetOrMeters * 100) + userInputInchesOrCentimeters;
                }
                else
                {
                    double userInputFeetOrMeters = Convert.ToDouble(textBoxHeightFeetorMeters.Text);
                    double userInputInchesOrCentimeters = Convert.ToDouble(textBoxHeightInchesOrCm.Text);
                    return userHeight = (userInputFeetOrMeters * 12) + userInputInchesOrCentimeters;
                }
            }
        }

        private double getUserWeight()
        {
            if (String.IsNullOrEmpty(textBoxWeightLbOrKg.Text))
            {
                return userWeight = 0;
            } 
            else
            {
                double userInputWeight = Convert.ToDouble(textBoxWeightLbOrKg.Text);
                return userWeight = userInputWeight;
            }
        }

        private double getUserAge()
        {
            if (String.IsNullOrEmpty(textBoxAge.Text))
            {
                return userAge = 0;
            }
            else
            {
                double userInputAge = Convert.ToDouble(textBoxAge.Text);
                return userAge = userInputAge;
            }
        }
        
        private void toggleMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleMetric.Checked)
            {
               metricToggle = true;
               bigHeightUnits.Text = "m";
               littleHeightUnits.Text = "cm";
               weightUnits.Text = "kg";
               textBoxHeightInchesOrCm.Maximum = 999;
            } 
            else
            {
                metricToggle = false;
                bigHeightUnits.Text = "ft";
                littleHeightUnits.Text = "in";
                weightUnits.Text = "lb";
                textBoxHeightInchesOrCm.Maximum = 11;
            }
        }
        // Method to change BMIResult text and truncate result
        private void displayUserBMI()
        {
            BMIResult.Text = $"{Math.Round(userBMI, 1)}";
        }

        // Method to calculate BMI onClick
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            userHeight = getUserHeight();
            userWeight = getUserWeight();
            userAge = getUserAge();

            if (userHeight > 0 && userWeight > 0 && userAge > 0 && metricToggle == false)
            {
                userBMI = (userWeight / (userHeight * userHeight)) * 703;
                displayUserBMI();
            } 
            if (userHeight > 0 && userWeight > 0 && userAge > 0 && metricToggle)
            {
                double numerator = userWeight / userHeight;
                userBMI = (numerator / userHeight) * 10000;
                displayUserBMI();
            }
            else
            {
                errorMessageDisplay.Text = "Invalid User Input. Please try again.";
            }

        }
    }
}
