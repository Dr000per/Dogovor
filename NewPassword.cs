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
using System.Text.RegularExpressions;

namespace Dogovor
{
    public partial class NewPassword : Form
    {
        DataBase db = new DataBase();
        public NewPassword()
        {
            InitializeComponent();
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {
            button_accept.Enabled = false;
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            DataTable dt = db.ExecuteSql($"select * from users where login = '{textBox_log.Text}'");
            string pattern = @"^[a-zA-Z0-9]\d{3}$"; // ^[a-zA-Z0-9@,!?]{8,}$
            try
            {
                if (dt.Rows.Count > 0 && /*Regex.IsMatch(textBox_new_pass.Text, pattern) &&*/ textBox_new_pass.Text.Length > 15)
                {
                    db.ExecuteSqlNonQuery($"update users set password = '{textBox_new_pass.Text}' where login = '{textBox_log.Text}'");
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        private void textBox_new_pass_TextChanged(object sender, EventArgs e)
        {
            if (textBox_new_pass.Text.Contains("@") & textBox_new_pass.Text.Contains("%") & textBox_new_pass.Text.Contains("#") & textBox_new_pass.Text.Contains(".") & textBox_new_pass.Text.Contains("(") & textBox_new_pass.Text.Contains(")") & textBox_new_pass.Text.Contains("<"))
            {
                button_accept.Enabled = true;
            }
            else
            {
                button_accept.Enabled = false;
            }
        }
    }
}
