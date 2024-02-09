using System.Data;

namespace MebelMagaz
{
    public partial class ContractForm : Form
    {
        public ContractForm()
        {
            InitializeComponent();
            dataGridView1.Size = new(1124, 646);
            panel1.Visible = false;
            LoadData();
            LoadContext();
        }
        void LoadContext()
        {
            using (DataBase db = new())
            {
                var products = db.Products.ToList();
                var clients = db.Clients.ToList();
                var services = db.Services.ToList();
                foreach (var product in products)
                {
                    comboBox3.Items.Add(product.Name);
                }
                foreach (var client in clients)
                {
                    comboBox2.Items.Add(client.Phone);
                }
                foreach (var service in services)
                {
                    comboBox1.Items.Add(service.Name);
                }
            }
        }
        void LoadData()
        {
            using (DataBase db = new())
            {
                var contracts = db.Contracts.ToList();
                DataTable dt = new();
                dt.Columns.Add("Айди");
                dt.Columns.Add("Товар");
                dt.Columns.Add("Телефон клиента");
                dt.Columns.Add("Дополнительные сервисы");
                foreach (var contract in contracts)
                {
                    Product product = db.Products.FirstOrDefault(el => el.Id == contract.ProductId);
                    Client client = db.Clients.FirstOrDefault(el => el.Id == contract.ClientId);
                    Service service = db.Services.FirstOrDefault(el => el.Id == contract.ServiceId) ?? new Service() { Name = "Отсутствует" };
                    dt.Rows.Add(contract.Id, product.Name, client.Phone, service.Name);
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
            dataGridView1.Size = new(1124, 420);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Необходимо выбрать запись");
                return;
            }
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int.TryParse(row.Cells["Айди"].Value.ToString(), out int id);
            DataBase.RemoveContract(id);
            MessageBox.Show("Удаление прошло успешно");
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productName = comboBox3.SelectedItem.ToString();
            string phone = comboBox2.SelectedItem.ToString();
            string serviceName = Convert.ToString(comboBox1.SelectedItem??"Отсутствует");
            using(DataBase db = new())
            {
                Product product = db.Products.FirstOrDefault(el => el.Name == productName);
                Client client = db.Clients.FirstOrDefault(el => el.Phone == phone);
                Service service = db.Services.FirstOrDefault(el => el.Name == serviceName) ?? null;
                if(service == null)
                {
                    DataBase.AddContract(product.Id, client.Id);
                }
                else
                {
                    DataBase.AddContract(product.Id, client.Id, service.Id);
                }
                MessageBox.Show("Добавление прошло успешно");
                panel1.Visible = false;
                dataGridView1.Size = new(1124, 646);
                LoadData();
            }
        }
    }
}
