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
using System.Collections.Specialized;

namespace WinForm
{
    public partial class ConfigSectionForm : Form
    {
        public ConfigSectionForm() {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e) {
            var x = ConfigurationManager.GetSection("jesseSection") as NameValueCollection;
            txtAttribute1.Text = x["processingDirectory"];
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
