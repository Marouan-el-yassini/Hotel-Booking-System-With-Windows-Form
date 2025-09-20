namespace HBS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Room> rooms = new List<Room>()
            {
                new Room(101, "Single", 100,Image.FromFile(),
                new Room(102, "Double", 150,Image.FromFile(),
                new Room(201, "Suite", 250,Image.FromFile(),
                new Room(202, "Double", 150,Image.FromFile(),
                new Room(301, "Single", 100,Image.FromFile()),
                new Room(302, "Suite", 250,Image.FromFile()),
                new Room(401, "Double", 150,Image.FromFile()),
                new Room(402, "Single", 100,Image.FromFile()),
                new Room(501, "Suite", 250,Image.FromFile()),
            };

            // Enable automatic generation of columns
            dataGridView1.AutoGenerateColumns = false;

            // Add columns manually
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Number",
                HeaderText = "Numéro"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Type",
                HeaderText = "Type"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PriceNight",
                HeaderText = "Prix/Nuit"
            });

            // Image column
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.DataPropertyName = "Photos";
            imgCol.HeaderText = "Photo";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(imgCol);

            // Bind the data source
            dataGridView1.DataSource = rooms;

            // Adjust row height to show images properly
            dataGridView1.RowTemplate.Height = 100;


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Client c = new Client(textBoxName.Text, textBoxEmail.Text, true, Guid.NewGuid());
            string type = textBoxType.Text;
            if (type != "Single" && type != "Double" && type != "Suite")
            {
                return;
            }

            Room r = new Room((int)numericUpDown1.Value, type, Convert.ToDouble(textBoxPrice.Text), Image.FromFile();
            Reservation res = new Reservation(c, r, dateTimePickerIn.Value, dateTimePickerOut.Value);
            Form2 form2 = new Form2(c,r,res);
            form2.Show();
            this.Hide();
        }
    }
}
