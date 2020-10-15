using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmuebles
{
    public partial class Inmobiliaria : Form
    {
        int ventanas, nropiso, años, metroscuadrados;
        double precio;
        bool validarcampo;

        public Inmobiliaria()
        {
            InitializeComponent();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            Local Negocio = new Local();
            validarcampo = Utiles.validarCampo(txtPrecio.Text, "float");
            if (validarcampo)
            {
                validarcampo = Utiles.validarCampo(txtMetros.Text, "int");
                if (validarcampo)
                {
                    if (comboBoxAÑOS.SelectedIndex > -1)
                    {

                        if (comboBoxAÑOS.SelectedIndex == 0)
                        {
                            años = 14;
                        }
                        if (comboBoxAÑOS.SelectedIndex == 1)
                        {
                            años = 15;
                        }

                        precio = Convert.ToInt32(txtPrecio.Text);
                        metroscuadrados = Convert.ToInt32(txtMetros.Text);

                        if (radiobtnventana1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                        {
                            MessageBox.Show("Debe seleccionar una opción de VENTANAS, por favor corrija.", "ERROR");
                        }
                        else
                        {
                            if (radiobtnventana1.Checked == true)
                            {
                                ventanas = 1;
                                MessageBox.Show("Precio Final: $" + Negocio.Calcular(precio, años, metroscuadrados, ventanas) + "\nDirección: " + txtDirec.Text + "\nMetros Cuadrados: " + txtMetros.Text + "\nNúmero de Piso: " + comboBoxPISO.SelectedItem + "\nAños de Antiguedad: " + comboBoxAÑOS.SelectedItem + "\nEstado: " + comboBoxUSADO.SelectedItem + "\nCantidad de ventanas: " + radiobtnventana1.Text, "CÁLCULO DE LOCAL");
                            }
                            if (radioButton2.Checked == true)
                            {
                                ventanas = 3;
                                MessageBox.Show("Precio Final: $" + Negocio.Calcular(precio, años, metroscuadrados, ventanas) + "\nDirección: " + txtDirec.Text + "\nMetros Cuadrados: " + txtMetros.Text + "\nNúmero de Piso: " + comboBoxPISO.SelectedItem + "\nAños de Antiguedad: " + comboBoxAÑOS.SelectedItem + "\nEstado: " + comboBoxUSADO.SelectedItem + "\nCantidad de ventanas: " + radioButton2.Text, "CÁLCULO DE LOCAL");
                            }
                            if (radioButton3.Checked == true)
                            {
                                ventanas = 5;
                                MessageBox.Show("Precio Final: $" + Negocio.Calcular(precio, años, metroscuadrados, ventanas) + "\nDirección: " + txtDirec.Text + "\nMetros Cuadrados: " + txtMetros.Text + "\nNúmero de Piso: " + comboBoxPISO.SelectedItem + "\nAños de Antiguedad: " + comboBoxAÑOS.SelectedItem + "\nEstado: " + comboBoxUSADO.SelectedItem + "\nCantidad de ventanas: " +radioButton3.Text, "CÁLCULO DE LOCAL");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una opción de AÑOS DE ANTIGUEDAD, por favor corrija.", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Ingreso un valor erróneo en el campo METROS CUADRADOS, por favor corrija.", "ERROR");

                }
                }
                else
                {
                    MessageBox.Show("Ingreso un valor erróneo en el campo PRECIO, por favor corrija.", "ERROR");
                } 
        }

        private void btnPiso_Click(object sender, EventArgs e)
        {
            Piso Departamento = new Piso();
            validarcampo = Utiles.validarCampo(txtPrecio.Text, "float");
            if (validarcampo)
            {
                validarcampo = Utiles.validarCampo(txtMetros.Text, "int");
                if (validarcampo)
                {
                    if (comboBoxAÑOS.SelectedIndex > -1)
                    {

                        if (comboBoxAÑOS.SelectedIndex == 0)
                        {
                            años = 14;
                        }
                        if (comboBoxAÑOS.SelectedIndex == 1)
                        {
                            años = 16;
                        }

                        precio = Convert.ToInt32(txtPrecio.Text);

                        if (comboBoxPISO.SelectedIndex > -1)
                        {
                            if (comboBoxPISO.SelectedIndex == 0)
                            {
                                nropiso = 1;
                            }
                            else
                            {
                                if (comboBoxPISO.SelectedIndex == 1)
                                {
                                    nropiso = 4;
                                }
                            }
                            precio = Convert.ToInt32(txtPrecio.Text);

                            if (radiobtnventana1.Checked == true)
                            {
                                ventanas = 1;
                                MessageBox.Show("Precio Final: $" + Departamento.Calcular(precio, años, nropiso, metroscuadrados) + "\nDirección: " + txtDirec.Text + "\nMetros Cuadrados: " + txtMetros.Text + "\nNúmero de Piso: " + comboBoxPISO.SelectedItem + "\nAños de Antiguedad: " + comboBoxAÑOS.SelectedItem + "\nEstado: " + comboBoxUSADO.SelectedItem + "\nCantidad de ventanas: " + radiobtnventana1.Text, "CÁLCULO DE PISO");
                            }
                            if (radioButton2.Checked == true)
                            {
                                ventanas = 3;
                                MessageBox.Show("Precio Final: $" + Departamento.Calcular(precio, años, nropiso, metroscuadrados) + "\nDirección: " + txtDirec.Text + "\nMetros Cuadrados: " + txtMetros.Text + "\nNúmero de Piso: " + comboBoxPISO.SelectedItem + "\nAños de Antiguedad: " + comboBoxAÑOS.SelectedItem + "\nEstado: " + comboBoxUSADO.SelectedItem + "\nCantidad de ventanas: " + radioButton2.Text, "CÁLCULO DE PISO");
                            }
                            if (radioButton3.Checked == true)
                            {
                                ventanas = 5;
                                MessageBox.Show("Precio Final: $" + Departamento.Calcular(precio, años, nropiso, metroscuadrados) + "\nDirección: " + txtDirec.Text + "\nMetros Cuadrados: " + txtMetros.Text + "\nNúmero de Piso: " + comboBoxPISO.SelectedItem + "\nAños de Antiguedad: " + comboBoxAÑOS.SelectedItem + "\nEstado: " + comboBoxUSADO.SelectedItem + "\nCantidad de ventanas: " + radioButton3.Text, "CÁLCULO DE PISO");
                            }


                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar una opcion de PISO, por favor corrija.", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una opción de AÑOS DE ANTIGUEDAD, por favor corrija.", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Ingreso un valor erróneo en el campo METROS CUADRADOS, por favor corrija.", "ERROR");
                }
                }
                else
                {
                    MessageBox.Show("Ingreso un valor erróneo en el campo PRECIO, por favor corrija.", "ERROR");
                }
            }
       private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
