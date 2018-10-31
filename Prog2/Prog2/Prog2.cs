/*
 * Grading ID: A4431
 * Progam 2
 * due date: 10/22/2017
 * section: 01
 * */
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
        public Prog2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regCalculatorButton_Click(object sender, EventArgs e)
        {
            string text = lastNameText.Text.ToUpper();// converts the text written in the text box to uppercase
            string letter;//to be used to extract the first letter
            char firstLetter;//to be used to turn the first letter into a character
            string day;//used to display the day in the message box
            const string SENIOR_DAY = "Nov. 3rd", JUNIOR_DAY = "Nov. 6th", SOPH_DAY1 = "Nov. 7th", SOPH_DAY2 = "Nov. 8th", FRESH_DAY1 = "Nov. 9th", FRESH_DAY2 = "Nov. 10th";// registration days as constants
            string time;//used to diplay the time in the message box
            const string TIME1 = "8:30AM", TIME2 = "10:00AM", TIME3 = "11:30AM", TIME4 = "2:00PM", TIME5 = "4:00PM";//registration times as a constant string

            letter = text.Substring(0, 1);//extracts first letter from the last name text box
            firstLetter = Convert.ToChar(letter);//converts first letter to character data type


            if (seniorButton.Checked == true || juniorButton.Checked == true)//this will test to see if the senior or junior radio button is checked
            {
                {
                    if (seniorButton.Checked == true)
                        day = SENIOR_DAY;
                    else
                        day = JUNIOR_DAY;
                    if (firstLetter <= 'D')
                        time = TIME2;
                    else if (firstLetter <= 'I')
                        time = TIME3;
                    else if (firstLetter <= 'O')
                        time = TIME4;
                    else if (firstLetter <= 'S')
                        time = TIME5;
                    else
                        time = TIME1;
                }
                MessageBox.Show($"You can register on {day} at {time}");//displays date and time the student can register based on radio button checked and first letter of the last name
            }
            else if (sophomoreButton.Checked == true || freshmanButton.Checked == true)//this will test the sophomore and freshman radio button to determine which is checked
            {
                if (sophomoreButton.Checked == true)
                    /*sophomores and freshman have two days to register depending on the first letter of their last name 
                     if they have a last name that begins with a letter G-S they will register on Soph_Day2/Fresh_Day2 otherwise it will be Soph_Day1/Fresh_Day1*/
                {
                    if (firstLetter >= 'G' && firstLetter <= 'S')
                        day = SOPH_DAY2;
                    else
                        day = SOPH_DAY1;
                }
                else
                {
                    if (firstLetter >= 'G' && firstLetter <= 'S')
                        day = FRESH_DAY2;
                    else
                        day = FRESH_DAY1;
                }
                if (day == SOPH_DAY1 || day == FRESH_DAY1)
                {
                    if (firstLetter == 'B' || firstLetter == 'A')
                        time = TIME3;
                    else if (firstLetter == 'C' || firstLetter == 'D')
                        time = TIME4;
                    else if (firstLetter == 'E' || firstLetter == 'F')
                        time = TIME5;
                    else if (firstLetter <= 'V' && firstLetter >= 'T')
                        time = TIME1;
                    else
                        time = TIME2;
                }
                else
                {
                    if (firstLetter >= 'R')
                        time = TIME5;
                    else if (firstLetter >= 'P')
                        time = TIME4;
                    else if (firstLetter >= 'M')
                        time = TIME3;
                    else if (firstLetter >= 'J')
                        time = TIME2;
                    else
                        time = TIME1;
                }

                MessageBox.Show($"You can register on {day} at {time}");//Displays the registration date and time based on radio button checked and the first letter of the last name
            }
        }
    }
}
