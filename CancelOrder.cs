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
    public partial class CancalOrder : Form
    {
        DailySale dailySale;
        public CancalOrder(DailySale sale)
        {
            InitializeComponent();
            dailySale = sale;
        }

        private void btnCloseBr_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCanOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbInventory.Text!=string.Empty && npdCancelQty.Value>0 && txtReasons.Text!=string.Empty)
                {
                    if (int.Parse(txtQty.Text)>=npdCancelQty.Value)
                    {
                        Void @void = new Void(this);
                        @void.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReasonSoldList()
        {
            dailySale.LoadSold();
        }

        private void cbInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
