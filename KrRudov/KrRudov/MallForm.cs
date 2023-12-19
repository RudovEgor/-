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
    public partial class MallForm : Form
    {
        public static ModelEFClass db = new ModelEFClass();
        public Mall CurrentMall { get; set; }
        public MallForm(Mall currentMall)
        {
            InitializeComponent();
            CurrentMall = currentMall;
        }

        private void MallForm_Load(object sender, EventArgs e)
        {
            dataGridViewMall.DataSource = db.Mall.ToList();
            if (db.Mall.ToList().Count == 0)
            {
                return;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuManagerForm menu = new MenuManagerForm(); 
            menu.Show();
            Close();
        }
    }
}
