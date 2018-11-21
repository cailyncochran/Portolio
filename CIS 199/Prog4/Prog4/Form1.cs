//B6600
//Prog4
//CIS 199-75
//Due Date: December 6, 2016 
//This program explores the creation of a reusable class and separate GUI application that creates a list objects
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4
{
    public partial class Form1 : Form
    {
        //List to hold LibraryBook objects
        List<LibraryBook> bookList = new List<LibraryBook>();

        public Form1()
        {
            InitializeComponent();
        }


        //Precondition: Textbox cannot be empty
        //Postcondition: Display error if message box is left empty
        private void addBookButton_Click(object sender, EventArgs e)
        {
            int copyrightYear;//declares copyrightYear as an int variable

            //Check to see if textboxes have been left empty, and display error message
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))

                MessageBox.Show("Enter a Title");//error message if empty textbox

            else if (string.IsNullOrWhiteSpace(authorTextBox.Text))

                MessageBox.Show("Enter an Author");//error message if empty textbox

            else if (string.IsNullOrWhiteSpace(publisherTextBox.Text))

                MessageBox.Show("Enter a Publisher");//error message if empty textbox

            else if (string.IsNullOrWhiteSpace(callNumberTextBox.Text))

                MessageBox.Show("Enter a Call Number");//error message if empty textbox

            //Checks to see if user inputs a valid integer for the year
            else if (int.TryParse(copyrightYearTextBox.Text, out copyrightYear))
            {
                //create an instance of the LibraryBook class
                LibraryBook myBook = new LibraryBook(titleTextBox.Text, authorTextBox.Text, publisherTextBox.Text, copyrightYear, callNumberTextBox.Text);

                bookList.Add(myBook);//add object to the list
                bookListBox.Items.Add(myBook.Title);//add book title to the list

                //clearfields
                titleTextBox.Text = "";
                authorTextBox.Text = "";
                publisherTextBox.Text = "";
                copyrightYearTextBox.Text = "";
                callNumberTextBox.Text = "";
            }
            else
                MessageBox.Show("Enter a Copyright Year");//error message if empty textbox

        }

        //Precondition: selected index > -1 
        //Postcondition: Display the details of the selected item or display error message if item is not selected
        private void detailsButton_Click(object sender, EventArgs e)
        {

            if (bookListBox.SelectedIndex == -1)
                MessageBox.Show("Please select an Item first!");//If index is not selected

            else
           {
                int index = bookListBox.SelectedIndex;//index matches selected index in the list box

                MessageBox.Show(bookList[index].ToString());//Display details of the selected book
            }

        }

        //Precondition: selected index > -1
        //Postcondition: Call CheckOut() method
        private void checkOutButton_Click(object sender, EventArgs e)
        {
            int index = bookListBox.SelectedIndex;//index matches selected index in the list box

            if (bookListBox.SelectedIndex == -1)
                MessageBox.Show("Please select an Item first!");//error message if item has not been selected

            else

            {
                bookList[index].CheckOut();//call CheckOut() method
                MessageBox.Show("Book has been checked out");//change book status to CheckOut() Method
            }


        }

        //Precondition: selected index > -1
        //Postcondition: Call Return() method
        private void returnButton_Click(object sender, EventArgs e)
        {
            int index = bookListBox.SelectedIndex;//index matches selected index in the list box

            if (bookListBox.SelectedIndex == -1)
                MessageBox.Show("Please select an Item first!");//error message if item has not been selected

            else
            {
                bookList[index].ReturnToShelf();//call Return() method
                MessageBox.Show("Book has been returned");//change book status to Return() Method
            }
                

        }
    }
}
