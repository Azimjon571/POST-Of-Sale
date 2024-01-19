using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POST_Of_Sale
{
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Category category;
        public CategoryModule(Category ct)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            category = ct;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSaveCa_Click(object sender, EventArgs e)
        {
            // To insert brand Name to brand table
            try
            {
                if (txtCategory.Text == "")
                {
                    MessageBox.Show("Category Name is Empty");
                    Clear();
                }
                else
                {
                    var mboxSave = MessageBox.Show("Are you want to save this category", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mboxSave.Equals(DialogResult.Yes))
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tbCategory(category) VALUES (@category)", cn);
                        cm.Parameters.AddWithValue("@category", txtCategory.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been succesfuly saved.", "POS");
                        Clear();
                        category.LoadBoard();
                    }
                    else
                        Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Clear()
        {
            txtCategory.Clear();
            btnUpdateCa.Enabled = false;
            btnSaveCa.Enabled = true;
            txtCategory.Focus();
        }

        private void btnUpdateCa_Click(object sender, EventArgs e)
        {
            var mboxUpdate = MessageBox.Show("Are you want to Update this record?", "Update Record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mboxUpdate.Equals(DialogResult.Yes))
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbCategory SET category=@category WHERE id LIKE '" + lblIDCa.Text + "'", cn);
                cm.Parameters.AddWithValue("@category", txtCategory.Text);
                cm.ExecuteNonQuery();
                MessageBox.Show("Category has been succesfuly Updated.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                this.Dispose();
            }
        }
        private void btnCancelCa_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CategoryModule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveCa.PerformClick();
                btnUpdateCa.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnClose.PerformClick();
            }
        }
    }
}
