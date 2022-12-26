using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonalAddressBook
{
    public partial class frmPersonalAddressBook : Form
    {
        public frmPersonalAddressBook()
        {
            InitializeComponent();
        }

        // struct to hold information associated with contact
        public struct contactInfo
        {
            public string firstName;
            public string lastName;
            public string cellNum;
            public string emailAddress;
            public string instaHandle;
            public int month;
            public int day;
            public int year;
        }

        // created an array to store contacts
        contactInfo[] Address_Book = new contactInfo[100];
        
        // initialized current index and selected index to 0
        int iCurrentIndex = 0;
        int iSelectedIndex = 0;

        // method to find contact
        public int findContact(string firstName, string lastName)
        {
            // loops through array to find first and last name of contact
            for (int i = 0; i < iCurrentIndex; i = i + 1)
            {
                if (Address_Book[i].firstName.ToLower() == firstName.ToLower() && Address_Book[i].lastName.ToLower() == lastName.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

        // method to clear all fields accross the program
        public void clearAll()
        {
            txtSearchFirstName.Clear();
            txtSearchLastName.Clear();
            lblShowContactCellNum.Text = "";
            lblShowContactEmailAddress.Text = "";
            lblShowContactInstaHandle.Text = "";
            txtSearchBdayFirstName.Text = "";
            txtSearchBdayLastName.Text = "";
            dtpSearchBday.Value = DateTime.Now;
            lbShowBdays.Items.Clear();
            txtEditDelFirstName.Clear();
            txtEditDelLastName.Clear();
            txtEditDelCellNum.Clear();
            txtEditDelEmailAddress.Clear();
            txtEditDelInstaHandle.Clear();
            dtpEditDelBday.ResetText();
        }

        // following code runs when add contact button is clicked
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            try
            {
                // declared variables for contact information
                string firstName, lastName, email, cellNum;
                int index, month, day, year;

                // checks if database is full
                if (iCurrentIndex >= 100)
                {
                    MessageBox.Show("Database is full!");
                    return;
                }
                // if database is not full, store inputs in struct and trim users input
                else
                {
                    firstName = txtAddFirstName.Text.Trim();
                    lastName = txtAddLastName.Text.Trim();
                    email = txtAddEmailAddress.Text.Trim();
                    cellNum = txtAddCellNum.Text.Trim();
                    day = dtpAddBday.Value.Day;
                    month = dtpAddBday.Value.Month;
                    year = dtpAddBday.Value.Year;

                    // checks if user left a required field blank and informs them 
                    if (firstName == "" || lastName == "" || cellNum == "" || email == "")
                    {
                        MessageBox.Show("Please fill out all required fields!");
                        return;

                    }
                    // checks if first and last name only contains letters
                    else if (!firstName.All(Char.IsLetter) || !lastName.All(Char.IsLetter))
                    {
                        MessageBox.Show("Please ensure the name only contains alphabetic characters. (no numbers or symbols)");

                        txtAddFirstName.Clear();
                        txtAddLastName.Clear();

                        return;
                    }
                    // checks if email address is formatted properly with an @ and dot
                    else if (!email.Contains("@") || !email.Contains("."))
                    {
                        //error message that email is improperly formatted
                        MessageBox.Show("Please ensure the email is in the standard format with an @ symbol and dot (.)");

                        //clear email field
                        txtAddEmailAddress.Clear();
                        return;
                    }
                    // checks if user inputted a birthday that is in the future
                    else if (year > DateTime.Today.Year || (year == DateTime.Today.Year && month > DateTime.Today.Month) || (year == DateTime.Today.Year && month == DateTime.Today.Month && day > DateTime.Today.Day))
                    {
                        MessageBox.Show("Please ensure the birthday is not in the future.");

                        dtpAddBday.Value = DateTime.Now;

                        return;
                    }

                    // calling method to find contact
                    index = findContact(firstName, lastName);

                    // adds the contact if the person is not already in the address book
                    if (index == -1)
                    {
                        Address_Book[iCurrentIndex].firstName = txtAddFirstName.Text.Trim();
                        Address_Book[iCurrentIndex].lastName = txtAddLastName.Text.Trim();
                        Address_Book[iCurrentIndex].cellNum = txtAddCellNum.Text.Trim();
                        Address_Book[iCurrentIndex].emailAddress = txtAddEmailAddress.Text.Trim();
                        Address_Book[iCurrentIndex].day = dtpAddBday.Value.Day;
                        Address_Book[iCurrentIndex].month = dtpAddBday.Value.Month;
                        Address_Book[iCurrentIndex].year = dtpAddBday.Value.Year;
                        Address_Book[iCurrentIndex].instaHandle = txtAddInstaHandle.Text.Trim();

                        iCurrentIndex = iCurrentIndex + 1;

                        MessageBox.Show("Contact successfully added!");
                    }
                    // shows error message if person is already in the address book
                    else
                    {
                        MessageBox.Show("This Person is Already in the Address Book!");
                    }
                    clearAll();
                }
            }
            catch
            {
                MessageBox.Show("It appears there was an error. Please try again.");
            }
            }

        private void btnSearchBday_Click(object sender, EventArgs e)
        {
            try
            {
                // creating variables for search birthday page
                string firstName, lastName;
                int index, day, month, year;
                
                //trimming users input for first name and last name
                firstName = txtSearchBdayFirstName.Text.Trim();
                lastName = txtSearchBdayLastName.Text.Trim();
                
                dtpSearchBday.Visible = false;

                // checks if user left a name field blank and informs them 
                if (firstName == "" || lastName == "")
                {
                    dtpSearchBday.Visible = false;
                    MessageBox.Show("Please provide both a First Name and Last Name.");
                    return;
                }

                // calling method to find contact
                index = findContact(firstName, lastName);

                // If the person is not in the address book array, show error message
                if (index == -1)
                {
                    dtpSearchBday.Visible = false;
                    MessageBox.Show("This person does not exist in the Birthday Organizer!");
                }
                // if person exists in address book display their information
                else
                {
                    day = Address_Book[index].day;
                    month = Address_Book[index].month;
                    year = Address_Book[index].year;
                    dtpSearchBday.Visible = true;
                    dtpSearchBday.Value = new DateTime(year, month, day);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid name!");
            }
        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            try
            {
                // declaring variables for contact info
                int index;
                string firstName, lastName, emailAddress, cellNum, instaHandle;

                firstName = txtSearchFirstName.Text.Trim();
                lastName = txtSearchLastName.Text.Trim();

                // checks if the user left a name field blank, and informs them
                if (firstName == "" || lastName == "")
                {
                    MessageBox.Show("Please provide both First Name and Last Name!");
                    return;
                }
                
                // method to find contact 
                index = findContact(firstName, lastName);

                // checks if user is in the address book array and gives an error message if they are not
                if (index == -1)
                {
                    lblShowContactCellNumTitle.Visible = false;
                    lblShowContactEmailAddressTitle.Visible = false;
                    lblShowContactInstaHandleTitle.Visible = false;

                    lblShowContactCellNum.Visible = false;
                    lblShowContactEmailAddress.Visible = false;
                    lblShowContactInstaHandle.Visible = false;

                    MessageBox.Show("This person does not exist in the application.");
                }
                // searches array for contact and displays it in text box
                else
                {
                    cellNum = Address_Book[index].cellNum;
                    emailAddress = Address_Book[index].emailAddress;
                    instaHandle = Address_Book[index].instaHandle;

                    lblShowContactCellNumTitle.Visible = true;
                    lblShowContactEmailAddressTitle.Visible = true;
                    lblShowContactInstaHandleTitle.Visible = true;

                    lblShowContactCellNum.Visible = true;
                    lblShowContactEmailAddress.Visible = true;
                    lblShowContactInstaHandle.Visible = true;

                    lblShowContactCellNum.Text = cellNum;
                    lblShowContactEmailAddress.Text = emailAddress;
                    lblShowContactInstaHandle.Text = instaHandle;
                }
            }
            catch
            {
                MessageBox.Show("Please ensure all textboxes (first and last name) are filled appropriately.");

                lblShowContactCellNum.Visible = false;
                lblShowContactEmailAddress.Visible = false;
            }
        }

        // runs when show birthday button is clicked
        private void showTodaysBdays_Click(object sender, EventArgs e)
        {
            try
            {
                string fullNameAge;

                lbShowBdays.Items.Clear();

                // loops through array and extracts birthday info of contact, and then checks if the birthday is today, and displays their age
                for (int i = 0; i < iCurrentIndex; i = i + 1)
                {
                    if (Address_Book[i].day == DateTime.Now.Day && Address_Book[i].month == DateTime.Now.Month)
                    {
                        fullNameAge = Address_Book[i].firstName + " " + Address_Book[i].lastName + " is turning " + (DateTime.Now.Year - Address_Book[i].year).ToString() + " today! ";
                        lbShowBdays.Items.Add(fullNameAge);
                    }
                }
            }
            catch
            {

            }
        }

        // runs when edit button is clicked
        private void btnEdit_Click(object sender, EventArgs e)
        {

            txtEditDelCellNum.Enabled = true;
            txtEditDelEmailAddress.Enabled = true;
            txtEditDelInstaHandle.Enabled = true;
            dtpEditDelBday.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
            btnFindContactEditDel.Enabled = false;
        }

        // when find contact button is clicked
        private void btnFindContactEditDel_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize variables
                string firstName, lastName;

                //set variables to input
                firstName = txtEditDelFirstName.Text.Trim();
                lastName = txtEditDelLastName.Text.Trim();

                if (firstName == "" || lastName == "")
                {
                    MessageBox.Show("Please ensure that the names entered are not empty.");

                    //exit
                    return;
                }
                else
                {
                    //find index of person
                    iSelectedIndex = findContact(firstName, lastName);
                }

                //check that person exists in database
                if (iSelectedIndex != -1)
                {

                    btnFindContactEditDel.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = true;

                    //output values from array
                    txtEditDelEmailAddress.Text = Address_Book[iSelectedIndex].emailAddress;
                    txtEditDelCellNum.Text = Address_Book[iSelectedIndex].cellNum;
                    dtpEditDelBday.Value = new DateTime(Address_Book[iSelectedIndex].year, Address_Book[iSelectedIndex].month, Address_Book[iSelectedIndex].day);
                    txtEditDelInstaHandle.Text = Address_Book[iSelectedIndex].instaHandle;
                }

                else
                {
                    //error message
                    MessageBox.Show("This person does not exist in the database and can not be edited. Please check spelling.");

                    //exit
                    return;
                }
            }
            catch
            {
                //error message for input
                MessageBox.Show("Please input appropriate first and last names.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize variables
                string emailAddress, cellNum, instaHandle;
                int year, month, day;

                //set variables to input
                emailAddress = txtEditDelEmailAddress.Text;
                cellNum = txtEditDelCellNum.Text;
                year = dtpEditDelBday.Value.Year;
                month = dtpEditDelBday.Value.Month;
                day = dtpEditDelBday.Value.Day;
                instaHandle = txtEditDelInstaHandle.Text;

                //check to ensure strings are not empty
                if (emailAddress == "" || cellNum == "")
                {
                    //error message in case strings are empty
                    MessageBox.Show("Please ensure that the Email Address and cell num field is filled.");

                    //exit
                    return;
                }

                //check that email is properly formatted
                if (!emailAddress.Contains("@") || !emailAddress.Contains("."))
                {
                    //error message that email is improperly formatted
                    MessageBox.Show("Please ensure that the email is properly formatted with an @ symbol and a dot.");

                    //exit
                    return;
                }

                //check that birthday is not in the future
                if (year > DateTime.Today.Year || (year == DateTime.Today.Year && month > DateTime.Today.Month) || (year == DateTime.Today.Year && month == DateTime.Today.Month && day > DateTime.Today.Day))
                {
                    //error message in case birthday is in future
                    MessageBox.Show("Please ensure the birthday is not in the future.");

                    //exit
                    return;
                }

                //send input to array
                Address_Book[iSelectedIndex].emailAddress = txtEditDelEmailAddress.Text;
                Address_Book[iSelectedIndex].cellNum = txtEditDelCellNum.Text;
                Address_Book[iSelectedIndex].instaHandle = txtEditDelInstaHandle.Text;
                Address_Book[iSelectedIndex].day = dtpEditDelBday.Value.Day;
                Address_Book[iSelectedIndex].month = dtpEditDelBday.Value.Month;
                Address_Book[iSelectedIndex].year = dtpEditDelBday.Value.Year;

                btnFindContactEditDel.Enabled = true;

                MessageBox.Show("Successfully saved!");

                //clear saved input

                clearAll();

                btnFindContactEditDel.Enabled = true;
                txtEditDelCellNum.Enabled = false;
                txtEditDelEmailAddress.Enabled = false;
                txtEditDelInstaHandle.Enabled = false;
                dtpEditDelBday.Enabled = false;
                btnEdit.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnDelete.Enabled = false;

            }
            catch
            {
                //error message
                MessageBox.Show("Please check the inputted values. The email must include an @ and a dot. The cell number must be 9 digits long and can only consist of numbers.");
            }
        }

        // runs when cancel button is clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {

            // clearing all fields
            clearAll();

            txtEditDelFirstName.Enabled = true;
            txtEditDelLastName.Enabled = true;
            btnFindContactEditDel.Enabled = true;
            txtEditDelCellNum.Enabled = false;
            txtEditDelEmailAddress.Enabled = false;
            txtEditDelInstaHandle.Enabled = false;
            dtpEditDelBday.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;

        }

        // runs when delete button is clicked
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize variables
                string firstName, lastName;
                int index;

                //set variables to input
                firstName = txtEditDelFirstName.Text.Trim();
                lastName = txtEditDelLastName.Text.Trim();

                // check if user has inputted a blank for first name or last name
                if (firstName == "" || lastName == "")
                {

                    MessageBox.Show("Please ensure that the names entered are not empty.");
                    //exit
                    return;
                }
                else
                {
                    //find index of person
                    index = findContact(firstName, lastName);
                }

                //check that person exists in database
                if (index != -1)
                {
                    //confirm deletion
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + firstName + " " + lastName + "?", "Contact Deletion", MessageBoxButtons.YesNo);

                    //check dialog result
                    if (dialogResult == DialogResult.Yes)
                    {
                        //loop through all elements from deleted item to end of items in array
                        for (int i = index; i < iCurrentIndex; i++)
                        {
                            //change next entry to previous entry for names
                            Address_Book[i].firstName = Address_Book[i + 1].firstName;
                            Address_Book[i].lastName = Address_Book[i + 1].lastName;

                            //change next entry to previous entry for contact info
                            Address_Book[i].emailAddress = Address_Book[i + 1].emailAddress;
                            Address_Book[i].cellNum = Address_Book[i + 1].cellNum;
                            Address_Book[i].instaHandle = Address_Book[i + 1].instaHandle;

                            //change next entry to previous entry for birthday
                            Address_Book[i].year = Address_Book[i + 1].year;
                            Address_Book[i].month = Address_Book[i + 1].month;
                            Address_Book[i].day = Address_Book[i + 1].day;
                        }

                        //decrement current index
                        iCurrentIndex--;

                        clearAll();
                    }
                    else
                    {
                        //message
                        MessageBox.Show(firstName + " " + lastName + " was not deleted from the Address Book.");
                    }
                }
                else
                {
                    //error message
                    MessageBox.Show("This person does not exist in the database and can therefore not be deleted. Please check spelling.");
                }
            }
            catch
            {
                //error message for input
                MessageBox.Show("Please input appropriate first and last names.");
            }
        }

        // runs when save to file is clicked
        private void msSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize save file dialog
                SaveFileDialog sfd = new SaveFileDialog();

                //set filter
                sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|(*.*)";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    TextWriter tw = new StreamWriter(sfd.FileName);

                    for (int i = 0; i < iCurrentIndex; i = i + 1)
                    {
                        //write name to file
                        tw.Write(Address_Book[i].firstName + ",");
                        tw.Write(Address_Book[i].lastName + ",");

                        //write contact info to file
                        tw.Write(Address_Book[i].emailAddress + ",");
                        tw.Write(Address_Book[i].cellNum + ",");
                        tw.Write(Address_Book[i].instaHandle + ",");

                        //write date to file
                        tw.Write(Address_Book[i].day.ToString() + ",");
                        tw.Write(Address_Book[i].month.ToString() + ",");
                        tw.WriteLine(Address_Book[i].year.ToString());
                    }

                    //success message
                    MessageBox.Show("Successfully saved!");

                    //close text writer
                    tw.Close();
                }


            }
            catch
            {
                //error message
                MessageBox.Show("There was an issue when saving the file. Please try again.");
            }
        }

        private void msOpenText_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize open file dialog
                OpenFileDialog ofd = new OpenFileDialog();

                //create input variables
                string strInput;
                string[] splittedInput;

                //change file dialog filter
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|(*.*)";

                //check that file has been opened (no cancel)
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //create text reader
                    TextReader tr = new StreamReader(ofd.FileName);

                    //reset current array position
                    iCurrentIndex = 0;

                    //check that next line exists
                    while ((strInput = tr.ReadLine()) != null)
                    {
                        //split line by commas
                        splittedInput = strInput.Split(',');

                        //send name to array
                        Address_Book[iCurrentIndex].firstName = (splittedInput[0]);
                        Address_Book[iCurrentIndex].lastName = (splittedInput[1]);

                        //send contact info to array
                        Address_Book[iCurrentIndex].emailAddress = (splittedInput[2]);
                        Address_Book[iCurrentIndex].cellNum = (splittedInput[3]);
                        Address_Book[iCurrentIndex].instaHandle = (splittedInput[4]);

                        //set birthday to array
                        Address_Book[iCurrentIndex].day = Convert.ToInt32(splittedInput[5]);
                        Address_Book[iCurrentIndex].month = Convert.ToInt32(splittedInput[6]);
                        Address_Book[iCurrentIndex].year = Convert.ToInt32(splittedInput[7]);

                        //increment current index
                        iCurrentIndex++;

                    }
                    MessageBox.Show("Successfully loaded!");

                    //close text reader
                    tr.Close();
                }

                //success message


            }
            catch
            {
                //error message
                MessageBox.Show("There was an issue when opening the file. Please try again.");
            }
        }

        // when save binary file is clicked
        private void msSaveBinary_Click(object sender, EventArgs e)
        {
            try
            {
                // saving file dialog
                SaveFileDialog saveDialog1 = new SaveFileDialog();
                string FileName;
                saveDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
                if (saveDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveDialog1.FileName;
                    FileStream fs = new FileStream(FileName, FileMode.Create);
                    BinaryWriter binWriter = new BinaryWriter(fs);
                    for (int i = 0; i < iCurrentIndex; i = i + 1)
                    {
                        // writing contact info to binary files
                        binWriter.Write(Address_Book[i].firstName);
                        binWriter.Write(Address_Book[i].lastName);
                        binWriter.Write(Address_Book[i].emailAddress);
                        binWriter.Write(Address_Book[i].cellNum);
                        binWriter.Write(Address_Book[i].instaHandle);
                        binWriter.Write(Address_Book[i].day);
                        binWriter.Write(Address_Book[i].month);
                        binWriter.Write(Address_Book[i].year);
                    }
                    binWriter.Flush();
                    binWriter.Close();
                }
            }
            catch
            {
                MessageBox.Show("There was an error saving the file. Please try again.");
            }
        }

        // runs when open binary file is clicked
        private void msOpenBinary_Click(object sender, EventArgs e)
        {
            // opening file dialog
            OpenFileDialog openDialog1 = new OpenFileDialog();
            string FileName;
            long length;
            openDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openDialog1.FileName;
                FileStream fs = new FileStream(FileName, FileMode.Open);
                BinaryReader binReader = new BinaryReader(fs);
                iCurrentIndex = 0;
                length = binReader.BaseStream.Length;
                while (fs.Position < length)
                {
                    // reading contact info from binary file
                   Address_Book[iCurrentIndex].firstName = binReader.ReadString();
                    Address_Book[iCurrentIndex].lastName = binReader.ReadString();
                    Address_Book[iCurrentIndex].emailAddress = binReader.ReadString();
                    Address_Book[iCurrentIndex].cellNum = binReader.ReadString();
                    Address_Book[iCurrentIndex].instaHandle = binReader.ReadString();
                    Address_Book[iCurrentIndex].day = binReader.ReadInt32();
                   Address_Book[iCurrentIndex].month = binReader.ReadInt32();
                    Address_Book[iCurrentIndex].year = binReader.ReadInt32();
                    iCurrentIndex = iCurrentIndex + 1;
                }
                binReader.Close();
            }
        }

        // allows for user to change their address book color
        private void msPersonalizationColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog.Color;

                tpTbAddContact.BackColor = color;
                tpTbSearch.BackColor = color;
                tpTbSearchBdays.BackColor = color;
                tpTbShowBdays.BackColor = color;
                tpTbEditDel.BackColor = color;
            }
        }
    }
}