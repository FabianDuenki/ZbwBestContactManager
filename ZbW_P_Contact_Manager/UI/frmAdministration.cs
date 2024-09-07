using Model;
using Controller;
using Model.Typing;
using ZbW_P_Contact_Manager.UI.AdministrationTools;
using System.Collections.Generic;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmAdministration : Form
    {
        // Constructor initializes the form and ListView and subscribes to the load event
        public frmAdministration()
        {
            InitializeComponent();
            InitializeListView(); // Set up the ListView with appropriate columns
            Load += frmAdministration_Load; // Subscribe to form load event
        }

        // Event handler for form load event - Shows a message and loads users into ListView
        private void frmAdministration_Load(object? sender, EventArgs e)
        {
            MessageBox.Show("Loading users...");
            LoadUsersIntoListView(); // Load data into ListView on form load
        }

        // Sets up the ListView with appropriate columns for displaying user information
        private void InitializeListView()
        {
            listView1.View = System.Windows.Forms.View.Details;

            // Adding columns to ListView for user data
            listView1.Columns.Add("Id", 100);
            listView1.Columns.Add("Salutation", 100);
            listView1.Columns.Add("First Name", 100);
            listView1.Columns.Add("Last Name", 100);
            listView1.Columns.Add("Date Of Birth", 100);
            listView1.Columns.Add("Gender", 100);
            listView1.Columns.Add("Title", 100);
            listView1.Columns.Add("Social Security Number", 150);
            listView1.Columns.Add("Phone Number Private", 150);
            listView1.Columns.Add("Phone Number Mobile", 150);
            listView1.Columns.Add("Phone Number Business", 150);
            listView1.Columns.Add("Email", 150);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add("Nationality", 100);
            listView1.Columns.Add("Street", 100);
            listView1.Columns.Add("Street Number", 100);
            listView1.Columns.Add("Zip Code", 100);
            listView1.Columns.Add("Place", 100);

            // Employee specific columns
            listView1.Columns.Add("Employee Number", 100);
            listView1.Columns.Add("Department", 100);
            listView1.Columns.Add("Start Date", 100);
            listView1.Columns.Add("End Date", 100);
            listView1.Columns.Add("Employment", 100);
            listView1.Columns.Add("Role", 100);
            listView1.Columns.Add("Cadre Level", 100);

            // Trainee specific columns
            listView1.Columns.Add("Trainee Years", 100);
            listView1.Columns.Add("Actual Trainee Year", 100);

            // Customer specific columns
            listView1.Columns.Add("Company Name", 150);
            listView1.Columns.Add("Company Type", 150);
            listView1.Columns.Add("Company Contact", 150);

            listView1.FullRowSelect = true; // Allows selecting full rows instead of individual cells
        }

        // Event handler for selecting an item in the ListView
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Retrieve the selected item and cast its Tag to a Person object
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Person selectedUser = (Person)selectedItem.Tag;
                // Further actions with the selected user could be done here
            }
        }

        // Loads the users from the controller into the ListView
        private void LoadUsersIntoListView()
        {
            UserController userController = new UserController(); // Controller for fetching user data
            listView1.Items.Clear(); // Clear the existing items in the ListView

            // Load different types of users
            List<Person> employees = userController.Read(ModelType.Employee);
            List<Person> trainees = userController.Read(ModelType.Trainee);
            List<Person> customers = userController.Read(ModelType.Customer);

            // Add Employee entries
            foreach (var employee in employees.OfType<Employee>())
            {
                ListViewItem item = CreateListViewItemForEmployee(employee);
                listView1.Items.Add(item);
            }

            // Add Trainee entries
            foreach (var trainee in trainees.OfType<Trainee>())
            {
                ListViewItem item = CreateListViewItemForTrainee(trainee);
                listView1.Items.Add(item);
            }

            // Add Customer entries
            foreach (var customer in customers.OfType<Customer>())
            {
                ListViewItem item = CreateListViewItemForCustomer(customer);
                listView1.Items.Add(item);
            }
        }

        // Helper method to create ListViewItem for Employee
        private ListViewItem CreateListViewItemForEmployee(Employee employee)
        {
            ListViewItem item = new ListViewItem(employee.Id.ToString());
            item.SubItems.Add(employee.Salutation);
            item.SubItems.Add(employee.FirstName);
            item.SubItems.Add(employee.LastName);
            item.SubItems.Add(employee.DateOfBirth?.ToString("yyyy-MM-dd"));
            item.SubItems.Add(employee.Gender);
            item.SubItems.Add(employee.Title);
            item.SubItems.Add(employee.SocialSecurityNumber);
            item.SubItems.Add(employee.PhoneNumberPrivate);
            item.SubItems.Add(employee.PhoneNumberMobile);
            item.SubItems.Add(employee.PhoneNumberBusiness);
            item.SubItems.Add(employee.Email);
            item.SubItems.Add(employee.Status?.ToString());
            item.SubItems.Add(employee.Nationality);
            item.SubItems.Add(employee.Street);
            item.SubItems.Add(employee.StreetNumber);
            item.SubItems.Add(employee.ZipCode?.ToString());
            item.SubItems.Add(employee.Place);
            item.SubItems.Add(employee.EmployeeNumber?.ToString());
            item.SubItems.Add(employee.Departement);
            item.SubItems.Add(employee.StartDate?.ToString("yyyy-MM-dd"));
            item.SubItems.Add(employee.EndDate?.ToString("yyyy-MM-dd"));
            item.SubItems.Add(employee.Employment?.ToString());
            item.SubItems.Add(employee.Role);
            item.SubItems.Add(employee.CadreLevel?.ToString());
            return item;
        }

        // Helper method to create ListViewItem for Trainee
        private ListViewItem CreateListViewItemForTrainee(Trainee trainee)
        {
            ListViewItem item = new ListViewItem(trainee.Id.ToString());
            item.SubItems.Add(trainee.Salutation);
            item.SubItems.Add(trainee.FirstName);
            item.SubItems.Add(trainee.LastName);
            item.SubItems.Add(trainee.DateOfBirth?.ToString("yyyy-MM-dd"));
            item.SubItems.Add(trainee.Gender);
            item.SubItems.Add(trainee.Title);
            item.SubItems.Add(trainee.SocialSecurityNumber);
            item.SubItems.Add(trainee.PhoneNumberPrivate);
            item.SubItems.Add(trainee.PhoneNumberMobile);
            item.SubItems.Add(trainee.PhoneNumberBusiness);
            item.SubItems.Add(trainee.Email);
            item.SubItems.Add(trainee.Status?.ToString());
            item.SubItems.Add(trainee.Nationality);
            item.SubItems.Add(trainee.Street);
            item.SubItems.Add(trainee.StreetNumber);
            item.SubItems.Add(trainee.ZipCode?.ToString());
            item.SubItems.Add(trainee.Place);
            item.SubItems.Add(trainee.EmployeeNumber?.ToString());
            item.SubItems.Add(trainee.Departement);
            item.SubItems.Add(trainee.StartDate?.ToString("yyyy-MM-dd"));
            item.SubItems.Add(trainee.EndDate?.ToString("yyyy-MM-dd"));
            item.SubItems.Add(trainee.Employment?.ToString());
            item.SubItems.Add(trainee.Role);
            item.SubItems.Add(trainee.CadreLevel?.ToString());
            item.SubItems.Add(trainee.TraineeYears?.ToString());
            item.SubItems.Add(trainee.ActualTraineeYear?.ToString());
            return item;
        }

        // Helper method to create ListViewItem for Customer
        private ListViewItem CreateListViewItemForCustomer(Customer customer)
        {
            ListViewItem item = new ListViewItem(customer.Id.ToString());
            item.SubItems.Add(customer.Salutation);
            item.SubItems.Add(customer.FirstName);
            item.SubItems.Add(customer.LastName);
            item.SubItems.Add(customer.DateOfBirth?.ToString("yyyy-MM-dd"));
            item.SubItems.Add(customer.Gender);
            item.SubItems.Add(customer.Title);
            item.SubItems.Add(customer.SocialSecurityNumber);
            item.SubItems.Add(customer.PhoneNumberPrivate);
            item.SubItems.Add(customer.PhoneNumberMobile);
            item.SubItems.Add(customer.PhoneNumberBusiness);
            item.SubItems.Add(customer.Email);
            item.SubItems.Add(customer.Status?.ToString());
            item.SubItems.Add(customer.Nationality);
            item.SubItems.Add(customer.Street);
            item.SubItems.Add(customer.StreetNumber);
            item.SubItems.Add(customer.ZipCode?.ToString());
            item.SubItems.Add(customer.Place);
            item.SubItems.Add(""); // Placeholder for Employee specific fields
            item.SubItems.Add(""); // Placeholder for Employee specific fields
            item.SubItems.Add(""); // Placeholder for Employee specific fields
            item.SubItems.Add(""); // Placeholder for Employee specific fields
            item.SubItems.Add(customer.CompanyName);
            item.SubItems.Add(customer.CompanyType);
            item.SubItems.Add(customer.CompanyContact);
            return item;
        }

        // Event handler for adding a new employee
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmCreateEmployee frmCreateEmployee = new frmCreateEmployee();

            if (frmCreateEmployee.ShowDialog() == DialogResult.OK)
            {
                Employee employee = (Employee)frmCreateEmployee.model!;
                // Further logic for adding employee to the database can be added here
            }
        }

        // Event handler for creating a new customer
        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            frmCreateCustomer frmCreateCustomer = new frmCreateCustomer();

            if (frmCreateCustomer.ShowDialog() == DialogResult.OK)
            {
                Customer customer = (Customer)frmCreateCustomer.model!;
                // Further logic for adding customer to the database can be added here
            }
        }

        // Event handler for editing a user
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmEditUser frmEditUser = new frmEditUser();
            if (frmEditUser.ShowDialog() == DialogResult.OK)
            {
                // Logic for editing the user can be implemented here
            }
        }
    }
}
