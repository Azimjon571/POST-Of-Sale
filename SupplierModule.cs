using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POST_Of_Sale
{
    public partial class SupplierModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Post of sale";
        Supplier supplier;

        public SupplierModule(Supplier sp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            supplier = sp;
        }

        private void btnCloseBr_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSaveSupp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSuppName.Text))
                {
                    MessageBox.Show("Name is emtpy or defuld");
                }
                else if (string.IsNullOrEmpty(txtPhoneNum.Text))
                {
                    MessageBox.Show("Phone number is emtpy or defuld");
                }
                else if (string.IsNullOrEmpty(txtAdress.Text))
                {
                    MessageBox.Show("Addres is emtpy or defuld");
                }
                else if (string.IsNullOrEmpty(txtConPer.Text))
                {
                    MessageBox.Show("Contact Person is emtpy or defuld");
                }
                else if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Email is emtpy or defuld");
                }
                else if (string.IsNullOrEmpty(txtFaxNo.Text))
                {
                    MessageBox.Show("Fax No is emtpy or defuld");
                }
                else
                {
                    var mboxSaveSup = MessageBox.Show("Are you wand to save this Suplier?", "Save Product",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mboxSaveSup.Equals(DialogResult.Yes))
                    {
                        cm = new SqlCommand("INSERT INTO tbSupplier(supplier, address, contactperson, phone, email, fax)VALUES(@supplier, @address, @contactperson, @phone, @email, @fax)", cn);
                        cm.Parameters.AddWithValue("@supplier", txtSuppName.Text);
                        cm.Parameters.AddWithValue("@address", txtAdress.Text);
                        cm.Parameters.AddWithValue("@contactperson", txtConPer.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhoneNum.Text);
                        cm.Parameters.AddWithValue("@email", txtEmail.Text);
                        cm.Parameters.AddWithValue("@fax", txtFaxNo.Text);
                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Supplier hes been successfuly saved", stitle);
                        Clear();
                        supplier.LoadSupplier();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            txtSuppName.Clear();
            txtAdress.Clear();
            txtConPer.Clear();
            txtPhoneNum.Clear();
            txtEmail.Clear();
            txtFaxNo.Clear();

            btnSaveSupp.Enabled = true;
            btnUpdateSupp.Enabled = false;
            txtSuppName.Focus();
        }

        private void btnCancelSupp_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdateSupp_Click(object sender, EventArgs e)
        {
            try
            {
                var mboxUpdate = MessageBox.Show("Are you want to Update this record?", "Update Record",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mboxUpdate.Equals(DialogResult.Yes))
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tbSupplier SET supplier=@supplier, address=@address, contactperson=@contactperson, phone=@phone, email=@email, fax=@fax WHERE id=@id", cn);
                    cm.Parameters.AddWithValue("@id", lblID.Text);
                    cm.Parameters.AddWithValue("@supplier", txtSuppName.Text);
                    cm.Parameters.AddWithValue("@address", txtAdress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtConPer.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhoneNum.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFaxNo.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Supplier has been succesfuly Updated.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
