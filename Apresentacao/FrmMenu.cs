using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            FrmClienteSelecionar frmClienteSelecionar = new FrmClienteSelecionar();
            frmClienteSelecionar.MdiParent = this;
            frmClienteSelecionar.Show();

        }

       
    }
}
