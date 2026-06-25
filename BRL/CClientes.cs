using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}





