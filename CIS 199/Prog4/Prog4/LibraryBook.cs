//B6600
//Prog4
//CIS 199-75
//Due Date: December 6, 2016
//This class is the outline for the book details added to the book list box

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class LibraryBook
    {
        private bool isCheckedOut;//Variable display whether the book has been checked out
        private string _title;//backing field for Title Property 
        private string _author;//backing field for Author Property
        private string _publisher;//backing field for Publisher Property
        private int _copyrightyear;//backing field for CopyrightYear Property
        private string _callnumber;//backing field for CallNumber Property

        public LibraryBook(string t, string a, string p, int c, string n)
        {
            Title = t;//set the Title property
            Author = a;//set the Author property
            Publisher = p;//set the Publisher property
            CopyrightYear = c;//set the CopyrightYear property
            CallNumber = n;//set the CallNumber property
        }


        public string Title
        {
            //Precondition: none
            //Postcondition: The title has been returned
            get { return _title; }
            //Precondition: none
            //Postcondition: The title has been set to the specified value
            set { _title = value; }

        }

        public string Author
        {
            //Precondition: none
            //Postcondition: The author has been returned
            get { return _author; }
            //Precondition: none
            //Postcondition: The author has been set to the specified value
            set { _author = value; }

        }

        public string Publisher
        {
            //Precondition: none
            //Postcondition: The publisher has been returned
            get { return _publisher; }
            //Precondition: none
            //Postcondition: The publisher has been set to the specified value
            set { _publisher = value; }

        }

        public int CopyrightYear
        {
            //Precondition: none
            //Postcondition: The copyright year has been returned
            get { return _copyrightyear; }
            //Precondition: entered value >= 0
            //Postcondition: The author has been set to the specified value or default 2016
            set
            {
                if ((value >= 0))
                    _copyrightyear = value;//specified value
                else _copyrightyear = 2016;//default value
            }

        }

        public string CallNumber
        {
            //Precondition: none
            //Postcondition: The call number has been returned
            get { return _callnumber; }
            //Precondition: none
            //Postcondition: The call number has been set to the specified value
            set { _callnumber = value; }

        }

        //Precondition: none
        //Postcondition: change IsCheckedOut() to true
        public void CheckOut()
        {
            isCheckedOut = true;//book is checked out
           
           
        }

        //Precondition: none
        //Postcondition: change IsCheckedOut() to false
        public void ReturnToShelf()
        {
            isCheckedOut = false;//book has been returned
        }

        //Precondition: none
        //Postcondition: return true or false
        public bool IsCheckedOut()
        {
            return isCheckedOut;//true or false?
            
        }

        //Precondition: none
        //Postcondition:return concatenated string of book details
        public override string ToString()
        {

            string result = "";//result is defaulted to an empty string

            if (isCheckedOut)
                result = "Yes";//displayed if book is checked out
            else
                result = "No";//displayed is book is returned
            //returns concatenated string of book details 
            return "Title: " + Title + Environment.NewLine + "Author: " +
                Author + Environment.NewLine + "Publisher: " +
                Publisher + Environment.NewLine + "Copyright Year: " +
                CopyrightYear.ToString("d4") + Environment.NewLine + "Call Number: " +
                CallNumber + Environment.NewLine + "Checked Out Status: "+ result;
              
        }
    }
}
