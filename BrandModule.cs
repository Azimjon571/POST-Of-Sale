using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POST_Of_Sale
{
    public partial class BrandModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Brand brand;

        public BrandModule(Brand br)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            brand = br;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // To insert brand Name to brand table
            try
            {
                if (txtBrand.Text == "")
                {
                    MessageBox.Show("Brand is Empty");
                    Clear();
                }
                else
                {
                    var mbox = MessageBox.Show("Are you want to save this brand", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mbox.Equals(DialogResult.Yes))
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tbBrand(brand) VALUES (@brand)", cn);
                        cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been succesfuly saved.", "POS");
                        Clear();
                        brand.LoadBoard();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtBrand.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtBrand.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var mBoxUpdate = MessageBox.Show("Are you want to Update this record?", "Update Record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mBoxUpdate == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbBrand SET brand=@brand WHERE id LIKE '" + lblID.Text + "'", cn);
                cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                cm.ExecuteNonQuery();
                MessageBox.Show("Brand has been succesfuly Updated.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                this.Dispose();
            }
        }
        private void btnCloseBr_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BrandModule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
                btnUpdate.PerformClick();
            }
            else if (e.KeyCode is Keys.Escape)
            {
                btnCloseBr.PerformClick();
            }
        }
    }
}
