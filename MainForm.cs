using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POST_Of_Sale
{
    public partial class MainMenu : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public string _pass;
        public MainMenu()
        {
            InitializeComponent();
            customizeDesing();
            cn = new SqlConnection(dbcon.myConnection());
            cn.Open();
        }
        #region panelSlide

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblTitle.Text = childForm.Text;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public void customizeDesing()
        {
            panelSubProduct.Visible = false;
            panelSubRecord.Visible = false;
            panelSubSettings.Visible = false;
            panelSubStock.Visible = false;
        }
        public void hideSubmenu()
        {
            if (panelSubProduct.Visible is true)
                panelSubProduct.Visible = false;
            if (panelSubRecord.Visible is true)
                panelSubRecord.Visible = false;
            if (panelSubSettings.Visible is true)
                panelSubSettings.Visible = false;
            if (panelSubStock.Visible is true)
                panelSubStock.Visible = false;
        }

        public void showSubmenu(Panel submenu)
        {
            if (submenu.Visible is false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion panelSlide

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubProduct);
        }

        private void btnPorductList_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            openChildForm(new Brand());
        }

        private void btnInStock_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubStock);
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            openChildForm(new StockIn());
            hideSubmenu();
        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier());
            hideSubmenu();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubRecord);
        }

        private void btnSaleHist_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnPosRec_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubSettings);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserAccount(this));

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            Store store = new Store();
            store.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            Login login = new Login();
            this.Dispose();
            login.ShowDialog();
        }
    }
}
