using KrRudov.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrRudov
{
    public partial class AuthorizationForm : Form
    {
        public static Workers User;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User = null;
            ModelEFClass db = new ModelEFClass();

            User = db.Workers.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (User != null)
            {
                switch (User.Role)
                {
                    case "Администратор":
                        MenuAdminForm menu = new MenuAdminForm();
                        menu.labelUserInfo.Text = $"Добро пожаловать\n{User.First_Name} {User.Second_Name} {User.Middle_Name}";
                        menu.Show();
                        this.Hide();
                        break;
                    case "Менеджер А":
                        MenuManagerForm menuManagerA = new MenuManagerForm();
                        menuManagerA.labelRole.Text = User.Role;
                        menuManagerA.labelUserInfo.Text = $"Добро пожаловать\n{User.First_Name} {User.Second_Name} {User.Middle_Name}";
                        menuManagerA.Show();
                        this.Hide();
                        break;
                    case "Менеджер С":
                        MenuManagerForm menuManagerC = new MenuManagerForm();
                        menuManagerC.labelRole.Text = User.Role;
                        menuManagerC.labelUserInfo.Text = $"Добро пожаловать\n{User.First_Name} {User.Second_Name} {User.Middle_Name}";
                        menuManagerC.Show();
                        Hide();
                        break;
                    case "Удален":
                        MessageBox.Show("Пользователь удален", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default: throw new Exception("Роль не найдена!");
                }
            }
            else MessageBox.Show("Пользователь не найден", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

