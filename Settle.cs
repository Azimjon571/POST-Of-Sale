using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POST_Of_Sale
{
    public partial class Settle : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        Cashier cashier;
        public Settle(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cashier = cash;
        }

        #region NUmbers
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnOne.Text;
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            txtCash.Text += btntwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnNine.Text;
        }


        private void btnZero_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnZero.Text;
        }

        private void btnDubleZero_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnDubleZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtCash.Text.Length > 0)
            {
                // Remove the last character from the text
                txtCash.Text = txtCash.Text.Substring(0, txtCash.Text.Length - 1);
            }
        }
        #endregion Numbers
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double.Parse(txtChange.Text)< 0)||(txtCash.Text.Equals("")))
                {
                    MessageBox.Show("Insufficient amount, Please enter the correct amount!", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for(int i = 0; i < cashier.dgvCashier.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tbProduct SET qty = qty -" + int.Parse(cashier.dgvCashier.Rows[i].Cells[5].Value.ToString()) + "WHERE pcode ='" + cashier.dgvCashier.Rows[i].Cells[2].Value.ToString() + "'", cn); ;
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("UPDATE tbCart SET status = 'Sold' WHERE id ='" + cashier.dgvCashier.Rows[i].Cells[1].Value.ToString() + "'", cn); ;
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    MessageBox.Show("Payment Succesfully saved!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cashier.GetTranNo();
                    cashier.LoadCart();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale =double.Parse(txtTotalSale.Text);
                double cash = double.Parse(txtCash.Text);
                double change = cash - sale;
                txtChange.Text = change.ToString("#,##0.00");
            }
            catch (Exception)
            {
                txtChange.Text = "0.00";
            }
        }

        private void Settle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode==Keys.Enter)
            {
                btnEnter.PerformClick();
            }
        }
    }
}
