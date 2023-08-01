//Nicole Morrison
//CITP4350 Week 7 Travel Expenses GUI

namespace TravelExpenses
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
            this.lblDays = new System.Windows.Forms.Label();
            this.lblAirFare = new System.Windows.Forms.Label();
            this.lblCarRental = new System.Windows.Forms.Label();
            this.lblMilesDriven = new System.Windows.Forms.Label();
            this.lblParkingFees = new System.Windows.Forms.Label();
            this.lblTaxiFees = new System.Windows.Forms.Label();
            this.lblConfFees = new System.Windows.Forms.Label();
            this.lblLodgingFees = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtAirFare = new System.Windows.Forms.TextBox();
            this.txtCarRental = new System.Windows.Forms.TextBox();
            this.txtMilesDriven = new System.Windows.Forms.TextBox();
            this.txtParkingFees = new System.Windows.Forms.TextBox();
            this.txtTaxiFees = new System.Windows.Forms.TextBox();
            this.txtConfFees = new System.Windows.Forms.TextBox();
            this.txtLodgingFees = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblUserSpent = new System.Windows.Forms.Label();
            this.lblMaxAllowed = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblNoDecimal_1 = new System.Windows.Forms.Label();
            this.lblNoDecimals_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(57, 44);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(134, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Enter Total Days of Travel:";
            // 
            // lblAirFare
            // 
            this.lblAirFare.AutoSize = true;
            this.lblAirFare.Location = new System.Drawing.Point(57, 68);
            this.lblAirFare.Name = "lblAirFare";
            this.lblAirFare.Size = new System.Drawing.Size(85, 13);
            this.lblAirFare.TabIndex = 1;
            this.lblAirFare.Text = "Air Fare Amount:";
            // 
            // lblCarRental
            // 
            this.lblCarRental.AutoSize = true;
            this.lblCarRental.Location = new System.Drawing.Point(57, 91);
            this.lblCarRental.Name = "lblCarRental";
            this.lblCarRental.Size = new System.Drawing.Size(99, 13);
            this.lblCarRental.TabIndex = 2;
            this.lblCarRental.Text = "Car Rental Amount:";
            // 
            // lblMilesDriven
            // 
            this.lblMilesDriven.AutoSize = true;
            this.lblMilesDriven.Location = new System.Drawing.Point(57, 114);
            this.lblMilesDriven.Name = "lblMilesDriven";
            this.lblMilesDriven.Size = new System.Drawing.Size(161, 13);
            this.lblMilesDriven.TabIndex = 3;
            this.lblMilesDriven.Text = "Miles Driven in Personal Vehicle:";
            // 
            // lblParkingFees
            // 
            this.lblParkingFees.AutoSize = true;
            this.lblParkingFees.Location = new System.Drawing.Point(57, 137);
            this.lblParkingFees.Name = "lblParkingFees";
            this.lblParkingFees.Size = new System.Drawing.Size(111, 13);
            this.lblParkingFees.TabIndex = 4;
            this.lblParkingFees.Text = "Parking Fees Amount:";
            // 
            // lblTaxiFees
            // 
            this.lblTaxiFees.AutoSize = true;
            this.lblTaxiFees.Location = new System.Drawing.Point(58, 161);
            this.lblTaxiFees.Name = "lblTaxiFees";
            this.lblTaxiFees.Size = new System.Drawing.Size(95, 13);
            this.lblTaxiFees.TabIndex = 5;
            this.lblTaxiFees.Text = "Taxi Fees Amount:";
            // 
            // lblConfFees
            // 
            this.lblConfFees.AutoSize = true;
            this.lblConfFees.Location = new System.Drawing.Point(60, 185);
            this.lblConfFees.Name = "lblConfFees";
            this.lblConfFees.Size = new System.Drawing.Size(173, 13);
            this.lblConfFees.TabIndex = 6;
            this.lblConfFees.Text = "Conference/Seminar Fees Amount:";
            // 
            // lblLodgingFees
            // 
            this.lblLodgingFees.AutoSize = true;
            this.lblLodgingFees.Location = new System.Drawing.Point(63, 211);
            this.lblLodgingFees.Name = "lblLodgingFees";
            this.lblLodgingFees.Size = new System.Drawing.Size(113, 13);
            this.lblLodgingFees.TabIndex = 7;
            this.lblLodgingFees.Text = "Lodging Fees Amount:";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(197, 41);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 8;
            this.txtDays.Text = "0";
            // 
            // txtAirFare
            // 
            this.txtAirFare.Location = new System.Drawing.Point(149, 65);
            this.txtAirFare.Name = "txtAirFare";
            this.txtAirFare.Size = new System.Drawing.Size(100, 20);
            this.txtAirFare.TabIndex = 9;
            this.txtAirFare.Text = "0.00";
            // 
            // txtCarRental
            // 
            this.txtCarRental.Location = new System.Drawing.Point(162, 87);
            this.txtCarRental.Name = "txtCarRental";
            this.txtCarRental.Size = new System.Drawing.Size(100, 20);
            this.txtCarRental.TabIndex = 10;
            this.txtCarRental.Text = "0.00";
            // 
            // txtMilesDriven
            // 
            this.txtMilesDriven.Location = new System.Drawing.Point(224, 110);
            this.txtMilesDriven.Name = "txtMilesDriven";
            this.txtMilesDriven.Size = new System.Drawing.Size(100, 20);
            this.txtMilesDriven.TabIndex = 11;
            this.txtMilesDriven.Text = "0";
            // 
            // txtParkingFees
            // 
            this.txtParkingFees.Location = new System.Drawing.Point(175, 133);
            this.txtParkingFees.Name = "txtParkingFees";
            this.txtParkingFees.Size = new System.Drawing.Size(100, 20);
            this.txtParkingFees.TabIndex = 12;
            this.txtParkingFees.Text = "0.00";
            // 
            // txtTaxiFees
            // 
            this.txtTaxiFees.Location = new System.Drawing.Point(159, 157);
            this.txtTaxiFees.Name = "txtTaxiFees";
            this.txtTaxiFees.Size = new System.Drawing.Size(100, 20);
            this.txtTaxiFees.TabIndex = 13;
            this.txtTaxiFees.Text = "0.00";
            // 
            // txtConfFees
            // 
            this.txtConfFees.Location = new System.Drawing.Point(240, 181);
            this.txtConfFees.Name = "txtConfFees";
            this.txtConfFees.Size = new System.Drawing.Size(100, 20);
            this.txtConfFees.TabIndex = 14;
            this.txtConfFees.Text = "0.00";
            // 
            // txtLodgingFees
            // 
            this.txtLodgingFees.Location = new System.Drawing.Point(183, 208);
            this.txtLodgingFees.Name = "txtLodgingFees";
            this.txtLodgingFees.Size = new System.Drawing.Size(100, 20);
            this.txtLodgingFees.TabIndex = 15;
            this.txtLodgingFees.Text = "0.00";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(149, 300);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblUserSpent
            // 
            this.lblUserSpent.AutoSize = true;
            this.lblUserSpent.Location = new System.Drawing.Point(12, 243);
            this.lblUserSpent.Name = "lblUserSpent";
            this.lblUserSpent.Size = new System.Drawing.Size(60, 13);
            this.lblUserSpent.TabIndex = 17;
            this.lblUserSpent.Text = "You Spent:";
            // 
            // lblMaxAllowed
            // 
            this.lblMaxAllowed.AutoSize = true;
            this.lblMaxAllowed.Location = new System.Drawing.Point(12, 259);
            this.lblMaxAllowed.Name = "lblMaxAllowed";
            this.lblMaxAllowed.Size = new System.Drawing.Size(94, 13);
            this.lblMaxAllowed.TabIndex = 18;
            this.lblMaxAllowed.Text = "Maximum Allowed:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 275);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(116, 13);
            this.lblMessage.TabIndex = 19;
            this.lblMessage.Text = "Reimbursement Result:";
            // 
            // lblNoDecimal_1
            // 
            this.lblNoDecimal_1.AutoSize = true;
            this.lblNoDecimal_1.Location = new System.Drawing.Point(303, 43);
            this.lblNoDecimal_1.Name = "lblNoDecimal_1";
            this.lblNoDecimal_1.Size = new System.Drawing.Size(67, 13);
            this.lblNoDecimal_1.TabIndex = 20;
            this.lblNoDecimal_1.Text = "No Decimals";
            // 
            // lblNoDecimals_2
            // 
            this.lblNoDecimals_2.AutoSize = true;
            this.lblNoDecimals_2.Location = new System.Drawing.Point(331, 112);
            this.lblNoDecimals_2.Name = "lblNoDecimals_2";
            this.lblNoDecimals_2.Size = new System.Drawing.Size(67, 13);
            this.lblNoDecimals_2.TabIndex = 21;
            this.lblNoDecimals_2.Text = "No Decimals";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.lblNoDecimals_2);
            this.Controls.Add(this.lblNoDecimal_1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblMaxAllowed);
            this.Controls.Add(this.lblUserSpent);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLodgingFees);
            this.Controls.Add(this.txtConfFees);
            this.Controls.Add(this.txtTaxiFees);
            this.Controls.Add(this.txtParkingFees);
            this.Controls.Add(this.txtMilesDriven);
            this.Controls.Add(this.txtCarRental);
            this.Controls.Add(this.txtAirFare);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblLodgingFees);
            this.Controls.Add(this.lblConfFees);
            this.Controls.Add(this.lblTaxiFees);
            this.Controls.Add(this.lblParkingFees);
            this.Controls.Add(this.lblMilesDriven);
            this.Controls.Add(this.lblCarRental);
            this.Controls.Add(this.lblAirFare);
            this.Controls.Add(this.lblDays);
            this.Name = "Form1";
            this.Text = "Calculate Travel Expense Reimbursement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblAirFare;
        private System.Windows.Forms.Label lblCarRental;
        private System.Windows.Forms.Label lblMilesDriven;
        private System.Windows.Forms.Label lblParkingFees;
        private System.Windows.Forms.Label lblTaxiFees;
        private System.Windows.Forms.Label lblConfFees;
        private System.Windows.Forms.Label lblLodgingFees;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtAirFare;
        private System.Windows.Forms.TextBox txtCarRental;
        private System.Windows.Forms.TextBox txtMilesDriven;
        private System.Windows.Forms.TextBox txtParkingFees;
        private System.Windows.Forms.TextBox txtTaxiFees;
        private System.Windows.Forms.TextBox txtConfFees;
        private System.Windows.Forms.TextBox txtLodgingFees;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblUserSpent;
        private System.Windows.Forms.Label lblMaxAllowed;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblNoDecimal_1;
        private System.Windows.Forms.Label lblNoDecimals_2;
    }
}