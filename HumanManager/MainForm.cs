using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatingForm form = new UpdatingForm(this);
            form.ShowDialog();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertionForm form = new InsertionForm(this);
            form.ShowDialog();
        }
    }
}