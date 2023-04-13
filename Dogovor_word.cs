using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dogovor
{
    public partial class Dogovor_word : Form
    {
        public Dogovor_word()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helper = new Word_settings("Договор оказания образовательных услуг.docx");

            var items = new Dictionary<string, string>
            {
                { "<ORG>", textBox_org.Text},
                { "<FIO>", textBox_fio.Text},
                { "<Date_Birth>", dateTimePicker1.Value.ToString("dd.MM.yyyy") },
                { "<Address>", textBox_address.Text},
                { "<Pass_Ser>", textBox_pass_series.Text},
                { "<Pass_Num>", textBox_pass_number.Text},
            };

            helper.Process(items);
        }
    }
}
