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

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;





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
            ConfigurarMapa();
        }

        private void ConfigurarMapa()
        {
            Mapa.ShowCenter = true;
            Mapa.DragButton = MouseButtons.Left;
            Mapa.CanDragMap = true;
            Mapa.MapProvider = GMapProviders.GoogleTerrainMap;
            Mapa.Position = new PointLatLng(-17.789754246881017, -63.17792107535372);
            Mapa.MinZoom = 1;
            Mapa.MaxZoom = 20;
            Mapa.Zoom = 13;
            Mapa.AutoScroll = true;
        }

        private void Mapa_MouseClick(object sender, MouseEventArgs e)
        {
            PointLatLng Punto = Mapa.FromLocalToLatLng(e.X, e.Y);
            Latitud.Text = Punto.Lat.ToString();
            Longitud.Text = Punto.Lng.ToString();
            Mapa.Overlays.Clear();
            GMapMarker M = new GMarkerGoogle(new PointLatLng(Punto.Lat, Punto.Lng), GMarkerGoogleType.pink);
            GMapOverlay O = new GMapOverlay();
            O.Markers.Add(M);
            Mapa.Overlays.Add(O);
            Mapa.Zoom = Mapa.Zoom + 0.1;
        }



        private void MostrarMarcador()
        {
            Mapa.Overlays.Clear();
            GMapMarker M = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Latitud.Text), Convert.ToDouble(Longitud.Text)), GMarkerGoogleType.pink);
            GMapOverlay O = new GMapOverlay();
            O.Markers.Add(M);
            Mapa.Overlays.Add(O);
            Mapa.Zoom = Mapa.Zoom + 0.1;
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
            MostrarMarcador();
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

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            Mapa.Overlays.Clear();
            GMapMarker Marcador;
            for (int V = 0; V < Dgv.Rows.Count - 1; V++)
            {
                if (Dgv[2, V].Value.ToString().ToUpper() == "HOMBRE")
                {
                    Marcador = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Dgv[3, V].Value), Convert.ToDouble(Dgv[4, V].Value)), GMarkerGoogleType.green);
                }
                else
                {
                    Marcador = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(Dgv[3, V].Value), Convert.ToDouble(Dgv[4, V].Value)), GMarkerGoogleType.pink);
                }
                Marcador.ToolTipText = Dgv[0, V].Value.ToString() + "\n" + Dgv[1, V].Value.ToString() + "\n" + Dgv[2, V].Value;
                GMapOverlay Obj = new GMapOverlay("Marcadores");
                Obj.Markers.Add(Marcador);
                Mapa.Overlays.Add(Obj);
                Mapa.Zoom = Mapa.Zoom + 0.1;
            }

        }

        private void BtnReportePdf_Click(object sender, EventArgs e)
        {
            // 1. Crear una ventana para que el usuario elija dónde guardar el PDF
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo PDF|*.pdf";
            guardar.Title = "Guardar Reporte de Clientes";
            guardar.FileName = "ReporteClientes.pdf";

            // 2. Si el usuario le da a "Guardar" y no cancela la ventana
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 3. Llamar a la BRL enviando la tabla y la ruta elegida por el usuario
                    ObjCli.ExportarAPdf(Dgv, guardar.FileName);
                    MessageBox.Show("Reporte PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
