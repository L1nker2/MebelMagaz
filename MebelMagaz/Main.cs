namespace MebelMagaz
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            openChildForm(new Welcome());
        }
        Form activeForm = null;
        void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            viewPanel.Controls.Add(childForm);
            viewPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new ServiceForm());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new ClientForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал студент группы 404-ИС\nКорецкий Владислав Игоревич");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new ContractForm());
        }
    }
}
