
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Security.Cryptography;

namespace The_Ticketing_Vendor_Machine
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        public static string uname;
        DataTable tb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b1.BackgroundImageLayout = ImageLayout.Stretch;
            string s = "initial catalog = ticketmachine; data source = SUIMEI; integrated security = true";
            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }
        void formload()
        {
            showGRD();
            enable(grp2, false);
        }
        public void showGRD()
        {
            string sql = "select * from destination";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;

            string sql2 = "select name from destination";
            data = new SqlDataAdapter(sql2, cn);
            tb = new DataTable();
            data.Fill(tb);
            des.DataSource = tb;
            des.DisplayMember = "name";
            des.ValueMember = "name";
        }
        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }

        private void grd_Click(object sender, EventArgs e)
        {
            des.Text = grd.CurrentRow.Cells[1].Value.ToString();
            if (des.Text == "")
            {
                enable(grp2, false);

            }
            else
            {
                enable(grp2, true);
            }
        }

        private void des_SelectedIndexChanged(object sender, EventArgs e)
        {
            enable(grp2, true);

        }

        private void b1_Click(object sender, EventArgs e)
        {
            uname = des.Text;
            this.Hide();
            Form2 newform = new Form2();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uname = des.Text;
            this.Hide();
            Form3 newform = new Form3();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uname = des.Text;
            this.Hide();
            Form4 newform = new Form4();
            newform.Show();
        }
    }
}