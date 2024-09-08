using Model;
using Controller;
using Model.Typing;
using ZbW_P_Contact_Manager.UI.AdministrationTools;
using System.Collections.Generic;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmAdministration : Form
    {
        private UserController _userController;

        public frmAdministration()
        {
            InitializeComponent();
            _userController = new UserController(); // Initialize the UserController
            InitializeListView();
            Load += frmAdministration_Load;
        }

        private void frmAdministration_Load(object? sender, EventArgs e)
        {
            LoadUsersIntoListView();  // Load users when the form loads
            //LoadTestEmployee();
        }

        private void InitializeListView()
        {
            listView1.View = System.Windows.Forms.View.Details;

            // Add columns for Person properties
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

            // Add columns for Employee properties
            listView1.Columns.Add("Employee Number", 100);
            listView1.Columns.Add("Department", 100);
            listView1.Columns.Add("Start Date", 100);
            listView1.Columns.Add("End Date", 100);
            listView1.Columns.Add("Employment", 100);
            listView1.Columns.Add("Role", 100);
            listView1.Columns.Add("Cadre Level", 100);

            // Add columns for Trainee properties
            listView1.Columns.Add("Trainee Years", 100);
            listView1.Columns.Add("Actual Trainee Year", 100);

            // Add columns for Customer properties
            listView1.Columns.Add("Company Name", 150);
            listView1.Columns.Add("Company Type", 150);
            listView1.Columns.Add("Company Contact", 150);

            listView1.FullRowSelect = true;
        }

        private void LoadUsersIntoListView()
        {
            MessageBox.Show("Loading users...");
            listView1.Items.Clear();

            // Load all employees, trainees, and customers
            List<Person> employees = _userController.Read(ModelType.Employee);
            List<Person> trainees = _userController.Read(ModelType.Trainee);
            List<Person> customers = _userController.Read(ModelType.Customer);

            // Add employees
            foreach (Employee employee in employees.OfType<Employee>())
            {
                AddUserToListView(employee);
            }

            // Add trainees
            foreach (Trainee trainee in trainees.OfType<Trainee>())
            {
                AddUserToListView(trainee);
            }

            // Add customers
            foreach (Customer customer in customers.OfType<Customer>())
            {
                AddUserToListView(customer);
            }
        }

        // Helper method to add users to the ListView
        private void AddUserToListView(Person person)
        {
            ListViewItem item = new ListViewItem(person.Id.ToString());
            item.SubItems.Add(person.Salutation);
            item.SubItems.Add(person.FirstName);
            item.SubItems.Add(person.LastName);
            item.SubItems.Add(person.DateOfBirth?.ToString("yyyy-MM-dd"));
            item.SubItems.Add(person.Gender);
            item.SubItems.Add(person.Title);
            item.SubItems.Add(person.SocialSecurityNumber);
            item.SubItems.Add(person.PhoneNumberPrivate);
            item.SubItems.Add(person.PhoneNumberMobile);
            item.SubItems.Add(person.PhoneNumberBusiness);
            item.SubItems.Add(person.Email);
            item.SubItems.Add(person.Status?.ToString());
            item.SubItems.Add(person.Nationality);
            item.SubItems.Add(person.Street);
            item.SubItems.Add(person.StreetNumber);
            item.SubItems.Add(person.ZipCode?.ToString());
            item.SubItems.Add(person.Place);

            if (person is Employee employee)
            {
                item.SubItems.Add(employee.EmployeeNumber?.ToString());
                item.SubItems.Add(employee.Departement);
                item.SubItems.Add(employee.StartDate?.ToString("yyyy-MM-dd"));
                item.SubItems.Add(employee.EndDate?.ToString("yyyy-MM-dd"));
                item.SubItems.Add(employee.Employment?.ToString());
                item.SubItems.Add(employee.Role);
                item.SubItems.Add(employee.CadreLevel?.ToString());
            }
            else
            {
                item.SubItems.Add(""); // Placeholder for Employee-specific fields
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("");
            }

            if (person is Trainee trainee)
            {
                item.SubItems.Add(trainee.TraineeYears?.ToString());
                item.SubItems.Add(trainee.ActualTraineeYear?.ToString());
            }
            else
            {
                item.SubItems.Add(""); // Placeholder for Trainee-specific fields
                item.SubItems.Add("");
            }

            if (person is Customer customer)
            {
                item.SubItems.Add(customer.CompanyName);
                item.SubItems.Add(customer.CompanyType);
                item.SubItems.Add(customer.CompanyContact);
            }
            else
            {
                item.SubItems.Add(""); // Placeholder for Customer-specific fields
                item.SubItems.Add("");
                item.SubItems.Add("");
            }

            listView1.Items.Add(item);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmCreateEmployee frmCreateEmployee = new frmCreateEmployee();

            if (frmCreateEmployee.ShowDialog() == DialogResult.OK)
            {
                Employee employee = (Employee)frmCreateEmployee.model!;
                _userController.Create(employee);
                LoadUsersIntoListView();  // Refresh the list
            }
        }

        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            frmCreateCustomer frmCreateCustomer = new frmCreateCustomer();

            if (frmCreateCustomer.ShowDialog() == DialogResult.OK)
            {
                Customer customer = (Customer)frmCreateCustomer.model!;
                _userController.Create(customer);
                LoadUsersIntoListView();  // Refresh the list
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmEditUser frmEditUser = new frmEditUser();
            if (frmEditUser.ShowDialog() == DialogResult.OK)
            {
                // Handle the edit functionality here if required
                LoadUsersIntoListView();  // Refresh the list
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Person selectedUser = (Person)selectedItem.Tag;
                // Do something with the selected user
            }
        }

        private void LoadTestEmployee()
        {
            // Create the test Employee
            Employee testEmployee = new Employee
            {
                Id = Guid.Parse("701f94bf-e771-4d86-ac3c-6543497d2228"),
                Salutation = "Herr",
                FirstName = "Max",
                LastName = "Alt",
                DateOfBirth = new DateTime(1969, 5, 8),
                Gender = "Male",
                Title = "Hr.",
                SocialSecurityNumber = "123-456-789",
                PhoneNumberPrivate = "0041 71 123 45 67",
                PhoneNumberMobile = "0041 79 123 45 67",
                PhoneNumberBusiness = "0041 71 445 45 01",
                Email = "max.alt@employee.ch",
                Status = true,
                Nationality = "Swiss",
                Street = "Musterstrasse",
                StreetNumber = "12",
                ZipCode = 9000,
                Place = "St. Gallen",
                EmployeeNumber = Guid.Parse("6981c825-7caa-456d-b47e-6ac080eddd47"),
                Departement = "Sales",
                StartDate = new DateTime(2010, 1, 1),
                EndDate = null,
                Employment = 100,
                Role = "Sales Manager",
                CadreLevel = 4
            };

            // Add the test Employee to the ListView
            AddUserToListView(testEmployee);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsersIntoListView();
        }
    }
}
