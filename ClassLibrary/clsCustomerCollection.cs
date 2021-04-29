using System.Collections.Generic;
using System;
namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later

            }
        }

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }

            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        //constructor for the class
        public clsCustomerCollection()
        {

            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //set the rimary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@MobileNumber", mThisCustomer.MobileNumber);
            DB.AddParameter("@Date", mThisCustomer.Date);
            DB.AddParameter("@Membership", mThisCustomer.Membership);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thiscustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@MobileNumber", mThisCustomer.MobileNumber);
            DB.AddParameter("@Date", mThisCustomer.Date);
            DB.AddParameter("@Membership", mThisCustomer.Membership);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //delete the record printed to by thiscustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByFirstName(string FirstName)
        {
            //filters the records based on a full or partial first name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FirstName parameter to the database
            DB.AddParameter("@FirstName", FirstName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByFirstName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.Membership = Convert.ToBoolean(DB.DataTable.Rows[Index]["Membership"]);
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.MobileNumber = Convert.ToInt64(DB.DataTable.Rows[Index]["MobileNumber"]);
                AnCustomer.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                //add the record to the privare data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }

    }
}