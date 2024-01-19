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
    public partial class ChangePassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        Cashier cashier;
        public ChangePassword(Cashier cash)
        {
            InitializeComponent();
            cashier = cash;
            lblUserName.Text = cashier.lblUserNameCashi.Text;

        }
        private void btnCloseBr_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string oldpass = dbcon.getPassword(lblUserName.Text);
                if (oldpass != txtCurPassword.Text)
                {
                    MessageBox.Show("Wrong password, please try again! ", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    txtCurPassword.Visible = false;
                    btnNext.Visible = false;

                    txtNewPass.Visible = true;
                    txtConPass.Visible = true;
                    btnSave.Visible = true;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPass.Text!=txtConPass.Text)
                {
                    MessageBox.Show("New password and Comfirm passsword did not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Change password?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        dbcon.ExcuteQuery("UPDATE tbUser set password ='" + txtNewPass.Text + "'Where username='" + lblUserName.Text + "'");
                        MessageBox.Show("Password has been succesfully update!", "Save Update", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
