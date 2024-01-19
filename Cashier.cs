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
    public partial class Cashier : Form
    {
        private StringBuilder scannedData = new StringBuilder();
        private System.Windows.Forms.Timer timer;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;


        int qty;
        string id;
        string QTY = "1";
        string price;


        string stitle = "POST OF SALE";
        public Cashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            InitializeTimer();
            GetTranNo();
            dgvCashier.ReadOnly = true;
            
        }


        private void btnCloseBr_Click(object sender, EventArgs e)
        {
            if (dgvCashier.Rows.Count > 0)
            {
                MessageBox.Show("Unable to logout. Please cancel the transaction", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (MessageBox.Show("Exit Application?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        public void slide(Button button)
        {
            panelbtnSlide.BackColor = Color.White;
            panelbtnSlide.Height = button.Height;
            panelbtnSlide.Top = button.Top;
        }
        #region buttnos
        private void btnSearchPro_Click(object sender, EventArgs e)
        {
            slide(btnSearchPro);
            LookUpProduct lookUp = new LookUpProduct(this);
            lookUp.LoadProduct();
            lookUp.ShowDialog();
            lookUp.txtSearch.Focus();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            slide(btnDiscount);
            Discount discount = new Discount(this);
            discount.lbId.Text = id;
            discount.txtTotalPrice.Text = price;
            discount.ShowDialog();
            discount.txtDiscount.Focus();
        }

        private void btnSettlePay_Click(object sender, EventArgs e)
        {
            slide(btnSettlePay);
            Settle settle = new Settle(this);
            settle.txtTotalSale.Text = lblDisplayTotal.Text;
            settle.ShowDialog();
        }

        private void btnClearCard_Click(object sender, EventArgs e)
        {
            slide(btnClearCard);
            if(MessageBox.Show("Remove All items from cart?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("DELETE from tbCart where transno like '" + lblTransNo.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("All items has been succesfully remove", "Remove item", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadCart();
            }
        }

        private void btnDailySale_Click(object sender, EventArgs e)
        {
            slide(btnDailySale);
            DailySale dailySale = new DailySale();
            dailySale.solduser = lblUserNameCashi.Text;
            dailySale.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            slide(btnChangePass);
            ChangePassword changePassword = new ChangePassword(this);
            changePassword.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (dgvCashier.Rows.Count>0)
            {
                MessageBox.Show("Unable to logout. Please cancel the transaction", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                slide(btnLogOut);
                Login login = new Login();
                this.Dispose();
                login.ShowDialog();
            }
        }
        #endregion buttons

        public void LoadCart()
        {
            try
            {
                Boolean hascart = false;
                int i = 0;
                double total = 0;
                double discount = 0;
                dgvCashier.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT c.id, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total FROM tbCart AS c INNER JOIN tbProduct AS p ON c.pcode=p.pcode WHERE c.transno LIKE @transno and c.status LIKE 'Pending'", cn);
                cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += double.Parse(dr["total"].ToString());
                    discount += double.Parse(dr["disc"].ToString());
                    dgvCashier.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,#00.00"));
                    hascart = true;
                }
                dr.Close();
                cn.Close();
                lblSaleTotal.Text = total.ToString("#,##0.00");
                lblDiscount.Text = discount.ToString("#,##00.00");
                GetCartTotal();

                if (hascart)
                {
                    btnClearCard.Enabled = true;
                    btnDiscount.Enabled = true;
                    btnSettlePay.Enabled = true;
                }
                else
                {
                    btnClearCard.Enabled = false;
                    btnDiscount.Enabled = false;
                    btnSettlePay.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, stitle,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public void GetCartTotal()
        {
            double discount = double.Parse(lblDiscount.Text);
            double sales = double.Parse(lblSaleTotal.Text) - discount;
            double vat = sales * 0.12;//vat 0.12%
            double vatable = sales -vat;

            lblVAT.Text = vat.ToString("#,##00.00");
            lblVatable.Text = vatable.ToString("#,##00.00");
            lblDisplayTotal.Text = sales.ToString("#,##00.00");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        

        public void GetTranNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM tbCart WHERE transno LIKE '" + sdate + "%' ORDER  by id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransNo.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblTransNo.Text = transno;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, stitle);
            }
            
        }
        

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarcode.Text == string.Empty)
                {
                    return;
                }
                else
                {
                    string _pcode;
                    double _price;
                    int _qty;
                    if (txtQty.Text=="")
                    {
                        txtQty.Text = "1";
                    }
                    else
                    {
                        txtQty.Text = txtQty.Text;
                    }
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tbProduct WHERE barcode LIKE '" + txtBarcode.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        qty = int.Parse(dr["qty"].ToString());
                        _pcode = dr["pcode"].ToString();
                        _price = double.Parse(dr["price"].ToString());
                        _qty = int.Parse(txtQty.Text);
                        dr.Close();
                        cn.Close();
                        AddToCart(_pcode, _price, _qty);
                        LoadCart();
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AddToCart(string _pcode, double _price, int _qty)
        {
            try
            {

                string id = "";
                int cart_qty = 0;
                bool found = false;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tbCart WHERE transno = @transno and pcode = @pcode", cn);
                cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
                cm.Parameters.AddWithValue("@pcode", _pcode);
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
                        txtBarcode.Clear();
                        txtQty.Clear();
                        return;
                    }
                    cn.Open();
                    cm = new SqlCommand("Update tbCart set qty =(qty +" + txtQty.Text + ")Where id='" + id + "'", cn);
                    cm.ExecuteReader();
                    cn.Close();
                    txtBarcode.SelectionStart = 0;
                    txtBarcode.SelectionLength = txtBarcode.Text.Length;
                    LoadCart();
                    txtQty.Clear();
                }
                else
                {
                    if (qty < (int.Parse(txtQty.Text) + cart_qty))
                    {
                        MessageBox.Show("Unable to procced. Remaining quantity on hand is " + qty, "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBarcode.Clear();
                        txtQty.Clear();
                        return;
                    }
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbCart(transno, pcode, price, qty, sdate, cashier)VALUES(@transno, @pcode, @price, @qty, @sdate, @cashier)", cn);
                    cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
                    cm.Parameters.AddWithValue("@pcode", _pcode);
                    cm.Parameters.AddWithValue("@price", _price);
                    cm.Parameters.AddWithValue("@qty", _qty);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.Parameters.AddWithValue("@cashier", lblUserNameCashi.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadCart();
                    txtBarcode.Clear();
                    txtQty.Clear();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvCashier_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvCashier.CurrentRow.Index;
            id = dgvCashier[1, i].Value.ToString();
            price = dgvCashier[7, i].Value.ToString();
        }

        private void Cashier_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer.Start();

            // Append the barcode data to the Label
            txtBarcode.Text += e.KeyChar;

            // Append the barcode data to the StringBuilder for comparison
            scannedData.Append(e.KeyChar);
        }
        private void InitializeTimer()
        {
            // Initialize the timer with an interval for determining the end of scanning
            timer = new Timer();
            timer.Interval = 300; // Adjust the interval based on your needs
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Timer tick event is triggered periodically
            // Timer tick event is triggered when the specified interval elapses
            timer.Stop();

            // Clear the Label for the next scan 
            txtBarcode.Text = string.Empty;
            scannedData.Clear();
        }
        #region Number
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtQty.Text += btnOne.Text;
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            txtQty.Text += btntwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtQty.Text += btnThree.Text;
        }

        private void btnDZero_Click(object sender, EventArgs e)
        {
            txtQty.Text += btnDZero.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtQty.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtQty.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtQty.Text += btnSix.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtQty.Text += btnZero.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtQty.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtQty.Text += btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtQty.Text += btnNine.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtQty.Text.Length > 0)
            {
                // Remove the last character from the text
                txtQty.Text = txtQty.Text.Substring(0, txtQty.Text.Length - 1);
            }
        }
        #endregion Numbers

        private void dgvCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCashier.Columns[e.ColumnIndex].Name;
            
            if (colName=="Delete")
            {
                if (MessageBox.Show("Remove All items from cart?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.ExcuteQuery("DELETE from tbCart where id like '" + dgvCashier.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    MessageBox.Show("Items has been succesfully remove", "Remove item", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    LoadCart();
                }
            }
            else if (colName =="colAdd")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT SUM (qty) as qty FROM tbProduct WHERE pcode LIKE '" + dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString() + "'GROUP BY pcode", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                if (int.Parse(dgvCashier.Rows[e.RowIndex].Cells[5].Value.ToString())<i)
                {
                    dbcon.ExcuteQuery("UPDATE tbCart SET qty = qty +" + int.Parse(QTY) + "WHERE transno LIKE '" + lblTransNo.Text + "'AND pcode LIKE '" + dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining quantity on hand is " + i +"!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (colName == "colReduse")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT SUM (qty) as qty FROM tbCart WHERE pcode LIKE '" + dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString() + "'GROUP BY pcode", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                if (i>1)
                {
                    dbcon.ExcuteQuery("UPDATE tbCart SET qty = qty -" + int.Parse(QTY) + "WHERE transno LIKE '" + lblTransNo.Text + "'AND pcode LIKE '" + dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining quantity on cart is " + i + "!", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}
