using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace BRL
{
    public class CClientes
    {
        CAcceso ObjAcc = new CAcceso();
        public void Mostrar(DataGridView Dgv)
        {
            Dgv.DataSource = ObjAcc.TraerDataTable("SPMOSTRARCLIENTES");
        }
        public void Buscar(DataGridView Dgv, string Nom)
        {
            Object[] P = new object[] { Nom};
            Dgv.DataSource = ObjAcc.TraerDataTable("SPBUSCARCLIENTES", P);
        }

        public string SiguienteCodigo(DataGridView Dgv)
        {
            Dgv.DataSource = ObjAcc.TraerDataTable("SpSiguienteCodigoCliente");
            return Dgv[0, 0].Value.ToString();
        }
        public string ObtGenero(RadioButton Op1, RadioButton Op2)
        {
            if (Op1.Checked)
                return Op1.Text;
            else
                return Op2.Text;
        }
        public void Guardar(string Nom, string Gen, double Lat, double Lon)
        {
            Object[] P = new object[] { Nom, Gen, Lat, Lon };
            ObjAcc.Ejecutar("SPInsertarCliente", P);
        }
        public void SubirDatos(int Fila, DataGridView Dgv, Label Cod, 
            TextBox Nom, RadioButton Op1, RadioButton Op2, TextBox Lat, 
            TextBox Lon)
        {
            Cod.Text = Dgv[0, Fila].Value.ToString();
            Nom.Text = Dgv[1, Fila].Value.ToString();
            if (Dgv[2, Fila].Value.ToString().ToUpper() == "HOMBRE")
                Op1.Checked = true;
            else
                Op2.Checked = true;
            Lat.Text = Dgv[3, Fila].Value.ToString();
            Lon.Text = Dgv[4, Fila].Value.ToString();
        }
        public void Modificar(int Cod, string Nom, string Gen, double Lat, double Lon)
        {
            Object[] P = new object[] {Cod,Nom, Gen, Lat, Lon };
            ObjAcc.Ejecutar("SpModificaCliente", P);
        }
        public void Eliminar(int Cod)
        {
            Object[] P = new object[] { Cod };
            ObjAcc.Ejecutar("SpEliminaCliente", P);
        }



        public void ExportarAPdf(DataGridView Dgv, string rutaArchivo)
        {
            // 1. Crear el formato del documento (Tamaño A4, y márgenes)
            Document doc = new Document(PageSize.A4, 25, 25, 30, 30);

            // 2. Crear el escritor que enlazará el documento con el disco duro (rutaArchivo)
            PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));

            // 3. Abrir el documento para empezar a escribir
            doc.Open();

            // 4. Agregar un título centrado
            Paragraph titulo = new Paragraph("Reporte de Clientes", FontFactory.GetFont("Arial", 18, Font.BOLD));
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            doc.Add(new Chunk("\n")); // Salto de línea

            // 5. Crear la Tabla del PDF basándonos en la cantidad de columnas del DataGridView
            PdfPTable tabla = new PdfPTable(Dgv.Columns.Count);
            tabla.WidthPercentage = 100; // Que ocupe todo el ancho de la hoja

            // 6. Extraer los títulos de las columnas del DataGridView
            for (int j = 0; j < Dgv.Columns.Count; j++)
            {
                PdfPCell celda = new PdfPCell(new Phrase(Dgv.Columns[j].HeaderText, FontFactory.GetFont("Arial", 10, Font.BOLD)));
                celda.BackgroundColor = BaseColor.LIGHT_GRAY; // Fondo gris para el encabezado
                celda.HorizontalAlignment = Element.ALIGN_CENTER;
                tabla.AddCell(celda);
            }

            // 7. Extraer los datos de cada cliente fila por fila
            for (int i = 0; i < Dgv.Rows.Count - 1; i++) // -1 para no leer la fila vacía del final
            {
                for (int j = 0; j < Dgv.Columns.Count; j++) // Recorremos cada columna
                {
                    if (Dgv.Rows[i].Cells[j].Value != null)// Verificamos que el valor no sea nulo
                    {
                        PdfPCell celda = new PdfPCell(new Phrase(Dgv.Rows[i].Cells[j].Value.ToString(), FontFactory.GetFont("Arial", 9)));
                        tabla.AddCell(celda);
                    }
                }
            }

            // 8. Insertar la tabla completa y cerrar el documento
            doc.Add(tabla);
            doc.Close();
        }



    }
}





