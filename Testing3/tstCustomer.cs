using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string FirstName = "Customer Name";
        string LastName = "Surname";
        string Address = "House Number, Street name, City, Post-Code";
        string MobileNumber = "0116253595";
        string Date = "15/06/1990";

        [TestMethod]
        public void InstantOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }


        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Membership = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.Membership, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Customer Name";
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Surname";
            //assign the data to the property
            AnCustomer.LastName = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "House Number, Street name, City, Post-Code";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void MobileNumberPropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int64 TestData = 0116253595;
            //assign the data to the property
            AnCustomer.MobileNumber = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.MobileNumber, TestData);
        }

        [TestMethod]
        public void DatePropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = Convert.ToDateTime("15/06/1990");
            //assign the data to the property
            AnCustomer.Date = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.Date, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class I want to create
             clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
             Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
       }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the Customer ID
           if (AnCustomer.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the First Name
            if (AnCustomer.FirstName != "Richa")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the Last Name
            if (AnCustomer.LastName != "Damania")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the Address
            if (AnCustomer.Address != "16 Greenlane Road Leicester LE3 ^HG")                                                                                                                 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMobileNumberFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the MobileNUmber
            if (AnCustomer.MobileNumber != 1168542625)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            Int32 CustomerID = 1; 
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the Date
            if (AnCustomer.Date != Convert.ToDateTime("15/06/1990"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMembershipFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the Membership
            if (AnCustomer.Membership != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /* [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string FirstName = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "R"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Ri"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'R'); //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'R');//this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'R');//this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'R'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(100, 'R'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string LastName = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "D"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "Da"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(49, 'D'); //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(50, 'D');//this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(25, 'D');//this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(51, 'D'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(100, 'D'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string Address = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "L"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "Le"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(99, 'P'); //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(100, 'P');//this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(50, 'P');//this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(101, 'P'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(200, 'P'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void MobileNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create variable to store the test data mobile number
            string MobileNumber;
            // set mobilenumber as interger
            MobileNumber = "999999999";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MobileNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test data mobile number
            string MobileNumber;
            // set mobilenumber as interger
            MobileNumber = "10000000000";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MobileNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test data mobile number
            string MobileNumber;
            //set mobilenumber as integer
            MobileNumber = "10000000001";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MobileNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test data mobile number
            string MobileNumber;
            //set Mobilenumber as integer
            MobileNumber = "99999999998"; 
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MobileNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test data mobile number
            string MobileNumber;
            // set Mobilenumber as integer
            MobileNumber = "99999999999";          
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MobileNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test data mobile number
            string MobileNumber;
            // set Mobilenumber as integer
            MobileNumber = "50000000000";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MobileNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test data mobile number
            string MobileNumber;
            //set mobileNumber as integer
            MobileNumber = "100000000000";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MobileNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test data mobile number
            string MobileNumber;
            //set mobileNumber as integer
            MobileNumber = "1000000000000000";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create variable to store the test data date
            DateTime testDate;
            // set as Date
            testDate = Convert.ToDateTime("01/01/2006");

            string Date = testDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test data date
            DateTime testDate;
            // set as Date
            testDate = Convert.ToDateTime("31/12/2005");
            string Date = testDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test data date
            DateTime testDate;
            //set as date
            testDate = Convert.ToDateTime("30/12/2005");
            string Date = testDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test data date
            DateTime testDate;
            //set as date
            testDate = Convert.ToDateTime("31/12/1700");
            string Date = testDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test data date
            DateTime testDate;
            //set as date
            testDate = Convert.ToDateTime("31/12/1000");
            string Date = testDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Date to a non date value
            string Date = "this is not a date!";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }*/

       

    }
}
