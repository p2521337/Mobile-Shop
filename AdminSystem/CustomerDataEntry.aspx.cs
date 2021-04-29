using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the CustomerBook
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtFirstName.Text = CustomerBook.ThisCustomer.FirstName;
        txtLastName.Text = CustomerBook.ThisCustomer.LastName;
        txtAddress.Text = CustomerBook.ThisCustomer.Address;
        txtMobileNumber.Text = CustomerBook.ThisCustomer.MobileNumber.ToString();
        txtDOB.Text = CustomerBook.ThisCustomer.Date.ToString();
    }



    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instace of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the customer id
        string CustomerID = txtCustomerID.Text;
        //capture the first name
        string FirstName = txtFirstName.Text;
        //capture the last name
        string LastName = txtLastName.Text;
        //capture the address
        string Address = txtAddress.Text;
        //capture mobile number
        string MobileNumber = txtMobileNumber.Text;
        //capture the date
        string Date = txtDOB.Text;
        // variable to store any error messages
        string Error = "";

        //validate the data
        //Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
        if (Error == "")
        {
            //capture the Customer ID
            AnCustomer.CustomerID = Convert.ToInt32(CustomerID);
            //capture the first name
            AnCustomer.FirstName = FirstName;
            //capture the last name
            AnCustomer.LastName = LastName;
            //capture the address
            AnCustomer.Address = Address;
            //capture the mobile number
            AnCustomer.MobileNumber = Convert.ToInt32(MobileNumber);
            //capture the date
            AnCustomer.Date = Convert.ToDateTime(Date);
            //capture membershp
            AnCustomer.Membership = chkMembership.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. CustomerID = -1 then add the data
            if (AnCustomer.CustomerID == -1)
            {
                //set the thisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();

            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(AnCustomer.CustomerID);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

        }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new instace of customer class
        clsCustomer AnCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result to find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = AnCustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerID.Text = Convert.ToString(AnCustomer.CustomerID);
            txtFirstName.Text = AnCustomer.FirstName;
            txtLastName.Text = AnCustomer.LastName;
            txtAddress.Text = AnCustomer.Address;
            txtMobileNumber.Text = Convert.ToString(AnCustomer.MobileNumber);
            txtDOB.Text = Convert.ToString(AnCustomer.Date);
        }



    }

    protected void txtAddress_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    
}