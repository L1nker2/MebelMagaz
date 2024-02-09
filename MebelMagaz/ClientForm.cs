using System.Data;

namespace MebelMagaz
{
    public partial class ClientForm : Form
    {
        public ClientForm()
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
                var clients = db.Clients.ToList();
                DataTable dt = new();
                dt.Columns.Add("Айди");
                dt.Columns.Add("Имя");
                dt.Columns.Add("Фамилия");
                dt.Columns.Add("Телефон");
                foreach (var client in clients)
                {
                    dt.Rows.Add(client.Id, client.FirstName, client.SecondName, client.Phone);
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
            DataBase.RemoveClient(id);
            MessageBox.Show("Удаление прошло успешно");
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            string sname = textBox2.Text;
            string phone = textBox3.Text;
            if(fname == "" && sname == "" && phone == "")
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            DataBase.AddClient(fname, sname, phone);
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
