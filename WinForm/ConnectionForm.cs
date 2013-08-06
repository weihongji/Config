using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace WinForm
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm() {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e) {
            txtBloggingConnectionString.Text = ConfigurationManager.ConnectionStrings["Blogging"].ConnectionString;
            txtCustomConnectionString.Text = ConfigurationManager.ConnectionStrings["Custom"].ConnectionString;
            txtAppSetting1.Text = ConfigurationManager.AppSettings["setting1"];
            txtAppSetting2.Text = ConfigurationManager.AppSettings["setting2"];
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnTest_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtBloggingConnectionString.Text)) {
                //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder() {
                //    DataSource = ".\\SQL2008",
                //    InitialCatalog = "Custom",
                //    UserID = "sa",
                //    Password = "5118765"
                //};
                //txtConnectionString.Text = builder.ConnectionString;

                txtBloggingConnectionString.Text = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            }

            SqlConnection connection = new SqlConnection(txtBloggingConnectionString.Text);
            try {
                this.Cursor = Cursors.WaitCursor;
                connection.Open();
                connection.Close();
                MessageBox.Show("Connection opened successfully!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to open connection:\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally {
                this.Cursor = this.DefaultCursor;
            }
        }
    }
}
