using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Ticketing_Vendor_Machine
{
    public partial class Form4 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        string des, temp;
        int cost;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string s = "initial catalog = ticketmachine; data source = SUIMEI; integrated security = true";
            cn = new SqlConnection(s);
            cn.Open();
            des = Form1.uname;
            ok.Enabled = false;
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string randomString = name.Text;
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(randomString, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(5, "#000000", "#FFFFFF", true);
                qrCodeImage = new Bitmap(qrCodeImage, new Size(227, 221));
                pb.Image = qrCodeImage;
                ok.Enabled = true;
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string sql = "select cost from destination where name = '" + des + "'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            if (tb.Rows.Count > 0 && tb.Rows[0]["cost"] != null)
            {
                temp = tb.Rows[0]["cost"].ToString();
                cost = int.Parse(temp);
            }

            string code = DateTime.Now.Ticks.ToString().Substring(0, 10);
            string sql2 = "INSERT INTO ticket values('" + code + "','" + name.Text + "'," + cost + ",'Momo','" + des + "')";
            data = new SqlDataAdapter(sql2, cn);
            tb = new DataTable();
            data.Fill(tb);
            MessageBox.Show("Payment successfully. Please take ticket and sit down.");
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
        }
    }

}
