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
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        MainMenu main;
        public UserAccount(MainMenu menu)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            main = menu;
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[3].ToString(), dr[4].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAccSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCAPassword.Text!=txtCARetypePass.Text)
                {
                    MessageBox.Show("Re-type Password did not match with Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("Insert into tbUser(username, password, role, name) Values (@username, @password, @role, @name)", cn);
                cm.Parameters.AddWithValue("@username", txtCAUserName.Text);
                cm.Parameters.AddWithValue("@password", txtCAPassword.Text);
                cm.Parameters.AddWithValue("@role", cbRole.Text);
                cm.Parameters.AddWithValue("@name", txtCAFName.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New account succesfuly saved", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Clear()
        {
            txtCAUserName.Clear();
            txtCAPassword.Clear();
            txtCARetypePass.Clear();
            txtCAFName.Clear();
            cbRole.Text = "";
            txtCAUserName.Focus();
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnPassSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCPPass.Text != main._pass)
                {
                    MessageBox.Show("Current password did not martch!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtCPNPass.Text!=txtCPReTypePass.Text)
                {
                    MessageBox.Show("New password did not martch to Re-type password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dbcon.ExcuteQuery("UPDATE tbUser SET password = '" + txtCPNPass.Text+"' WHERE username = '" + lblUserName.Text + "'");
                MessageBox.Show("Password has been successfully changed!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            lblUserName.Text = main.lblUsername.Text;
        }

        private void btnPassCancel_Click(object sender, EventArgs e)
        {
            ClearCP();
        }
        public void ClearCP()
        {
            txtCPPass.Clear();
            txtCPNPass.Clear();
            txtCPReTypePass.Clear();
        }
    }
}
