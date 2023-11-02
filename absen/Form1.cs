namespace absen
{
    public partial class Form1 : Form
    {

        List<Absensi> dataAbsensi = new List<Absensi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nis = textBox1.Text;
            string namaSiswa = textBox2.Text;
            string mataPelajaran = comboBox1.Text;
            DateTime tanggal = dateTimePicker1.Value;
            string kehadiran = (checkBox1.Checked ? "Hadir" : "") + (checkBox2.Checked ? "Tidak Hadir" : "");


            dataAbsensi.Add(new Absensi
            {
                NIS = nis,
                NamaSiswa = namaSiswa,
                MataPelajaran = mataPelajaran,
                Tanggal = tanggal,
                Kehadiran = kehadiran
            });

            dataGridView1.DataSource = null; // Membersihkan data sebelum menampilkan data yang baru
            dataGridView1.DataSource = dataAbsensi; // Mengatur data sumber DataGridView
        }
    }
}