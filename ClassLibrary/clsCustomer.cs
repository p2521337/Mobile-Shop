using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //Membership private member variable
        private Boolean mMembership;
        //Membership public property
        public Boolean Membership
        {
            get
            {
                //this line of code sends data out of the property
                return mMembership;
            }
            set
            {
                //this line of code allows data into the property
                mMembership = value;
            }
        }

        //CustomerID private member variable
        private Int32 mCustomerID;
        //CustomerID public property
        public Int32 CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        //FirstName private member variable
        private String mFirstName;
        //FirstName public property
        public String FirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mFirstName = value;
            }
        }

        //LastName private member variable
        private String mLastName;
        //LastName public property
        public String LastName
        {
            get
            {
                //this line of code sends data out of the property
                return mLastName;
            }
            set
            {
                //this line of code allows data into the property
                mLastName = value;
            }
        }

        //Address private member variable
        private String mAddress;
        //Address public property
        public String Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        //MobileNumber private member variable
        private Int64 mMobileNumber;
        //MobileNumber public property
        public Int64 MobileNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mMobileNumber;
            }
            set
            {
                //this line of code allows data into the property
                mMobileNumber = value;
            }
        }

        //Date private member variable
        private DateTime mDate;
        //Date public property
        public DateTime Date
        {
            get
            {
                //this line of code sends data out of the property
                return mDate;
            }
            set
            {
                //this line of code allows data into the property
                mDate = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connetion
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mMobileNumber = Convert.ToInt64(DB.DataTable.Rows[0]["MobileNumber"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mMembership = Convert.ToBoolean(DB.DataTable.Rows[0]["Membership"]);
                //return that everything worked ok 
                return true;
            }
            // if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }


        //function for the public validation method

        /*public string Valid(string firstname, string lastname, string address, string mobilenumber, string date)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date value
            DateTime DateTemp;

            //if the FirstName is blank

            if (firstname.Length == 0)
            {
                //record the error
                Error = Error + "The First Name may not be blank : ";
            }
            //if the first name is greater then 50 characters
            if (firstname.Length > 50)
            {
                //record the error
                Error = Error + "The first name must be less than 51 character :";
            }

            //if the LastName is blank
            if (lastname.Length == 0)
            {
                //record the error
                Error = Error + "The Last Name may not be blank : ";
            }
            //if the last name is greater then 50 characters
            if (lastname.Length > 50)
            {
                //record the error
                Error = Error + "The last name must be less than 51 character :";
            }

            //if the Address is blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }
            //if the Address is greater then 101 characters
            if (address.Length > 100)
            {
                //record the error
                Error = Error + "The Address must be less than 101 character :";
            }

            //if the MobileNumber is blank

            if (mobilenumber.Length == 0)
            {
                //record the error
                Error = Error + "The MobileNumber may not be blank : ";
            };

            //if the mobile number is greater then 11 integer
            if (mobilenumber.Length > 11)
            {
                //record the error
                Error = Error + "The MobileNumber must be 11 characters :";

                
                try
                {
                    DateTemp = Convert.ToDateTime(date);

                    if (DateTemp > Convert.ToDateTime("31/12/2005"))
                    {
                        //record the error
                        Error = Error + "The Date must be 31/12/2005 or more : ";
                    }
                    if (DateTemp <= Convert.ToDateTime("31/12/1700"))
                    {
                        //record the error
                        Error = Error + "The Date must be after 31/12/1700  : ";
                    }
                }
                catch
                {
                    //record the error
                    Error = Error + "The Date was not a valid date  : ";
                }
                // return any error message
                return Error;

           }
        }*/
    }
}

