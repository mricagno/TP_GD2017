using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            /*if (System.Text.RegularExpressions.Regex.IsMatch(txtValorKm.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingresar solo numeros", "Uber", MessageBoxButtons.OK);
                txtValorKm.Text = txtValorKm.Text.Remove(txtValorKm.Text.Length - 1);
            }*/
        }

        private void txtPrecioBase_TextChanged(object sender, EventArgs e)
        {
            /*
          
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrecioBase.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingresar solo numeros", "Uber", MessageBoxButtons.OK);
                txtPrecioBase.Text = txtPrecioBase.Text.Remove(txtPrecioBase.Text.Length - 1);
            }*/
        }

        private void AltaTurno_Load(object sender, EventArgs e)
        {
            
            if(accion == "modificar"){
                this.Text = "Modificar turno";
                lblturno.Text = turno;

                var modificarTurno = Repositorio.infoTurno(turno);
                txtNombreTurno.Text = modificarTurno.Nombre;
                txtPrecioBase.Text = modificarTurno.PrecioBase.ToString();
                txtValorKm.Text = modificarTurno.ValorKm.ToString();
                txtHoraFin.Text = modificarTurno.HoraFin.ToString();
                txtHoraInicio.Text = modificarTurno.HoraInicio.ToString();
                if (modificarTurno.Habilitado == 1)
                    checkHabilitadoTurno.Checked = true;
                

            }else{
                this.Text = "Alta turno";
                lblturno.Text = "";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new Principal(Tabs.turnos()).Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var turnoDto = new DtoTurno();
                if (String.IsNullOrEmpty(txtNombreTurno.Text))
                {
                    MessageBox.Show("Debe ingresar nombre del turno", "Alta Turno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                turnoDto.Nombre = txtNombreTurno.Text;
                if (String.IsNullOrEmpty(txtHoraInicio.Text) || !Utils.IsDigitsOnly(txtHoraInicio.Text))
                {
                    MessageBox.Show("Debe ingresar hora inicio numerica", "Alta Turno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (String.IsNullOrEmpty(txtHoraFin.Text) || !Utils.IsDigitsOnly(txtHoraFin.Text))
                {
                    MessageBox.Show("Debe ingresar hora fin numerica", "Alta Turno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (String.IsNullOrEmpty(txtPrecioBase.Text) )
                {
                    MessageBox.Show("Debe ingresar precio base numerico", "Alta Turno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (String.IsNullOrEmpty(txtValorKm.Text) )
                {
                    MessageBox.Show("Debe ingresar valor km numerica", "Alta Turno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                turnoDto.HoraInicio = Convert.ToInt32(txtHoraInicio.Text);
                turnoDto.HoraFin = Convert.ToInt32(txtHoraFin.Text);


                try
                {
                    //turnoDto.PrecioBase = Convert.ToDecimal();
                    turnoDto.PrecioBase = float.Parse(txtPrecioBase.Text, CultureInfo.CurrentCulture.NumberFormat);

                }
                catch
                {
                    MessageBox.Show("Debe ingresar un precio base valido valido", "Turno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                try
                {
                    //turnoDto.ValorKm = Convert.ToDecimal(txtValorKm.Text);
                    turnoDto.ValorKm = float.Parse(txtValorKm.Text, CultureInfo.CurrentCulture.NumberFormat);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un valor km valido", "Turno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
               
               

                if( turnoDto.HoraInicio > turnoDto.HoraFin)
                {
                    MessageBox.Show("La hora fin debe ser mayor a la hora inicio", "Alta turno", MessageBoxButtons.OK);
                    return;
                }



                if (checkHabilitadoTurno.Checked == true)
                {
                    turnoDto.Habilitado = 1;
                }
                else
                {
                    turnoDto.Habilitado = 0;
                }

                if (accion == "modificar")
                {

                    Repositorio.modificarTurno(this.turno, turnoDto);


                    MessageBox.Show("Se modifico el turno correctamente", "Modificacion turno", MessageBoxButtons.OK);
                    new Principal(Tabs.turnos()).Show();
                    this.Close();


                }
                else
                {
                    Repositorio.altaTurno(turnoDto);
                    MessageBox.Show("Se creo el turno correctamente", "Alta turno", MessageBoxButtons.OK);
                    new Principal(Tabs.turnos()).Show();
                    this.Close();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Alta turno", MessageBoxButtons.OK);
                return;
            }

           
        }

        private void txtHoraInicio_TextChanged(object sender, EventArgs e)
        {
            
            /*
            if (System.Text.RegularExpressions.Regex.IsMatch(txtHoraInicio.Text, "[^0-9]") )
            {
                
                    if(txtHoraInicio.Text.Contains("."))
                    {
                        try{
                           txtHoraInicio.Text.Split('.')[1].ToString();
                        }
                         catch (Exception ex){
                            
                        }
                        MessageBox.Show("Por favor ingresar un solo punto", "Uber", MessageBoxButtons.OK);

                        txtHoraInicio.Text = txtHoraInicio.Text.Remove(txtHoraInicio.Text.Length - 1);
                        return;
                        
                    }
                   
                MessageBox.Show("Por favor ingresar solo numeros", "Uber", MessageBoxButtons.OK);
                txtHoraInicio.Text = txtHoraInicio.Text.Remove(txtHoraInicio.Text.Length - 1);
            
            }*/
        }

        private void txtHoraFin_TextChanged(object sender, EventArgs e)
        {
 
            if (System.Text.RegularExpressions.Regex.IsMatch(txtHoraFin.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingresar solo numeros", "Uber", MessageBoxButtons.OK);
                txtHoraFin.Text = txtHoraFin.Text.Remove(txtHoraFin.Text.Length - 1);
            }
        }

       

       
    }
}
