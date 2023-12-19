using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KrRudov.ModelEF;

namespace KrRudov
{
    public partial class TenantsForm : Form
    {
        private ModelEFClass db = new ModelEFClass();
        public TenantsForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuAdminForm menu = new MenuAdminForm();
            menu.Show();
            Close();
        }

        private void TenantsForm_Load(object sender, EventArgs e)
        {
            dataGridViewTenants.DataSource = db.Tenants.ToList();
            if (db.Tenants.ToList().Count==0)
            {
                return;
            }
        }
    }
}
