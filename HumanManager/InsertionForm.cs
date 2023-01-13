using MySql.Data.MySqlClient;

namespace HumanManager
{
    public partial class InsertionForm : Form
    {
        private Form Mainform;

        public InsertionForm(Form Mainform)
        {
            InitializeComponent();
            this.Mainform = Mainform;
        }

        private void insertMensch(object sender, EventArgs e)
        {
            MySqlConnection connection = getConnection();
            progressBar1.Value = 33;
            MySqlCommand command = new MySqlCommand("insert into menschen (first_name, last_name, birthdate) values (\"" + textbox_first_name.Text + "\", \"" + textbox_last_name.Text + "\", \'" + textbox_birthdate.Text + "\')", connection);
            command.ExecuteNonQuery();
            progressBar1.Value = 66;
            closeConnection(connection);
            progressBar1.Value = 100;
        }

        private MySqlConnection getConnection()
        {
            string connectionString = "SERVER=localhost;DATABASE=menschendatenbank;UID=root;PASSWORD=uyJBgXdd5nMAT6qh;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        private void closeConnection(MySqlConnection connection)
        {
            connection.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            this.Mainform.Close();
        }
    }
}