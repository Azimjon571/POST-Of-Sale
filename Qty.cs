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

namespace POST_Of_Sale
{
    public partial class Qty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string pcode;
        private double price;
        private String transno;
        private int qty;
        Cashier cashier;

        string stitle = "POST OF SALE";
        public Qty(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cashier = cash;
        }
        public void ProductDetailes(string pcode, double price, string transno, int qty)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar==13)&& (txtQty.Text != string.Empty))
            {
                try
                {
                    string id = "";
                    int cart_qty = 0;
                    bool found = false;
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tbCart WHERE transno = @transno and pcode = @pcode", cn);
                    cm.Parameters.AddWithValue("@transno", transno);
                    cm.Parameters.AddWithValue("@pcode", pcode);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        id = dr["id"].ToString();
                        cart_qty = int.Parse(dr["qty"].ToString());
                        found = true;
                    }
                    else found = false;
                    dr.Close();
                    cn.Close();

                    if (found)
                    {

                        if (qty < (int.Parse(txtQty.Text) + cart_qty))
                        {
                            MessageBox.Show("Unable to procced. Remaining quantity on hand is " + qty, "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtQty.Clear();
                            return;
                        }
                        cn.Open();
                        cm = new SqlCommand("Update tbCart set qty =(qty +" + txtQty.Text + ")Where id='" + id + "'", cn);
                        cm.ExecuteReader();
                        cn.Close();
                        this.Dispose();
                        cashier.LoadCart();
                    }
                    else
                    {
                        if (qty < (int.Parse(txtQty.Text) + cart_qty))
                        {
                            MessageBox.Show("Unable to procced. Remaining quantity on hand is " + qty, "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtQty.Clear();
                            return;
                        }
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tbCart(transno, pcode, price, qty, sdate, cashier)VALUES(@transno, @pcode, @price, @qty, @sdate, @cashier)", cn);
                        cm.Parameters.AddWithValue("@transno", transno);
                        cm.Parameters.AddWithValue("@pcode", pcode);
                        cm.Parameters.AddWithValue("@price", price);
                        cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.Parameters.AddWithValue("@cashier", cashier.lblUserNameCashi.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        cashier.LoadCart();
                        cashier.txtBarcode.Clear();
                        cashier.txtBarcode.Focus();
                        txtQty.Clear();
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
