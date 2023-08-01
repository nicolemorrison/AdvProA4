//Nicole Morrison
//CITP4350 Week 7 Travel Expenses GUI
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpenses
{
    public partial class Form1 : Form
    {
        //Initialize Form1
        public Form1()
        {
            InitializeComponent();
        }

        //Execute code when the Calculate button is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //save maximum per day for each expense
            double dayMeals = 37.00;
            double dayPark = 10.00;
            double dayTaxi = 20.00;
            double dayLodge = 95.00;
            double perMile = 0.27;

            //values from text boxes saved to variables
            int nDays = Convert.ToInt32(txtDays.Text);
            double airFare = Convert.ToDouble(txtAirFare.Text);
            double carRental = Convert.ToDouble(txtCarRental.Text);
            int milesDriven = Convert.ToInt32(txtMilesDriven.Text);
            double parkingFees = Convert.ToDouble(txtParkingFees.Text);
            double taxiFees = Convert.ToDouble(txtTaxiFees.Text);
            double confFees = Convert.ToDouble(txtConfFees.Text);
            double lodgingFees = Convert.ToDouble(txtLodgingFees.Text);

            //calculate maximum allowed for each category by multiplying times number of days
            double maxMeals = nDays * dayMeals;
            double maxPark = nDays * dayPark;
            double maxTaxi = nDays * dayTaxi;
            double maxLodge = nDays * dayLodge;
            double maxMiles = milesDriven * perMile;

            //sum values for how much user spent and maximum allowed
            double userSpent = airFare + carRental + parkingFees + taxiFees + confFees + lodgingFees + (milesDriven * perMile);
            double maxAllowed = maxMeals + maxPark + maxTaxi + maxLodge + maxMiles + confFees;

            //Change property of lables for UserSpent and MaxAllowed so displays on form
            lblUserSpent.Text = $"You Spent: {userSpent:C}";
            lblMaxAllowed.Text = $"Maximum Allowed: {maxAllowed:C}";

            //if else statement to change display based upon UserSpent being higher - equal - lower than MaximumAllowed
            if (userSpent < maxAllowed)
                lblMessage.Text = $"Thank you! You spent {maxAllowed - userSpent:C} less than allowed and will be fully reimbursed";
            else if (userSpent == maxAllowed)
                lblMessage.Text = "You spent exactly what is allowed and will be fully reimbursed";
            else
                lblMessage.Text = $"You spent more than allowed and will only be reimbursed {maxAllowed:C}";

        }

        
    }
}