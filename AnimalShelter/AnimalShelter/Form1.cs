using System.Collections;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public List<Customer> Customers = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;

            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);

            Customers.Add(cus);

            CusNewFirstName.Text = "";
            CusNewLastName.Text = "";
            CusNewBirthday.Text = "";
            CusNewAddress.Text = "";
            CusNewDescription.Text = "";
        }

        public void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();

            CusPetInfo.Text = "";

            foreach (Cat cat in cus.MyCats)
                CusPetInfo.Text += cat.Name + ":" + cat.MakeSound() + Environment.NewLine;
            
            foreach(Dog dog in cus.MyDogs)
                CusPetInfo.Text += dog.Name + ":" + dog.MakeSound() + Environment.NewLine;
        }


        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string firstName = CusList.Rows[e.RowIndex].Cells[0].Value.ToString();

            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }

            CusNewPanel.Hide();
            CusDetailPanel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CusListPanel.Dock = DockStyle.Fill;
            CusDetailPanel.Dock = DockStyle.Right;
            CusNewPanel.Dock = DockStyle.Right;

            Customer cus = new Customer("Ian", "Na", new DateTime(2000, 1, 2));
            Cat cat = new Cat(1, "Lucas", "White", "Male");
            cus.Adopt(cat);

            Cat cat2 = new Cat(3, "Ruby", "Brown", "Female");
            cus.Adopt(cat2);

            Dog dog= new Dog(2, "Happy", "Black", "Male", DogBreed.Jindo);
            cus.Adopt(dog);

            Customers.Add(cus);
            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CusNewPanel.Show();
            CusDetailPanel.Hide();
        }
    }
}