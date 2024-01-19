using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POST_Of_Sale
{
    public partial class Category : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;


        public Category()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadBoard();
        }


        public void LoadBoard()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbCategory ORDER BY category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModule categoryModule = new CategoryModule(this);
            categoryModule.ShowDialog();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName is "Delete")
            {
                if (MessageBox.Show("Are you want to delete this record?", "Delete Record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbCategory WHERE id LIKE '" + dgvCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been succesfuly deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName is "Edit")
            {
                CategoryModule categoryModule = new CategoryModule(this);
                categoryModule.lblIDCa.Text = dgvCategory[1, e.RowIndex].Value.ToString();
                categoryModule.txtCategory.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                categoryModule.btnSaveCa.Enabled = false;
                categoryModule.btnUpdateCa.Enabled = true;
                categoryModule.ShowDialog();
            }
            LoadBoard();
        }

        private void Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }
    }
}
