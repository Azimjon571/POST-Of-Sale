using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace POST_Of_Sale
{
    public partial class ProductModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Post of sale";
        Product product;

        public ProductModule(Product pr)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            this.KeyPress += ProductModule_KeyPress;
            product = pr;
            LoadBrand();
            LoadCategory();
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            txtBarcode.Text = e.Barcode;
        }

        public void LoadCategory()
        {
            comboCategory.Items.Clear();
            comboCategory.DataSource = dbcon.getTable("SELECT * FROM tbCategory");
            comboCategory.DisplayMember = "category";
            comboCategory.ValueMember = "id";
        }

        public void LoadBrand()
        {
            comboBrand.Items.Clear();
            comboBrand.DataSource = dbcon.getTable("SELECT * FROM tbBrand");
            comboBrand.DisplayMember = "brand";
            comboBrand.ValueMember = "id";
        }

        private void btnCloseBr_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSaveProList_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBarcode.Text))
                {
                    MessageBox.Show("Barcode is emtpy or defuld");
                }
                else if (string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("Description is emtpy or defuld");
                }
                else if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Prise is emtpy or defuld");
                }
                else if (string.IsNullOrEmpty(txtProcode.Text))
                {
                    MessageBox.Show("Product Code is emtpy or defuld");
                }
                else
                {
                    if (ProductExists(txtProcode.Text, txtBarcode.Text, txtDescription.Text))
                    {
                        MessageBox.Show("Product with this code already exists in the database");
                        return; // Stop further execution
                    }

                    var mboxSavePro = MessageBox.Show("Are you wand to save this product?", "Save Product",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mboxSavePro.Equals(DialogResult.Yes))
                    {
                        cm = new SqlCommand("INSERT INTO tbProduct(pcode, barcode, pdesc, bid, cid, price, reorder)VALUES(@pcode,@barcode,@pdesc,@bid,@cid,@price,@reorder)", cn);
                        cm.Parameters.AddWithValue("@pcode", txtProcode.Text);
                        cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                        cm.Parameters.AddWithValue("@pdesc", txtDescription.Text);
                        cm.Parameters.AddWithValue("@bid", comboBrand.SelectedValue);
                        cm.Parameters.AddWithValue("@cid", comboCategory.SelectedValue);
                        cm.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                        cm.Parameters.AddWithValue("@reorder", UDReOrder.Value);
                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Product hes been successfuly saved", stitle);
                        Clear();
                        product.LoadProduct();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ProductExists(string productCode, string barcode, string productDescription)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbcon.myConnection()))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM tbProduct WHERE pcode = @pcode OR barcode = @barcode OR pdesc = @pdesc";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pcode", productCode);
                        command.Parameters.AddWithValue("@barcode", barcode);
                        command.Parameters.AddWithValue("@pdesc", productDescription);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking product existence: {ex.Message}");
                return false;
            }
        }
        private void Clear()
        {
            txtBarcode.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtProcode.Clear();
            comboBrand.SelectedIndex = 0;
            comboCategory.SelectedIndex = 0;
            UDReOrder.Value = 1;

            txtProcode.Enabled = true;
            txtProcode.Focus();
            btnSaveProList.Enabled = true;
            btnUpdateProList.Enabled = false;
        }

        private void btnCancelProList_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdateProList_Click(object sender, EventArgs e)
        {
            var mboxUpdate = MessageBox.Show("Are you want to Update this record?", "Update Record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mboxUpdate.Equals(DialogResult.Yes))
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbProduct SET barcode=@barcode,pdesc=@pdesc, bid=@bid, cid=@cid, price=@price, reorder=@reorder WHERE pcode LIKE @pcode ", cn);
                cm.Parameters.AddWithValue("@pcode", txtProcode.Text);
                cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                cm.Parameters.AddWithValue("@pdesc", txtDescription.Text);
                cm.Parameters.AddWithValue("@bid", comboBrand.SelectedValue);
                cm.Parameters.AddWithValue("@cid", comboCategory.SelectedValue);
                cm.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                cm.Parameters.AddWithValue("@reorder", UDReOrder.Value);
                cm.ExecuteNonQuery();
                MessageBox.Show("Product has been succesfuly Updated.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                this.Dispose();
            }

        }

        private void ProductModule_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleBarcodeData(e.KeyChar);
        }

        private void HandleBarcodeData(char barcodeChar)
        {
            // Append the barcode data to the TextBox
            txtBarcode.Text += barcodeChar;

            // Optionally, you can check for a specific character (e.g., Enter) to signify the end of the barcode
            if (barcodeChar == '\r') // Enter key
            {
                // Process the complete barcode data
                ProcessBarcode(txtBarcode.Text);
                // Clear the TextBox for the next scan
                txtBarcode.Clear();
            }
        }

        private void ProcessBarcode(string barcodeData)
        {
            // Add your logic to process the barcode data here
            // For example, you can display it in a MessageBox
            MessageBox.Show("Scanned Barcode: " + barcodeData);
        }
    }
}
