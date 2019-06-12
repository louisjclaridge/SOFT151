using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Hire_Car_maintennce
{
    public partial class Form1 : Form
    {
        public static ArrayList compArray; //Creates arrays to store the car and company information
        public static ArrayList NumberOfCars; 

        public static int selectedComp; //Creates ints to store the selectedIndex of the company and car 
        public static int selectedCar;

        ArrayList storeArrayCars;
        ArrayList storeArrayCompany;
        public Form1()
        {
            InitializeComponent();
            compArray = new ArrayList(); //Intialises the company and car arrays
            NumberOfCars = new ArrayList();

            storeArrayCompany = new ArrayList(); //Initalises the company and car store arrays
            storeArrayCars = new ArrayList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readfile(); //Read info in from a textfile and shows the information
            showCompanies(); 
            showCars();
            searchCompanies();
            lstCompanies.SelectedIndex = 0; //sets the selected company to 0
        }

        public void readfile()
        {
            string compName, compAddress, compPostcode;     //Creating strings that will be used to store info from the textfile
            int compID, compNumberOfFleetCars;   //Creating ints that will be used to store info from the textfile

            StreamReader readFile = null;
            try
            {
              readFile = new StreamReader("carsAndCompanies.txt");
            }
            catch(Exception e)                                                  //try catch to see if the file exists
            {
                MessageBox.Show("There was an error" + "\n" + e.Message);
            }
            while(! readFile.EndOfStream)
            {

                //Get company info
                    compID = Convert.ToInt32(readFile.ReadLine());                
                    compName = readFile.ReadLine();                                               
                    compAddress = readFile.ReadLine();                                              //reading values from textfile
                    compPostcode = readFile.ReadLine();
                    compNumberOfFleetCars = Convert.ToInt32(readFile.ReadLine());

                    NumberOfCars = getCars(compNumberOfFleetCars, readFile); //Gets car info from getCars method, replacing default values

                    Companies newComp = new Companies(compID, compName, compAddress, compPostcode, compNumberOfFleetCars, NumberOfCars); 
                    compArray.Add(newComp); //Adding contructed class to the Array
            }
            readFile.Close();
        }

        public ArrayList getCars(int numCars, StreamReader input)
        {
            ArrayList carTempArray;
            string carMakeandModel, carRegistration, carFuelType, carLastService, carComments; //Defining strings and ints to be used to store the info read in from the textfile
            int carID;

            carTempArray = new ArrayList();
            //Get car data
            for (int i = 0; i < numCars; i++)   //loops for how many cars in the current company
            {
                carID = Convert.ToInt32(input.ReadLine());
                carMakeandModel = input.ReadLine();
                carRegistration = input.ReadLine();
                carFuelType = input.ReadLine();                         //reading values from textfile
                carLastService = input.ReadLine();
                carComments = input.ReadLine();
               
                Cars newCar = new Cars(carID, carMakeandModel, carRegistration, carFuelType, carLastService, carComments); //Creating a car object based on infomation read in
                carTempArray.Add(newCar); 
            }
            return carTempArray; //returning the array
        }

        public void showCars()
        {
            Companies tempComp = (Companies)compArray[selectedComp]; //creating a temporary company object

            lstCars.Items.Clear(); //clears the listbox and populates the listbox with car data
            foreach (Cars a in tempComp.getNumberOfCars())
            {
                string output = a.getAllInfo();
                lstCars.Items.Add(output);
            }
        }

        public void showCompanies()
        {
            string output; //Creates a string to store the output
            lstCompanies.Items.Clear();
            if (txtSearchComp.TextLength == 0) //checks to see if the textbox is empty
            {
                foreach (Companies currentComp in compArray)
                {
                    output = currentComp.getAllInfo(); //Sets output to equal the ouput of the current company
                    lstCompanies.Items.Add(output); //adds output to the listbox
                }
            }
        }

        private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedComp = lstCompanies.SelectedIndex; //sets selectedComp to equal the currently selected company

            if (txtSearchComp != null) //tests to see if anything is being searched
            {
                selectedComp = Convert.ToInt32(storeArrayCompany[selectedComp]); //sets selectedComp to be the stored index in the store array
            }
            showCars(); //shows the cars and searches the car
            searchCars(selectedComp); 
            if (lstCars.Items.Count > 0)    //checks to see if the listbox is empty, if not empty, sets the selected index of the cars to be 0
            {
                lstCars.SelectedIndex = 0;
            }
            loadComp(); //loads car into
        }


        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedCar = lstCars.SelectedIndex; //sets the selected car to be the currently selected car
                if (txtSearchCar != null) //tests to see if anything is being searched
                {
                    selectedCar = Convert.ToInt32(storeArrayCars[selectedCar]); //sets selectedCar to be the stored index in the store array
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
                txtSearchCar.Text = "";
            }
            loadCar(); 
        }


        public void searchCars(int index)
        {
            Companies tempComp = (Companies)compArray[index]; //Creates a temporary company object

            lstCars.Items.Clear();
            storeArrayCars = new ArrayList(); //Resets the store array ready to be filled
            string query = txtSearchCar.Text.ToUpper(); //Sets the query text
            int counter = -1; 
            foreach (Cars a in tempComp.getNumberOfCars())
            {
                string currentCar = a.getAllInfo().ToUpper(); //gets the current car info
                counter++;
                if (currentCar.Contains(query)) //checks to see if the current car contains the query
                {
                    currentCar = a.getAllInfo(); //resets the text back to default (as it was moved to uppercase)
                    lstCars.Items.Add(currentCar); //adds the item to the listbox
                    storeArrayCars.Add(counter); //stores the items index in the store array
                }
            }
            if (lstCars.Items.Count > 0) //checks to see if lstCars is empty and if not empty it sets the index to be 0
            {
                lstCars.SelectedIndex = 0;
            }
        }

        public void searchCompanies()
        {
            lstCompanies.Items.Clear();
            string query = txtSearchComp.Text.ToUpper(); //sets the query text

            storeArrayCompany = new ArrayList();
            int counter = -1;
            foreach (Companies currentComp in compArray)    
            {
                string setComp = currentComp.getAllInfo().ToUpper(); //gets the current company info
                counter++;
                if (setComp.Contains(query))    //checks to see if the current company contains the query
                {
                    setComp = currentComp.getAllInfo(); //resets the text back to default (as it was moved to uppercase)
                    lstCompanies.Items.Add(setComp);    //adds the item to the listbox
                    storeArrayCompany.Add(counter);     //stores the items index in the store array
                }
            }
            if (lstCompanies.Items.Count > 0)   //checks to see if lstCompanies is empty and if not empty it sets the index to be 0
            {
                lstCompanies.SelectedIndex = 0;
            }
        }
        public void loadCar()
        {
            Companies tempComp = (Companies)compArray[selectedComp]; //creates and temporary company object and creates an array for the cars
            ArrayList tempArray = tempComp.getNumberOfCars();

            Cars temp = (Cars)tempArray[selectedCar];   //creates a car object based on the array

            txtCarID.Text = temp.getCarID().ToString();
            txtMakeAndModel.Text = temp.getCarMakeAndModel();
            txtRegistration.Text = temp.getCarRegistration();       //Populates the edit textboxes ready to be edited
            txtFuelType.Text = temp.getCarFuelType();
            txtLastService.Text = temp.getCarLastService();
            txtComments.Text = temp.getCarComments();
        }
        private void addCar()
        {
            try //try catch to stop wrong inputs
            {
                Companies tempcomp = (Companies)compArray[selectedComp];    //creates and temporary company object and creates an array for the cars
                ArrayList tempArray = tempcomp.getNumberOfCars();

                int carID = Convert.ToInt32(txtCarID.Text);
                string makeAndModel = txtMakeAndModel.Text;
                string registration = txtRegistration.Text;             //Gets information from textboxes
                string fuelType = txtFuelType.Text;
                string lastService = txtLastService.Text;
                string comment = txtComments.Text;

                Cars temp = (Cars)new Cars(carID, makeAndModel, registration, fuelType, lastService, comment); //creates car object based on varribles

                tempArray.Add(temp); //adds to a temporary array

                tempcomp.setNumberOfCars(tempArray); //sets the car array to equal the temp array
            
            int currentValue = tempcomp.getCompanyNumberOfFleetCars(); //gets the current number of fleet cars and adds 1 to it
            int newvalue = currentValue + 1;
            tempcomp.setNumberOfFleetCars(newvalue); ///sets the number of fleet cars to equal the new value
            }   
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "\n \n" + "Please make sure all infomation is correct"); //outputs a warning that items may be incorrect
            }
            showCars(); 
            searchCars(selectedComp);
        }

        private void deleteCar()
        {
            Companies tempcomp = (Companies)compArray[selectedComp];
            ArrayList tempArray = tempcomp.getNumberOfCars();
            if (lstCars.Items.Count > 0) //checks to see if items are in the listbox
            {
                tempArray.RemoveAt(selectedCar);    //if not empty, delete the selected item
            }
            else
            {
                MessageBox.Show("no more cars to delete"); //if empty, show an error message
            }

            tempcomp.setNumberOfCars(tempArray); //sets array to equal main array

            int currentValue = tempcomp.getCompanyNumberOfFleetCars(); //gets current number of fleet cars and minuses 1 from it
            int newvalue = currentValue - 1;
            tempcomp.setNumberOfFleetCars(newvalue); //sets numberoffleetcars to equal new value
        }

        private void saveCar()
        {
            try //try catch to stop wrong inputs
            {
                Companies tempcomp = (Companies)compArray[selectedComp];    //creates and temporary company object and creates an array for the cars
                ArrayList tempArray = tempcomp.getNumberOfCars();

                int carID = Convert.ToInt32(txtCarID.Text);
                string makeAndModel = txtMakeAndModel.Text;
                string registration = txtRegistration.Text;
                string fuelType = txtFuelType.Text;             //Gets information from textboxes
                string lastService = txtLastService.Text;
                string comment = txtComments.Text;
                Cars temp = new Cars(carID, makeAndModel, registration, fuelType, lastService, comment);    //creates car object based on varribles

                tempArray.RemoveAt(selectedCar); //removes the item from the array
                tempArray.Insert(selectedCar, temp); //adds the new item at the previous index

                tempcomp.setNumberOfCars(tempArray); //sets the main array to equal the temp array
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "\n \n" + "Please make sure all infomation is correct");    //outputs a warning that items may be incorrect
            }
        }

        private void loadComp() 
        {
            Companies temp = (Companies)compArray[selectedComp]; //creates temporary company object

            txtCompID.Text = temp.getCompanyID().ToString();
            txtName.Text = temp.getCompanyName();           //populates edit textboxes ready to edit
            txtAddress.Text = temp.getCompanyAddress();
            txtPostcode.Text = temp.getCompanyPostcode();
        }

        private void addComp()
        {
            try //try catch to stop wrong inputs
            {
                int compID = Convert.ToInt32(txtCompID.Text);
                string compName = txtName.Text;
                string compAddress = txtAddress.Text;       //Gets information from textboxes
                string compPostcode = txtPostcode.Text;
                int compNumberOfFleetCars = 0;
                ArrayList numberOfCars = new ArrayList();

                Companies temp = (Companies)new Companies(compID, compName, compAddress, compPostcode, compNumberOfFleetCars, numberOfCars); //creates a company object based on varribles

                compArray.Add(temp); //adds temp object to the company array
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "\n \n" + "Please make sure all infomation is correct");    // outputs a warning that items may be incorrect
            }
            searchCompanies(); //searches the company
        }

        private void saveComp()
        {
            Companies tempComp = (Companies)compArray[selectedComp];
            try //try catch to stop wrong inputs
            {
                int compID = Convert.ToInt32(txtCompID.Text);
                string name = txtName.Text;
                string address = txtAddress.Text;   //Gets information from textboxes
                string postcode = txtPostcode.Text;
                int numberOfFleetCars = tempComp.getCompanyNumberOfFleetCars();
                ArrayList numberOfCars = tempComp.getNumberOfCars();

                Companies temp = new Companies(compID, name, address, postcode, numberOfFleetCars, numberOfCars);    //creates car object based on varribles

                compArray.RemoveAt(selectedComp);   //removes item from the array
                compArray.Insert(selectedComp, temp); //adds the item at the previous index
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "\n \n" + "Please make sure that all infomation is correct");   // outputs a warning that items may be incorrect
            }
        }
        private void txtSearchCar_TextChanged(object sender, EventArgs e)
        {
            searchCars(selectedComp); //searches cars
        }

        private void txtSearchComp_TextChanged(object sender, EventArgs e)
        {
            searchCompanies(); //searches company
        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            saveCar(); //saves the car
            searchCars(selectedComp); //searches the cars
            showCars(); //shows the cars
            lstCars.SelectedIndex = 0; //sets selectedIndex to 0
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            deleteCar(); //deletes the cars
            showCars(); //shows the car
        }

        private void btnSaveComp_Click(object sender, EventArgs e)
        {
            saveComp(); //saves the company
            showCompanies(); //shows the company
            searchCompanies(); //searches the company
            try
            {
                lstCompanies.SelectedIndex = 0; //sets the selectedIndex to 0
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
                txtSearchComp.Text = "";
            }
        }

        private void btnAddComp_Click_1(object sender, EventArgs e)
        {
            addComp(); //adds the company
            showCompanies(); //shows the company
        }

        private void btnClearCar_Click(object sender, EventArgs e) 
        {
            txtCarID.Text = "";
            txtMakeAndModel.Text = "";
            txtRegistration.Text = "";      //clears edit textboxes ready to add new items
            txtFuelType.Text = "";
            txtLastService.Text = "";
            txtComments.Text = "";
        }

        private void btnClearComp_Click(object sender, EventArgs e)
        {
            txtCompID.Text = "";
            txtName.Text = "";      //clears edit textboxes ready to add new items
            txtAddress.Text = "";
            txtPostcode.Text = "";
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            addCar(); //adds the car
            showCompanies(); //shows the company
        }
    }
}
