using BRL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        CClientes ObjCli = new CClientes();
        private void Form1_Load(object sender, EventArgs e)
        {
            Codigo.Text = ObjCli.SiguienteCodigo(Dgv);
            ObjCli.Mostrar(Dgv);
        }

        private void ConfigurarMapa()
        {

        }










        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            ObjCli.Buscar(Dgv,Buscar.Text);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Gen = ObjCli.ObtGenero(Op1, Op2);
            ObjCli.Guardar(Nombre.Text, Gen, Convert.ToDouble(Latitud.Text), 
                Convert.ToDouble(Longitud.Text));

            Codigo.Text = ObjCli.SiguienteCodigo(Dgv);
            ObjCli.Mostrar(Dgv);
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int Fila;
        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fila = e.RowIndex;
            ObjCli.SubirDatos(Fila, Dgv, Codigo, Nombre, Op1, Op2, Latitud, Longitud);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string Gen = ObjCli.ObtGenero(Op1, Op2);
            ObjCli.Modificar(Convert.ToInt32(Codigo.Text), 
                Nombre.Text, Gen, Convert.ToDouble(Latitud.Text),
                Convert.ToDouble(Longitud.Text));

            Codigo.Text = ObjCli.SiguienteCodigo(Dgv);
            ObjCli.Mostrar(Dgv);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ObjCli.Eliminar(Convert.ToInt32(Codigo.Text));

            Codigo.Text = ObjCli.SiguienteCodigo(Dgv);
            ObjCli.Mostrar(Dgv);
        }
    }
}
