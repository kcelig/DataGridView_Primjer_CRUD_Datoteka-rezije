using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridView_Primjer_CRUD_Datoteka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtRezija.Text.Trim().Equals("")) {
                MessageBox.Show("Niste unijeli režiju!", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtIznos.Text.Trim().Equals(""))
            {
                MessageBox.Show("Niste unijeli iznos!", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
