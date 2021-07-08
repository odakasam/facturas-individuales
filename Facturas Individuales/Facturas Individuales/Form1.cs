using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturas_Individuales
{
    public partial class ingresoFactura : Form
    {
        public object ClassFunciones { get; private set; }

        public ingresoFactura()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void datosCliente_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod;
            cod = comboProducto.SelectedIndex;   

            switch(cod)
            {
                case 0: 
                        lblID.Text = "12587655";
                        lblPrecio.Text = "699.990";
                        break;
                case 1: 
                        lblID.Text = "00248663";
                        lblPrecio.Text = "65.000";
                        break;
                case 2: 
                        lblID.Text = "52170012";
                        lblPrecio.Text = "69.000";  
                        break;
                case 3: 
                        lblID.Text = "55781039";
                        lblPrecio.Text = "69.000";
                        break;
                case 4: 
                        lblID.Text = "58774103";
                    lblPrecio.Text = "450.000";
                    break;
                case 5: 
                        lblID.Text = "21447120";
                    lblPrecio.Text = "45.000";
                    break;
                case 6: 
                        lblID.Text = "12358007";
                    lblPrecio.Text = "30.000";
                    break;
                case 7: 
                        lblID.Text = "14755147";
                    lblPrecio.Text = "150.000";
                    break;
                case 8: 
                        lblID.Text = "10039788";
                    lblPrecio.Text = "15.000";
                    break;
                case 9: 
                        lblID.Text = "12304788";
                    lblPrecio.Text = "20.000";
                    break;
                default: 
                        lblID.Text = "12058666";
                    lblPrecio.Text = "90.000";
                    break;
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // validar que se haya seleciconado un producto y que la cantidad sea mayor a cero




            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(tablaProductos);

            file.Cells[0].Value = lblID.Text;
            file.Cells[1].Value = comboProducto.Text;
            file.Cells[2].Value = lblPrecio.Text;
            file.Cells[3].Value = boxCantidad.Text;
            file.Cells[4].Value = (float.Parse(lblPrecio.Text) * float.Parse(boxCantidad.Text)).ToString();
            file.Cells[5].Value = (float.Parse(lblPrecio.Text) * float.Parse(boxCantidad.Text) * 0.19).ToString();
            file.Cells[6].Value = (float.Parse(lblPrecio.Text) * float.Parse(boxCantidad.Text) * 1.19).ToString();

            tablaProductos.Rows.Add(file);

            totalFactura();
        }

        public void totalFactura()
        {
            float costoTotal = 0;
            int contador = 0;

            contador = tablaProductos.RowCount;

            for(int i = 0; i < contador; i++)
            {
                costoTotal += float.Parse(tablaProductos.Rows[i].Cells[6].Value.ToString());
            }

            txtValor.Text = costoTotal.ToString();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult grabar = MessageBox.Show("¿Desea grabar esta factura?", "Grabar Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (grabar == DialogResult.Yes)
                {
                    MessageBox.Show("Factura Grabada","Grabar Factura");
                }
            }
            catch{}

            limpiarPantalla();
        }

        public void limpiarPantalla()
        {
            comboProducto.SelectedIndex = -1;
            boxNombre.Text = "";
            boxCantidad.Text = "";
            boxDireccion.Text = "";
            tablaProductos.Rows.Clear();
            boxFactura.Text = "";
            boxRut.Text = "";
            lblID.Text = "";
            lblPrecio.Text = "";
            txtValor.Text = "";
            dateFecha.Value = DateTime.Now;
            dateVencer.Value = DateTime.Now;
            boxDV.Text = "";
        }

        public static string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }

            private void resetFactura_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult limpiar = MessageBox.Show("¿Desea limpiar esta factura?", "Limpiar Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (limpiar == DialogResult.Yes)
                {
                    MessageBox.Show("Factura Limpiada");
                }
            }
            catch { }

            limpiarPantalla();
        }

        private void lblIVA_Click(object sender, EventArgs e)
        {

        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //Validar que RUT y DV no esten vacios
            if (boxRut.Text.Trim().Length  == 0)
            {
                MessageBox.Show("Debe ingresar un valor en el campo RUT");
                return;

            }

            if (boxDV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar un valor en el campo Digito Verificador");
                return;

            }

            // Validar numero del RUT contra el Digito Verificador
            int rut;
            string dvIngresado;
            rut = int.Parse(boxRut.Text);
            dvIngresado = boxDV.Text;

            string dvCalculado;
            dvCalculado = Digito(rut);

            if(dvCalculado != dvIngresado)
            {
                MessageBox.Show("El RUT " + boxRut.Text + " - " +boxDV.Text + " no es válido");
                return;
            }

            switch (rut)
            {
                case 13211056: //13211056-5
                    boxNombre.Text = "Juan Perez";
                    boxDireccion.Text = "Alameda #12345";
                    break;
                case 11830936: // 11830936-7
                    boxNombre.Text = "Pedro Gonzalez";
                    boxDireccion.Text = "Teatinos  #500";
                    break;
                case 14941142: // 14941142-9
                    boxNombre.Text = "Maria Flores";
                    boxDireccion.Text = "Arturo Prat  #1234";
                    break;
                default:
                    boxNombre.Text = "";
                    boxDireccion.Text = "";
                    MessageBox.Show("RUT " + boxRut.Text + "-" +boxDV.Text + " no está registrado como cliente.");
                    break;
            }
        }

        private void btnBuscarCliente_MouseMove(object sender, MouseEventArgs e)
        {
            btnBuscarCliente.BackColor = Color.Blue;
        }

        private void btnBuscarCliente_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarCliente.BackColor = Color.LightGray;
        }

        private void boxRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void boxDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString().ToUpper() == "K") //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void boxDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
             if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
