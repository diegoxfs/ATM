using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace atm
{
    public partial class frmMain : Form
    {

        private Saldo objSaldo;

        public frmMain()
        {
            InitializeComponent();
            objSaldo = new Saldo();
            objSaldo.saldoTotal = 1000;
        }

        // Event Handler
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string strCardNumber = txtCardNumber.Text;
            string strPinCode = txtPIN.Text;

            if (strCardNumber == "123")
            {
                if (strPinCode == "456")
                {
                    opcion opt = new opcion(ref objSaldo);
                    opt.Show();
                }
            }
            else {
                MessageBox.Show("La clave no es correcta");
            }
        }
    }
}
