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
    public partial class DailySale : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public string solduser;
        string stitle = "Post of sale";
        public DailySale()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadCashier();
        }

        private void btnCloseBr_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }   


        public void LoadCashier()
        {
            cbCashier.Items.Clear();
            cbCashier.Items.Add("All Cashier");
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbUser WHERE role LIKE 'cashier'", cn);
            dr= cm.ExecuteReader();
            while (dr.Read())
            {
                cbCashier.Items.Add(dr["username"].ToString()); 
            }
            dr.Close();
            cn.Close();
        }
        public void LoadSold()
        {
            int i = 0;
            double total = 0;
            dgvSold.Rows.Clear();
            cn.Open();
            //string filterTransNo = string.IsNullOrEmpty(txtTransNoFilter.Text) ? "" : txtTransNoFilter.Text.Trim();
            if (!string.IsNullOrEmpty(txtTransNoFilter.Text.Trim()))
            {
                cm = new SqlCommand("SELECT c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total " +
                                    "FROM tbCart AS c INNER JOIN tbProduct AS p ON c.pcode = p.pcode " +
                                    "WHERE status LIKE 'Sold' AND transno = '" + txtTransNoFilter.Text + "'", cn);
            }
            else
            {
                if (cbCashier.Text == "All Cashier") //+ (string.IsNullOrEmpty(filterTransNo) ? "" : " AND c.transno = '" + filterTransNo + "'"
                {
                    cm = new SqlCommand("Select c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total from tbCart as c INNER JOIN tbProduct as p on c.pcode =p.pcode where status like 'Sold' and sdate between '" + dtFrom.Value + "'and '" + dtTo.Value + "'" , cn);

                }
                else
                {
                    cm = new SqlCommand("Select c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc,  c.total from tbCart as c INNER JOIN tbProduct as p on c.pcode =p.pcode where status like 'Sold' and sdate between '" + dtFrom.Value + "'and '" + dtTo.Value + "' and cashier like '" + cbCashier.Text + "'", cn);

                }
            }
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                total += double.Parse(dr["total"].ToString());
                dgvSold.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString());
            }
            dr.Close();
            cn.Close();
            lblTotal.Text = total.ToString("#,##0.00");
        }

        private void cbCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void DailySale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void dgvSold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string collName = dgvSold.Columns[e.ColumnIndex].Name;
            if (collName== "Cancel")
            {
                CancalOrder cancalOrder = new CancalOrder(this);
                cancalOrder.txtID.Text = dgvSold.Rows[e.RowIndex].Cells[1].Value.ToString();
                cancalOrder.txtTransno.Text = dgvSold.Rows[e.RowIndex].Cells[2].Value.ToString();
                cancalOrder.txtPcode.Text = dgvSold.Rows[e.RowIndex].Cells[3].Value.ToString();
                cancalOrder.txtDesc.Text = dgvSold.Rows[e.RowIndex].Cells[4].Value.ToString();
                cancalOrder.txtPrice.Text = dgvSold.Rows[e.RowIndex].Cells[5].Value.ToString();
                cancalOrder.txtQty.Text = dgvSold.Rows[e.RowIndex].Cells[6].Value.ToString();
                cancalOrder.txtDisc.Text = dgvSold.Rows[e.RowIndex].Cells[7].Value.ToString();
                cancalOrder.txtTotal.Text = dgvSold.Rows[e.RowIndex].Cells[8].Value.ToString();
                cancalOrder.txtCanBy.Text = solduser;
                cancalOrder.ShowDialog();
            }
        }

        private void txtSearch_TabIndexChanged(object sender, EventArgs e)
        {
            LoadSold();
        }
    }
}
