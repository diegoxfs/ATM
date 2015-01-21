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
    public partial class opcion : Form
    {

        private Saldo objSaldo = null;
        public opcion(ref Saldo newSaldo)
        {
            objSaldo = newSaldo;
            InitializeComponent();
            
        }

        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su saldo es de: " + objSaldo.saldoTotal);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            string retiro = txtRetirar.Text;
            if (retiro != " " || retiro!=null )
            {
                double elRetiro = Convert.ToDouble(retiro);
         
                    if (elRetiro < objSaldo.saldoTotal)
                    {
                        objSaldo.saldoTotal -= elRetiro;
                    }
                    else
                    {
                        MessageBox.Show("Fondos insuficientes");
                    }
                
            }
            else {
                MessageBox.Show("Ingrese un numero por favor");
            }
            
        }
    }
}
