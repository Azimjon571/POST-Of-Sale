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
    public partial class Void : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        CancalOrder cancalOrder;
        public Void(CancalOrder canOr)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cancalOrder = canOr;
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                cn.Open();
                cm = new SqlCommand("Select * From tbUser where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    user = dr["username"].ToString();
                    dr.Close();
                    cn.Close();
                    SaveCancelOrder(user);
                    if (cancalOrder.cbInventory.Text=="Yes")
                    {
                        dbcon.ExcuteQuery("UPDATE tbProduct SET qty = qty +" + cancalOrder.npdCancelQty.Value + "WHERE pcode='" + cancalOrder.txtPcode.Text + "'");
                    }
                    dbcon.ExcuteQuery("UPDATE tbCart SET qty = qty -" + cancalOrder.npdCancelQty.Value + "WHERE id LIKE '" + cancalOrder.txtID.Text + "'");
                    MessageBox.Show("Order transaction succesfully cancelled!", "Cancel order ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    cancalOrder.ReasonSoldList();
                    cancalOrder.Dispose();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message,"Warming",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void SaveCancelOrder(string user)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tbCancel(transno, pcode, price, qty, total, sdate, voidby, cancelledby, reason, action)VALUES(@transno, @pcode, @price, @qty, @total, @sdate, @voidby, @cancelledby, @reason, @action)", cn);
                cm.Parameters.AddWithValue("@transno", cancalOrder.txtTransno.Text);
                cm.Parameters.AddWithValue("@pcode", cancalOrder.txtPcode.Text);
                cm.Parameters.AddWithValue("@price",double.Parse(cancalOrder.txtPrice.Text));
                cm.Parameters.AddWithValue("@qty", int.Parse(cancalOrder.txtQty.Text));
                cm.Parameters.AddWithValue("@total", cancalOrder.txtTotal.Text);
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@voidby", user);
                cm.Parameters.AddWithValue("@cancelledby", cancalOrder.txtCanBy.Text);
                cm.Parameters.AddWithValue("@reason", cancalOrder.txtReasons.Text);
                cm.Parameters.AddWithValue("@action", cancalOrder.cbInventory.Text);
                cm.ExecuteReader();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
