using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploPROG
{
    public partial class Form1 : Form
    {
        #region Form1-Constructor
        public Form1()
        {
            InitializeComponent();
            lvwClientes.Columns.Add("DNI");
            lvwClientes.Columns.Add("Nombres");
            lvwClientes.Columns.Add("Apellidos");
            lvwClientes.Columns.Add("Edad");
            lvwClientes.Columns.Add("Tipos TV");
            lvwClientes.Columns.Add("Cuota Mensual");
            lvwClientes.Columns.Add("Cuota Inicial");
            lvwClientes.Columns.Add("Obs");

            ListViewItem itm, itm1, item2, item3;

            itm = new ListViewItem("LG");
            itm.SubItems.Add("0");
            lvwControl.Items.Add(itm);

            itm1 = new ListViewItem("Sony");
            itm1.SubItems.Add("0");
            lvwControl.Items.Add(itm1);

            item2 = new ListViewItem("Toshiba");
            item2.SubItems.Add("0");
            lvwControl.Items.Add(item2);

            item3 = new ListViewItem("Samsung");
            item3.SubItems.Add("0");
            lvwControl.Items.Add(item3);
        }
        #endregion

        #region cbTiposTV_SelectedIndexChanged
        private void cbTiposTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorCombo = cbTiposTV.Text;
            switch (valorCombo)
            {
                case "LG":
                    txtCuotaInicial.Text = "1200";
                    txtCuotaMensual.Text = "500";
                    break;
                case "Sony":
                    txtCuotaInicial.Text = "2200";
                    txtCuotaMensual.Text = "1200";
                    break;
                case "Toshiba":
                    txtCuotaInicial.Text = "1400";
                    txtCuotaMensual.Text = "700";
                    break;
                case "Samsung":
                    txtCuotaInicial.Text = "1700";
                    txtCuotaMensual.Text = "900";
                    break;
                default:
                    txtCuotaInicial.Text = "";
                    txtCuotaMensual.Text = "";
                    break;
            }
        }
        #endregion

        #region btnAdd_Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbTiposTV.Text == "")
            {
                MessageBox.Show("Selecciona un Tipo de TV", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtTiposTV.Text = cbTiposTV.Text;
                txtMensualidad.Text = txtCuotaMensual.Text;
                txtClienteCuotaInicial.Text = txtCuotaInicial.Text;
                txtNombres.Enabled = true;
                txtApellidos.Enabled = true;
                txtEdad.Enabled = true;
                mtbDNI.Enabled = true;
                txtObservacion.Enabled = true;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnAdd.Enabled = false;
                cbTiposTV.Enabled = false;
            }
        }
        #endregion

        #region Adicionar
        private void adicionar(String TiposTV)
        {
            int i = 0;
            foreach (ListViewItem itemAdicionar in lvwControl.Items)
            {
                if (itemAdicionar.SubItems[0].Text == TiposTV)
                {
                    lvwControl.BeginUpdate();
                    int nuevoValor = Convert.ToInt32(itemAdicionar.SubItems[1].Text);
                    nuevoValor = nuevoValor + 1;
                    lvwControl.Items[i].SubItems[1].Text = Convert.ToString(nuevoValor);
                    lvwControl.EndUpdate();
                }
                i++;
            }
        }
        #endregion

        #region btnGuardar_Click
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string[] arr = new string[8];
            ListViewItem itm;
            arr[0] = mtbDNI.Text;
            arr[1] = txtNombres.Text;
            arr[2] = txtApellidos.Text;
            arr[3] = txtEdad.Text;
            arr[4] = txtTiposTV.Text;
            arr[5] = txtMensualidad.Text;
            arr[6] = txtClienteCuotaInicial.Text;
            arr[7] = txtObservacion.Text;
            itm = new ListViewItem(arr);
            lvwClientes.Items.Add(itm);
            adicionar(txtTiposTV.Text);

        }
        #endregion

        #region btnCancelar_Click
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAdd.Enabled = true;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtObservacion.Enabled = false;
            txtEdad.Enabled = false;
            mtbDNI.Enabled = false;
            txtTiposTV.Clear();
            txtMensualidad.Clear();
            txtClienteCuotaInicial.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtObservacion.Clear();
            txtEdad.Clear();
            mtbDNI.Clear();
            txtObservacion.Clear();
            cbTiposTV.Enabled = true;
        }
        #endregion

    }
}