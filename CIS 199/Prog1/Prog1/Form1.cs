//B6600
//Prog1
//Due Date: 9/27/2016
//CIS 199-75
//This program allows the user to input the square feet, number of coats, and price per gallon of paint
//and displays the total suqare feet, gallons needed, hrs of labor, paint cost, labor cost, and total cost.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Prog1 : Form
    {
        //Declare Constants
        const decimal SQUARE_FEET = 275m;//Assigns SQUARE_FEET 275 (Decimal)
        const decimal HOURS_PER_GALLON = 8m;//Assigns HOUR_PER_GALLON as 8 (Decimal)
        const decimal LABOR_COST_PER_HOUR = 12.50m;//Assigns LABOR_COST_PER_HOUR as 12.5 (Decimal)
        public Prog1()
        {
            InitializeComponent();
        }

        private void calculateTotalsButton_Click(object sender, EventArgs e)
        {
            //Assign Variables
            decimal squareFeetInput;//Declares decimal variable to hold square feet input
            int coatsOfPaintInput;//Declares integer variable to hold coats of paint input
            decimal dollarPerGallonInput;//Declares decimal variable to hold dollars per gallon input
            decimal totalSquareFeetOutput;//Declares decimal variable to hold total square feet output
            decimal gallonsNeededOutput;//Declares decimal variable to hold gallons needed output
            decimal totalHoursOfLaborOutput;//Declares decimal variable to hold total hours of labor output
            decimal totalPaintCostOutput;//Declares decimal variable to hold total paint cost output
            decimal totalLaborCostOutput;//Declares decimal variable to hold total labor cost output
            decimal totalCostOutput;//Declares decimal variable to hold total cost output

            squareFeetInput = decimal.Parse(enterSquareFeetTextBox.Text);//Converts entered square feet text to a decimal

            coatsOfPaintInput = int.Parse(enterCoatsOfPaintTextBox.Text);//Converts entered coats of paint text to an integer

            dollarPerGallonInput = decimal.Parse(enterDollarsPerGalTextBox.Text);//Converts entered dollar per gallon text to a decimal

            totalSquareFeetOutput = squareFeetInput * coatsOfPaintInput;//Calculates Total Square Feet

            gallonsNeededOutput = totalSquareFeetOutput / SQUARE_FEET;//Calculates Gallons Needed

            totalHoursOfLaborOutput = gallonsNeededOutput * HOURS_PER_GALLON;//Calculates Total Hours of Labor Needed

            totalPaintCostOutput = Math.Ceiling(gallonsNeededOutput) * dollarPerGallonInput;//Calculates Total Paint Cost

            totalLaborCostOutput = totalHoursOfLaborOutput * LABOR_COST_PER_HOUR;//Calculates Total Cost of Labor

            totalCostOutput = totalPaintCostOutput + totalLaborCostOutput;//Calculates the combined Total of Labor Cost and Paint Cost


            totalSquareFeetOutputLabel.Text = totalSquareFeetOutput.ToString();//Displays Total Square Feet in Output Label

            gallonsNeededOutputLabel.Text = Math.Ceiling(gallonsNeededOutput).ToString();//Displays Gallons Needed in Output Label

            hoursOfLaborOutputLabel.Text = totalHoursOfLaborOutput.ToString("n1");//Displays Total Hours of Labor in Output Label

            paintCostOutputLabel.Text = totalPaintCostOutput.ToString("c");//Displays Total Paint Cost in Output Label

            laborCostOutputLabel.Text = totalLaborCostOutput.ToString("c");//Displays Total Labor Cost in Output Label

            totalCostOutputLabel.Text = totalCostOutput.ToString("c");//Displays Total Cost of Labor and Paint in Output Label




        }
    }
}
