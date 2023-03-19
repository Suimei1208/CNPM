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
    public partial class Form2 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        string des, temp;
        int cost;
        public Form2()
        {
            InitializeComponent();
        }
        public static bool IsCreditCardNumberValid(string creditCardNumber)
        {
            if (string.IsNullOrEmpty(creditCardNumber))
            {
                return false;
            }

            int sum = 0;
            bool isSecondDigit = false;

            for (int i = creditCardNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = 0;

                if (char.IsDigit(creditCardNumber[i]))
                {
                    currentDigit = int.Parse(creditCardNumber[i].ToString());
                }
                else
                {
                    return false;
                }

                if (isSecondDigit)
                {
                    currentDigit *= 2;

                    if (currentDigit > 9)
                    {
                        currentDigit -= 9;
                    }
                }

                sum += currentDigit;
                isSecondDigit = !isSecondDigit;
            }

            return sum % 10 == 0;
        }


        private void pay_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || num.Text == "" || cvv.Text == "" || IsCreditCardNumberValid(num.Text) == false)
            {
                MessageBox.Show("Error! Please enter again.");
            }
            else
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
                string sql2 = "INSERT INTO ticket values('" + code + "','" + name.Text + "'," + cost + ",'Credit Card','" + des + "')";
                data = new SqlDataAdapter(sql2, cn);
                tb = new DataTable();
                data.Fill(tb);
                MessageBox.Show("Payment successfully. Please take ticket and sit down.");
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string s = "initial catalog = ticketmachine; data source = SUIMEI; integrated security = true";
            cn = new SqlConnection(s);
            cn.Open();
            des = Form1.uname;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
        }
    }
}
