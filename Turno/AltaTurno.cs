using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Backend;

namespace UberFrba.Turno
{
    public partial class AltaTurno : Form
    {
        String accion;
        String turno;
        public AltaTurno()
        {
            InitializeComponent();
        }

        public AltaTurno(String unTurno, String unaAccion)
        {
            InitializeComponent();
            accion = unaAccion;
            turno = unTurno;

        }

        private void txtValorKm_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValorKm.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingresar solo numeros", "Uber", MessageBoxButtons.OK);
                txtValorKm.Text = txtValorKm.Text.Remove(txtValorKm.Text.Length - 1);
            }
        }

        private void txtPrecioBase_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrecioBase.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingresar solo numeros", "Uber", MessageBoxButtons.OK);
                txtPrecioBase.Text = txtPrecioBase.Text.Remove(txtPrecioBase.Text.Length - 1);
            }
        }

        private void AltaTurno_Load(object sender, EventArgs e)
        {
            
            if(accion == "modificar"){
                this.Text = "Modificar turno";

                //traer el turno de la db
                //setear valores en los combos
            }else{
                this.Text = "Alta turno";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.turnos()).Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(accion== "modificar"){
                //modificar el turno
                MessageBox.Show("Se modifico el turno correctamente", "Modificacion turno", MessageBoxButtons.OK);
                new Principal(Tabs.turnos()).Show();
                this.Close();


            }else{
                //agregar nuevo turno
                MessageBox.Show("Se creo el turno correctamente", "Alta turno", MessageBoxButtons.OK);
                new Principal(Tabs.turnos()).Show();
                this.Close();

            }
        }

       
    }
}
