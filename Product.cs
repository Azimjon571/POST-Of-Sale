using System.Data.SqlClient;
using System.Windows.Forms;

namespace POST_Of_Sale
{
    public partial class Product : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public Product()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            dgvProlist.ReadOnly = true;
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProlist.Rows.Clear();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder FROM tbProduct AS p INNER JOIN tbBrand AS b ON b.id = p.bid INNER JOIN tbCategory AS c on c.id=p.cid WHERE CONCAT( p.pcode,p.barcode, p.pdesc, b.brand, c.category) LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProlist.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            ProductModule moduleForm = new ProductModule(this);
            moduleForm.ShowDialog();
        }

        private void dgvProlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProlist.Columns[e.ColumnIndex].Name;
            if (colName is "Edit")
            {
                ProductModule productModule = new ProductModule(this);
                productModule.txtProcode.Text = dgvProlist[1, e.RowIndex].Value.ToString();
                productModule.txtBarcode.Text = dgvProlist[2, e.RowIndex].Value.ToString();
                productModule.txtDescription.Text = dgvProlist[3, e.RowIndex].Value.ToString();
                productModule.comboBrand.Text = dgvProlist[4, e.RowIndex].Value.ToString();
                productModule.comboCategory.Text = dgvProlist[5, e.RowIndex].Value.ToString();
                productModule.txtPrice.Text = dgvProlist[6, e.RowIndex].Value.ToString();
                productModule.UDReOrder.Value = int.Parse(dgvProlist[7, e.RowIndex].Value.ToString());

                productModule.txtProcode.Enabled = false;
                productModule.btnSaveProList.Enabled = false;
                productModule.btnUpdateProList.Enabled = true;
                productModule.ShowDialog();
            }
            else if (colName is "Delete")
            {
                if (MessageBox.Show("Are you want to delete this record?", "Delete Record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbProduct WHERE pcode LIKE '" + dgvProlist[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been succesfuly deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadProduct();
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            LoadProduct();
        }
    }
}
