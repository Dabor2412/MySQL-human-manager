using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;

namespace HumanManager
{
    public partial class UpdatingForm : Form
    {
        private Form MainForm;
        public UpdatingForm(Form MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
        }

        private void updateButton_onClick(object sender, EventArgs e)
        {
            Databasemanager connector = new Databasemanager();
            MySqlConnection connection = connector.getConnection();
            progressBar1.Value = 33;

            string query = "update menschen set first_name = @first_name, last_name = @last_name, birthdate = @birthdate where id = @id";
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            command.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            command.Parameters.AddWithValue("@first_name", textBox2.Text);
            command.Parameters.AddWithValue("@last_name", textBox3.Text);
            command.Parameters.AddWithValue("@birthdate", textBox4.Text);
            
            progressBar1.Value = 66;
            connection.Close();
            progressBar1.Value = 100;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            this.MainForm.Close();
        }
    }
}
