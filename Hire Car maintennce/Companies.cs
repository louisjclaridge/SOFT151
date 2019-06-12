using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Hire_Car_maintennce
{
    class Companies
    {
        //Local Varribles
        int id;
        string name;
        string address;
        string postcode;
        int numberOfFleetCars;
        ArrayList numberOfCars;

        //Constructor
        public Companies(int companyID, string companyName, string companyAddress, string companyPostcode, int CompanyNumberOfFleetCars, ArrayList CompanyNumberOfCars)
        {

            id = companyID;
            name = companyName;
            address = companyAddress;
            postcode = companyPostcode;
            numberOfFleetCars = CompanyNumberOfFleetCars;
            numberOfCars = CompanyNumberOfCars;
        }
        //setters
        public void setCompanyID(int inputCompanyID)
        {
            try
            {
                id = inputCompanyID;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void setCompanyName(string inputCompanyName)
        {
            try
            {
                name = inputCompanyName;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void setCompanyAddress(string inputCompanyAddress)
        {
            try
            {
                address = inputCompanyAddress;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void setCompanyPostcode(string inputCompanyPostcode)
        {
            try
            {
                postcode = inputCompanyPostcode;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void setNumberOfFleetCars(int inputNumberOfFleetCars)
        {
            try
            {
                numberOfFleetCars = inputNumberOfFleetCars;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void setNumberOfCars(ArrayList inputNumberOfCars)
        {
            try
            {
                numberOfCars = inputNumberOfCars;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
            }
        //getters
        public int getCompanyID()
        {
            return id;
        }

        public string getCompanyName()
        {
            return name;
        }

        public string getCompanyAddress()
        {
            return address;
        }

        public string getCompanyPostcode()
        {
            return postcode;
        }

        public int getCompanyNumberOfFleetCars()
        {
            return numberOfFleetCars;
        }

        public ArrayList getNumberOfCars()
        {
            return numberOfCars;
        }
        public string getAllInfo()
        {
            string compInfo = string.Format("{0} {1} {2} {3} {4}", id, name, address, postcode, numberOfFleetCars);
            return compInfo;
        }
    }
}
