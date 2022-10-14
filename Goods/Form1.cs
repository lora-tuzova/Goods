using System.Windows.Forms;

namespace Goods
{
    public partial class Form1 : Form
    {
        public static List<Products> productsList = new List<Products>();
        public static  List<Books> booksList = new List<Books>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            productsList.Add(new Products(100.00, "Ukraine", "Apple", new DateTime(2022, 8, 11), " ", new DateTime(2023, 8, 11), 20, "kg"));
            productsList.Add(new Products(200.00, "Ukraine", "Milk", new DateTime(2022, 10, 4), " ", new DateTime(2022, 10, 8), 10, "l"));
            productsList.Add(new Products(300.00, "Belgia", "Chocolate", new DateTime(2022, 10, 1), " ", new DateTime(2023, 1, 1), 5, "kg"));
            dataGridView1.Rows.Add(productsList[0].name, "Product");
            dataGridView1.Rows.Add(productsList[1].name, "Product");
            dataGridView1.Rows.Add(productsList[2].name, "Product");

            booksList.Add(new Books(100.00, "UK", "The Lost World", new DateTime(2022, 5, 16), " ", 500, "1402", "Arthur Conan Doyle"));
            booksList.Add(new Books(200.00, "Ukraine", "Kobsar", new DateTime(2019, 2, 5), " ", 480, "5639", "Taras Shevchenko"));
            booksList.Add(new Books(300.00, "France", "Three Musketeers", new DateTime(2015, 12, 30), " ", 300, "1384", "Alexander Dyuma"));
            dataGridView1.Rows.Add(booksList[0].name, "Book");
            dataGridView1.Rows.Add(booksList[1].name, "Book");
            dataGridView1.Rows.Add(booksList[2].name, "Book");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            var formAddProduct = new FormAddAProduct();
            if (formAddProduct.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(productsList[productsList.Count-1].name, "Product");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            var formAddBook = new FormAddABook();
            if (formAddBook.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(booksList[booksList.Count-1].name, "Book");
            }
        }

        private void label2_Click (object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox3.Text);
                dataGridView1.Rows.RemoveAt(n-1);
            }
            catch
            {
                MessageBox.Show("Incorrect input");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }

    public class Goods
    {
        protected double price;
        protected string countryOfOrigin;
        public string name;
        protected DateTime packingDate;
        protected string description;
    }

    public class Products : Goods
    {
        public Products(double price, string countryOfOrigin, string name, DateTime packingDate, string description, DateTime expirationDate, int amount, string measure)
        {
            this.price = price;
            this.countryOfOrigin = countryOfOrigin;
            this.name = name;
            this.packingDate = packingDate;
            this.description = description;
            this.expirationDate = expirationDate;
            this.amount = amount;
            this.measure = measure;
        }

        public Products(string name, double price)
        {
            this.price = price;
            this.name = name;
        }

        DateTime expirationDate;
        int amount;
        string measure;
    }

    public class Books : Goods
    {
        public Books(double price, string countryOfOrigin, string name, DateTime packingDate, string description, int amountOfPages, string publisher, string authors)
        {
            this.price = price;
            this.countryOfOrigin = countryOfOrigin;
            this.name = name;
            this.packingDate = packingDate;
            this.description = description;
            this.amountOfPages = amountOfPages;
            this.publisher = publisher;
            this.authors = authors;
        }

        public Books (string name, double price)
        {
            this.price = price;
            this.name = name;
        }

        int amountOfPages;
        string publisher;
        string authors;
    }
}