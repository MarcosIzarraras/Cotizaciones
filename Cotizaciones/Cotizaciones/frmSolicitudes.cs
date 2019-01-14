﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizaciones
{
    public partial class frmSolicitudes : Form
    {
        public frmSolicitudes()
        {
            InitializeComponent();
            cargarDatosDefault();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            generarSolicitudGuardar();
            generarSolicitudDetallesGuardar();
            if (ProcedimientoGuardado.guardar()) MessageBox.Show("Solicitud guardada correctamente", "SOLICITUDES", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else MessageBox.Show("Error al guardar solicitud, Verifique la informacion", "SOLICITUDES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            limpiar();
        }
        private void cargarDatosDefault()
        {
            //DATOSO USUARIO
            Departamento departamento = new Departamento(Secion.departamento);
            lblNumeroEmpleado.Text = Secion.numeroEmpleado.ToString();
            lblSolicitante.Text = Secion.nombre;
            lblDepartamento.Text = departamento.nombre;

            //CARGAMOS PEDIDO
            cmbTipoPedido.DisplayMember = "tPed_nombre";
            cmbTipoPedido.ValueMember = "tPed_id";
            cmbTipoPedido.DataSource = TipoDePedidos.obtenerDatosPedido();

            //CARGAMOS COMPRADORES
            cmbComprador.DisplayMember = "usu_usuario";
            cmbComprador.ValueMember = "usu_id";
            cmbComprador.DataSource = new Usuario().obtenerCompradores();
        }

        private void frmSolicitudes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void agregarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvDetalles.Rows.Add();
            dgvDetalles.Rows[index].Cells["No"].Value = (index + 1);
        }

        private void eliminarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvDetalles.SelectedRows)
            {
                dgvDetalles.Rows.Remove(fila);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void generarSolicitudGuardar()
        {
            Solicitud solicitud = new Solicitud();

            solicitud.cotizador = Convert.ToInt32(cmbComprador.SelectedValue);
            solicitud.estatus = 1;
            solicitud.solicitante = Secion.id;
            solicitud.tipoPedido = Convert.ToInt32(cmbTipoPedido.SelectedValue);
            ProcedimientoGuardado.agregarClase(solicitud);
        }
        private void generarSolicitudDetallesGuardar()
        {
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                SolicitudDetalle detalle = new SolicitudDetalle();
                detalle.cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                detalle.descripcion = fila.Cells["Descripcion"].Value.ToString();
                detalle.estacionTrabajo = fila.Cells["CeldaMaquina"].Value.ToString();
                detalle.modelo = fila.Cells["Modelo"].Value.ToString();
                detalle.rutaDibujo = (fila.Cells["Archivo"].Value != null) ? fila.Cells["Archivo"].Value.ToString() : "";
                detalle.urgente = false;

                ProcedimientoGuardado.agregarClase(detalle);
            }
        }
        private void limpiar()
        {
            dgvDetalles.Rows.Clear();
        }
    }
}
