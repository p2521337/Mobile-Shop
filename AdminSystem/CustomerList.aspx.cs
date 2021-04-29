using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    // variable to store the primary key with page level scope
    Int32 CustomerID;
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customer to be processsed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {

                //if this is not a new record
                if(CustomerID != -1)

            { 
                //update the list box 
                DisplayCustomer();

            }
        }

    }

        void DisplayCustomer()
        {
            //create instance of the County Collection
            clsCustomerCollection Customer = new clsCustomerCollection();
            //set the data source to the list of counties in the collection
            lstCustomerList.DataSource = Customer.CustomerList;
            //set the name of the primary key
            lstCustomerList.DataValueField = "CustomerID";
            //set the dat field to display
            lstCustomerList.DataTextField = "FirstName";
            //bind the data to the list
            lstCustomerList.DataBind();
        }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

     }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect t the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedIndex);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else//if no record has been selected 
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else//if no record has been selected 
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void txtApply_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ReportByFirstName(txtFirstName.Text);
        lstCustomerList.DataSource = Customer.CustomerList;
        //set the name of the primarykey
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "Firstname";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void txtClear_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ReportByFirstName("");
        //clear any existing filter to tidy up the interface
        txtFirstName.Text = "";
        lstCustomerList.DataSource = Customer.CustomerList;
        //set the name of the primarykey
        lstCustomerList.DataValueField = "CustomerID";
        //set the name of the field to display
        lstCustomerList.DataTextField = "Firstname";
        //bind the data to the list
        lstCustomerList.DataBind();
    }
}