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

namespace Dogovor
{
    public partial class Form1 : Form
    {
        int count;
        DataBase db = new DataBase();
        Com_variables com_Variables = new Com_variables();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count < 3)
            {
                try
                {
                    DataTable users = db.ExecuteSql($"select * from users where login = '{textBox_log.Text}' and password = '{textBox_pass.Text}'");
                    if (users.Rows.Count > 0)
                    {
                        MessageBox.Show("Вы успешно вошли!");
                        com_Variables.Login = textBox_log.Text;
                    }
                    else
                    {
                        MessageBox.Show($"Вы ввели неправильного пользователя, у Вас осталось {3 - count} попытки");
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так");
                }
            }
            else
            {
                MessageBox.Show("Похоже, Вы забыли пароль, предлагаю поменять пароль!");
                NewPassword newPassword = new NewPassword();
                newPassword.Show();
                this.Hide();
            }
        }
    }
}

