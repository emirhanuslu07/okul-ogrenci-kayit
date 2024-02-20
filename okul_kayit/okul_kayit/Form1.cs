using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace okul_kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veritabani vt = new veritabani();

            vt.ogrencilerr.Load();
            vt.siniflar.Load();
            dataGridView1.DataSource = vt.ogrencilerr.Local.ToBindingList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;


            dataGridView1.ColumnHeadersVisible = true;

            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();

            combo.Items.AddRange("10/A", "10/B", "10/C");
            combo.HeaderText = "sinif";
            dataGridView1.Columns.Add(combo);
            int sayi = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns[sayi].DisplayIndex = 5;

            comboBox1.Items.Add("hepsini seç");
            comboBox1.Items.Add("10/A");
            comboBox1.Items.Add("10/B");
            comboBox1.Items.Add("10/C");

            combo.ValueMember= "";
            combo.DisplayMember = "";
            combo.DisplayMember = "";
            dataGridView1.Columns.Add(combo);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //buranýn altý 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            label1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            label2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            label3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            label4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //üste olan kendi keyfe göre kod dur 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem?.ToString();

         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

           
            
        }
    }
}
