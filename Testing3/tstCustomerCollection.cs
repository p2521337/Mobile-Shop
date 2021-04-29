using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstCustomerCollection
    {

        [TestMethod]
        public void InstanceOk()
        {
            //create an insatnce of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see its exists 
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Membership = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Richa";
            TestItem.LastName = "Damania";
            TestItem.Address = "16 Greenlane Road Leicester LE3 ^HG";
            TestItem.MobileNumber = 1168542625;
            TestItem.Date = Convert.ToDateTime("15/06/1990");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
           clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Membership = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.FirstName = "Richa";
            TestCustomer.LastName = "Damania";
            TestCustomer.Address = "16 Greenlane Road Leicester LE3 ^HG";
            TestCustomer.MobileNumber = 1168542625;
            TestCustomer.Date = Convert.ToDateTime("15/06/1990");
            //assign the data to the property
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties 
            TestItem.Membership = true;
            TestItem.CustomerID = 5;
            TestItem.FirstName = "Shivangi";
            TestItem.LastName = "Baldev";
            TestItem.Address = "13 Bridge Road London LE1 5GW";
            TestItem.MobileNumber = 01165548;
            TestItem.Date = Convert.ToDateTime("17/09/1980");
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 Primarykey = 0;
            //set its properties
            TestItem.Membership = true;
            TestItem.CustomerID = 9;
            TestItem.FirstName = "Maitri";
            TestItem.LastName = "Sanjiu";
            TestItem.Address = "10 Gipsy Lane Leicester LE3 ^HG";
            TestItem.MobileNumber = 91168542625;
            TestItem.Date = Convert.ToDateTime("15/06/1990");
            //set ThisCustomer to the test ata
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            Primarykey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerID = Primarykey;
            //find the record
            AllCustomer.ThisCustomer.Find(Primarykey);
            //test to set that the two vaues are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethosOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 Primarykey = 0;
            //set its properties
            TestItem.Membership = true;
            TestItem.CustomerID = 9;
            TestItem.FirstName = "Maitri";
            TestItem.LastName = "Sanjiu";
            TestItem.Address = "10 Gipsy Lane Leicester LE3 ^HG";
            TestItem.MobileNumber = 91168542625;
            TestItem.Date = Convert.ToDateTime("15/06/1990");
            //set ThisCustomer to the test ata
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            Primarykey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerID = Primarykey;
            //modify the test data
            TestItem.Membership = false;
            TestItem.CustomerID = 7;
            TestItem.FirstName = "Roshni";
            TestItem.LastName = "Tandel";
            TestItem.Address = "34 Belper Street Leicester LE6 7HG";
            TestItem.MobileNumber = 074586456;
            TestItem.Date = Convert.ToDateTime("17/02/1993");
            //set the record based on the new test data
            AllCustomer.ThisCustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.ThisCustomer.Find(Primarykey);
            //test to set that the two vaues are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 Primarykey = 0;
            //set its properties
            TestItem.Membership = true;
            TestItem.CustomerID = 7;
            TestItem.FirstName = "Roshni";
            TestItem.LastName = "Tandel";
            TestItem.Address = "34 Belper Street Leicester LE6 7HG";
            TestItem.MobileNumber = 074586456;
            TestItem.Date = Convert.ToDateTime("17/02/1993");
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            Primarykey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerID = Primarykey;
            //find the record
            AllCustomer.Delete();
            //noe find the record
            Boolean Found = AllCustomer.ThisCustomer.Find(Primarykey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFirstNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCollection = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCollection.ReportByFirstName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, FilteredCollection.Count);

        }

        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply first name that doesn't exist
            FilteredCustomer.ReportByFirstName("N Faquir");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByFirstNameTestDataFound()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply first name that doesn't exist
            FilteredCustomer.ReportByFirstName("Roshni");
            //check that the correct number of records are found
            if (FilteredCustomer.Count == 2)
            {
                //checked the first records is ID 7
                if (FilteredCustomer.CustomerList[0].CustomerID != 7)
                {
                    OK = false;
                }

            //check that the first records is ID 10
            if (FilteredCustomer.CustomerList[1].CustomerID != 10)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
