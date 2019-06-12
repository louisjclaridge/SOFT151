using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hire_Car_maintennce
{
    class Cars
    {
        //Local Variables
        int id;
        string makeandModel;
        string registration;
        string fuelType;
        string lastService;
        string comments;
        //Constructor
        public Cars(int carID, string carMakeandModel, string carRegistration, string carFuelType, string carLastService, string carComments)
        {
            id = carID;
            makeandModel = carMakeandModel;
            registration = carRegistration;
            fuelType = carFuelType;
            lastService = carLastService;
            comments = carComments;
        }
        //setters
        public void setCarID(int inputCarID)
        {
            try
            {
                id = inputCarID;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void setCarMakeAndModel(string inputCarMakeAndModel)
        {
            try
            {
                makeandModel = inputCarMakeAndModel;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void setCarModel(string inputCarMakeandModel)
        {
            try
            {
                makeandModel = inputCarMakeandModel;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void setCarRegistration(string inputCarRegistration)
        {
            try
            {
                registration = inputCarRegistration;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void setCarFuelType(string inputCarFuelType)
        {
            try
            {
                fuelType = inputCarFuelType;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void setCarLastService(string inputCarLastService)
        {
            try
            {
                lastService = inputCarLastService;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void setCarComments(string inputCarComments)
        {
            try
            {
                comments = inputCarComments;
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //Getters

        public int getCarID()
        {
            return id;
        }

        public string getCarMakeAndModel()
        {
            return makeandModel;
        }

        public string getCarMakeandModel()
        {
            return makeandModel;
        }

        public string getCarRegistration()
        {
            return registration;
        }

        public string getCarFuelType()
        {
            return fuelType;
        }

        public string getCarLastService()
        {
            return lastService;
        }

        public string getCarComments()
        {
            return comments;
        }

        public string getAllInfo()
        {
            string carInfo = string.Format("{0} {1} {2} {3} {4} {5}", id, makeandModel, registration, fuelType, lastService, comments);
            return carInfo;
        }
    }
}
