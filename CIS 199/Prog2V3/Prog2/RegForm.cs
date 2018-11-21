//B6600
// Program 3
// CIS 199-75
// Due: 11/20/2016

// This application uses arrays and rangematching to calculate the earliest registration date
// and time for an undergraduate student given their credit hours
// and last name.
// Decisions based on UofL Fall/Summer 2016 Priority Registration Schedule

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        //Precondition: creditHours >=0, 'A' <= lastNameStr >= 'Z'
        //PostCondition: Display the date and times when the student enters creditHours and Last Name
        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const float SENIOR_HOURS = 90;    // Min hours for Senior
            const float JUNIOR_HOURS = 60;    // Min hours for Junior
            const float SOPHOMORE_HOURS = 30; // Min hours for Soph.

            const string DAY1 = "November 4";  // 1st day of registration
            const string DAY2 = "November 7";  // 2nd day of registration
            const string DAY3 = "November 9";  // 3rd day of registration
            const string DAY4 = "November 10"; // 4th day of registration
            const string DAY5 = "November 11"; // 5th day of registration
            const string DAY6 = "November 14"; // 6th day of registration

            const string TIME1 = "8:30 AM";  // 1st time block
            const string TIME2 = "10:00 AM"; // 2nd time block
            const string TIME3 = "11:30 AM"; // 3rd time block
            const string TIME4 = "2:00 PM";  // 4th time block
            const string TIME5 = "4:00 PM";  // 5th time block

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration
            float creditHours;        // Entered credit hours

            if (float.TryParse(creditHrTxt.Text, out creditHours) && creditHours >= 0) // Valid hours
            {
                lastNameStr = lastNameTxt.Text;
                if (lastNameStr.Length > 0) // Empty string?
                {
                    lastNameLetterCh = lastNameStr[0];   // First char of last name
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        // Juniors and Seniors share same schedule but different days
                        if (creditHours >= JUNIOR_HOURS)
                        {
                            // Juniors and Seniors share same schedule but different days
                            if (creditHours >= JUNIOR_HOURS)
                            {
                                if (creditHours >= SENIOR_HOURS)
                                    dateStr = DAY1;
                                else // Must be juniors
                                    dateStr = DAY2;

                                char[] lastNameLetter = { 'A', 'E', 'J', 'P', 'T' }; // Lower end of letters
                                string[] times = { TIME4, TIME5, TIME1, TIME2, TIME3 }; //Array of times students can register
                                bool found = false;//Used if found

                                int index = lastNameLetter.Length - 1; // Starts at the beginning of the array

                                //Loop to find the character the student enters
                                while (index >= 0 && !found)
                                {
                                    if (lastNameLetterCh >= lastNameLetter[index])
                                    {
                                        found = true;
                                        timeStr = times[index];//Assigns time to the index
                                    }
                                    else
                                        --index;//decrement down the array til a character is found
                                }
                               
                            }
                            // Sophomores and Freshmen 
                            else // Must be soph/fresh
                            {
                                if (creditHours >= SOPHOMORE_HOURS)
                                {
                                    //Letters between J and V
                                    if ((lastNameLetterCh >= 'J') &&
                                        (lastNameLetterCh <= 'V'))  
                                        dateStr = DAY3;//Assigns Day3
                                    else // The rest of the characters are on the next day
                                        dateStr = DAY4;//The next day is Day4
                                }
                                else // must be freshman
                                {
                                    //Letters between J and V
                                    if ((lastNameLetterCh >= 'J') && 
                                        (lastNameLetterCh <= 'V')) 
                                        dateStr = DAY5;
                                    else // The rest of the characters are on the next day
                                        dateStr = DAY6;
                                }

                                char[] lastNameLetters = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W' }; // Lower end of letters 
                                string[] times = { TIME2, TIME3, TIME4, TIME5, TIME1, TIME2, TIME3, TIME4, TIME5 }; //Array of times students can register
                                bool found = false;

                                int index = lastNameLetters.Length - 1; // Start at beginning of array
                                                                       
                                while (index >= 0 && !found)
                                {
                                    if (lastNameLetterCh >= lastNameLetters[index])
                                    {
                                        found = true;
                                        timeStr = times[index];//Assigns time to the index
                                    }
                                    else
                                        --index;//Decrement down the array
                                }
                            }

                            // Output results
                            dateTimeLbl.Text = dateStr + " at " + timeStr;
                        }
                        else // First char not a letter
                            MessageBox.Show("Enter valid last name!");
                    }
                    else // Empty textbox
                        MessageBox.Show("Enter a last name!");
                }
                else // Can't parse credit hours
                    MessageBox.Show("Please enter valid credit hours earned!");
            }

        }
    }
}

