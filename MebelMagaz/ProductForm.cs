using System.Data;

namespace MebelMagaz
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            dataGridView1.Size = new(1106, 587);
            panel1.Visible = false;
            LoadData();
        }
        void LoadData()
        {
            using (DataBase db = new())
            {
                var products = db.Products.ToList();
                DataTable dt = new();
                dt.Columns.Add("Айди");
                dt.Columns.Add("Название товара");
                dt.Columns.Add("Описание");
                dt.Columns.Add("Цена");
                foreach (var product in products)
                {
                    dt.Rows.Add(product.Id, product.Name, product.Description, product.Price);
                }
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dataGridView1.Size = new(1106, 371);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Необходимо выбрать запись");
            }
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int.TryParse(row.Cells["Айди"].Value.ToString(), out int id);
            DataBase.RemoveProduct(id);
            MessageBox.Show("Удаление прошло успешно");
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string desc = textBox2.Text;
            string price = textBox3.Text;
            if (name == "" && desc == "" && price == "")
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            int.TryParse(price, out int Price);
            DataBase.AddProduct(name, desc, Price);
            MessageBox.Show("Добавление прошло успешно");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            panel1.Visible = false;
            dataGridView1.Size = new(1106, 587);
            LoadData();
        }
    }
}
