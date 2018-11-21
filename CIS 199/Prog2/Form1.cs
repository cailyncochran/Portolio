//B6600
//Program 2
//Due Date: 10/16/2016
//CIS 199-75
//This program allows a user to input their total credit hours before fall 2016 and first letter of their last name.
//The program will then determine the appropriate registration date and time based on the letter the user inputs for spring 2017
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Prog2 : Form
    {
        //declare constants
        double MINIMUM_HOURS = 0;//User can have zero hours, but not below
        double BREAK_BETWEEN_UPPER_LOWER_CLASSMAN = 60; //At 60 hours the student is an upperclassman
        double SENIOR_HOURS = 90;//declares 90 hrs as a senior
        double SOPHOMORE_HOURS = 30;//declares 30 hrs as sophomore
        //HOURS_A,B,C,D,E are hours the students can register
        uint HOUR_A = 2;
        uint HOUR_B = 4;
        uint HOUR_C = 8;
        uint HOUR_D = 10;
        uint HOUR_E = 11;

        public Prog2()
        {
            InitializeComponent();
        }

        //When clicked, this button displays the date and time for a user to register for Spring 2017 Classes
        private void registerButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            double totalCreditHoursInput;//Number of credit hours students have completed
            char lastNameInput;//First letter of last name
            string lastNameInputStr;//Hold last name from textbox

            lastNameInputStr = enterFirstLetterTextbox.Text; //converts the last name input string to text
            lastNameInput = lastNameInputStr[0]; //extracts the first character of the last name
            lastNameInput = char.ToUpper(lastNameInput); //converts a lower case string to an uppercase letter to allow lower and upper case characters to be inputed

            
            if (double.TryParse(enterCompletedHoursTextBox.Text, out totalCreditHoursInput))//the entered text is tested to make sure it is double variable entered
            {
                    if (char.IsLetter(lastNameInput))//the entered character is tested to make sure it is a valid character
                    {
                        if(totalCreditHoursInput < MINIMUM_HOURS)
                        {
                            MessageBox.Show("Error: Invalid Credit Hour Entry"); //Shows an error message if user inputs a negative number
                        }
               //Messagebox appears with the corresponding dates/times for seniors
                        if (totalCreditHoursInput >= SENIOR_HOURS && lastNameInput <= 'D')
                        {
                            MessageBox.Show("November 4th at " + HOUR_A + ":00 PM");//Shows date/time for hours above 90 and last name beginning with a-d
                        }
                        else if (totalCreditHoursInput >= SENIOR_HOURS && lastNameInput <= 'I')
                        {
                            MessageBox.Show("November 4th at " + HOUR_B + ":00 PM");//Shows date/time for hours above 90 and last name beginning with e-i
                    }
                        else if (totalCreditHoursInput >= SENIOR_HOURS && lastNameInput <= 'O')
                        {
                            MessageBox.Show("November 4th at " + HOUR_C + ":30 AM");//Shows date/time for hours above 90 and last name beginning with j-o
                    }
                        else if (totalCreditHoursInput >= SENIOR_HOURS && lastNameInput <= 'S')
                    {
                            MessageBox.Show("November 4th at " + HOUR_D + ":00 AM");//Shows date/time for hours above 90 and last name beginning with p-s
                    }
                        else if (totalCreditHoursInput >= SENIOR_HOURS && lastNameInput <= 'Z')
                        {
                            MessageBox.Show("November 4th at " + HOUR_E + ":30 AM");//Shows date/time for hours above 90 and last name beginning with t-z
                    }
               //Messagebox appears with the corresponding dates/times for Juniors
                        else if (totalCreditHoursInput >= BREAK_BETWEEN_UPPER_LOWER_CLASSMAN && lastNameInput <= 'D')
                        {
                            MessageBox.Show("November 7th at " + HOUR_A + ":00 PM");//Shows date/time for hours above 60 and last name beginning with a-d
                    }
                        else if (totalCreditHoursInput >= BREAK_BETWEEN_UPPER_LOWER_CLASSMAN && lastNameInput <= 'I')
                        {
                            MessageBox.Show("November 7th at " + HOUR_B + ":00 PM");//Shows date/time for hours above 60 and last name beginning with e-i
                    }
                        else if (totalCreditHoursInput >= BREAK_BETWEEN_UPPER_LOWER_CLASSMAN && lastNameInput <= 'O')
                        {
                            MessageBox.Show("November 7th at " + HOUR_C + ":30 AM");//Shows date/time for hours above 60 and last name beginning with j-o
                    }
                        else if (totalCreditHoursInput >= BREAK_BETWEEN_UPPER_LOWER_CLASSMAN && lastNameInput <= 'S')
                        {
                            MessageBox.Show("November 7th at " + HOUR_D + ":00 AM");//Shows date/time for hours above 60 and last name beginning with p-s
                    }
                        else if (totalCreditHoursInput >= BREAK_BETWEEN_UPPER_LOWER_CLASSMAN && lastNameInput <= 'Z')
                        {
                            MessageBox.Show("November 7th at " + HOUR_E + ":30 AM");//Shows date/time for hours above 60 and last name beginning with t-z
                    }
                    //Messagebox appears with the corresponding dates/times for sophomores
                        else if (totalCreditHoursInput >= SOPHOMORE_HOURS && lastNameInput <= 'B')
                        {
                            MessageBox.Show("November 10th at " + HOUR_D + ":00 AM");//Shows date/time for hours above 30 and last name beginning with a-b
                    }
                        else if (totalCreditHoursInput >= SOPHOMORE_HOURS && lastNameInput <= 'D')
                        {
                            MessageBox.Show("November 10th at " + HOUR_E + ":30 AM");//Shows date/time for hours above 30 and last name beginning with c-d
                    }
                        else if (totalCreditHoursInput >= SOPHOMORE_HOURS && lastNameInput <= 'F')
                        {
                            MessageBox.Show("November 10th at " + HOUR_A + ":00 PM");//Shows date/time for hours above 30 and last name beginning with e-f
                    }
                        else if (totalCreditHoursInput >= SOPHOMORE_HOURS && lastNameInput <= 'I')
                        {
                            MessageBox.Show("November 10th at " + HOUR_B + ":00 PM");//Shows date/time for hours above 30 and last name beginning with g-i
                    }
                        else if (totalCreditHoursInput >= SOPHOMORE_HOURS && lastNameInput <= 'L')
                        {
                            MessageBox.Show("November 9th at " + HOUR_C + ":30 AM");//Shows date/time for hours above 30 and last name beginning with j-l
                    }
                        else if (totalCreditHoursInput >= SOPHOMORE_HOURS && lastNameInput <= 'O')
                        {
                            MessageBox.Show("November 9th at " + HOUR_D + ":00 AM");//Shows date/time for hours above 30 and last name beginning with m-o
                    }
                        else if (totalCreditHoursInput >= SOPHOMORE_HOURS && lastNameInput <= 'Q')
                        {
                            MessageBox.Show("November 9th at " + HOUR_E + ":30 AM");//Shows date/time for hours above 30 and last name beginning with p-q
                    }
                        else if (totalCreditHoursInput >= SOPHOMORE_HOURS && lastNameInput <= 'S')
                        {
                            MessageBox.Show("November 9th at " + HOUR_A + ":00 PM");//Shows date/time for hours above 30 and last name beginning with r-s
                    }
                        else if (totalCreditHoursInput >= SOPHOMORE_HOURS && lastNameInput <= 'V')
                        {
                            MessageBox.Show("November 9th at " + HOUR_B + ":00 PM");//Shows date/time for hours above 30 and last name beginning with t-v
                    }
                        else if (totalCreditHoursInput >= SOPHOMORE_HOURS && lastNameInput <= 'Z')
                        {
                            MessageBox.Show("November 10th at " + HOUR_C + ":30 AM");//Shows date/time for hours above 30 and last name beginning with w-z
                    }
                    //Messagebox appears with the corresponding dates/times for freshmen
                        else if (totalCreditHoursInput < SOPHOMORE_HOURS && lastNameInput <= 'B' && totalCreditHoursInput >= MINIMUM_HOURS)
                        {
                            MessageBox.Show("November 14th at " + HOUR_D + ":00 AM");//Shows date/time for hours below 30 and last name beginning with a-b
                    }
                        else if (totalCreditHoursInput < SOPHOMORE_HOURS && lastNameInput <= 'D' && totalCreditHoursInput >= MINIMUM_HOURS)
                        {
                            MessageBox.Show("November 14th at " + HOUR_E + ":30 AM");//Shows date/time for hours below 30 and last name beginning with c-d
                    }
                        else if (totalCreditHoursInput < SOPHOMORE_HOURS && lastNameInput <= 'F' && totalCreditHoursInput >= MINIMUM_HOURS)
                        {
                            MessageBox.Show("November 14th at " + HOUR_A + ":00 PM");//Shows date/time for hours below 30 and last name beginning with e-f
                    }
                        else if (totalCreditHoursInput < SOPHOMORE_HOURS && lastNameInput <= 'I' && totalCreditHoursInput >= MINIMUM_HOURS)
                        {
                            MessageBox.Show("November 14th at " + HOUR_B + ":00 PM");//Shows date/time for hours below 30 and last name beginning with g-i
                    }
                        else if (totalCreditHoursInput < SOPHOMORE_HOURS && lastNameInput <= 'L' && totalCreditHoursInput >= MINIMUM_HOURS)
                        {
                            MessageBox.Show("November 11th at " + HOUR_C + ":30 AM");//Shows date/time for hours below 30 and last name beginning with j-l
                    }
                        else if (totalCreditHoursInput < SOPHOMORE_HOURS && lastNameInput <= 'O' && totalCreditHoursInput >= MINIMUM_HOURS)
                        {
                            MessageBox.Show("November 11th at " + HOUR_D + ":00 AM");//Shows date/time for hours below 30 and last name beginning with m-o
                    }
                        else if (totalCreditHoursInput < SOPHOMORE_HOURS && lastNameInput <= 'Q' && totalCreditHoursInput >= MINIMUM_HOURS)
                        {
                            MessageBox.Show("November 11th at " + HOUR_E + ":30 AM");//Shows date/time for hours below 30 and last name beginning with p-q
                    }
                        else if (totalCreditHoursInput < SOPHOMORE_HOURS && lastNameInput <= 'S' && totalCreditHoursInput >= MINIMUM_HOURS)
                        {
                            MessageBox.Show("November 11th at " + HOUR_A + ":00 PM");//Shows date/time for hours below 30 and last name beginning with r-s
                    }
                        else if (totalCreditHoursInput < SOPHOMORE_HOURS && lastNameInput <= 'V' && totalCreditHoursInput >= MINIMUM_HOURS)
                        {
                            MessageBox.Show("November 11th at " + HOUR_B + ":00 PM");//Shows date/time for hours below 30 and last name beginning with t-v                   
                        }
                        else
                        {
                            MessageBox.Show("November 14th at " + HOUR_C + ":30 AM");//Shows date/time for hours below 30 and last name beginning with w-z
                    }
                    }
                }

            }
        }
    }

