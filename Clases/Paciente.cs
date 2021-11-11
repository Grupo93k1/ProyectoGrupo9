using ProyectoGrupo9.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo9.Clases
{
    class Paciente
    {
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public string Calle { get; set; }
        public int Ciudad { get; set; }
        public int Obra_social { get; set; }
        public bool Borrado { get; set; }
        public int Id_Paciente { get; set; }
        public string Mail { get; set; }
        public int Altura_Calle { get; set; }
        public int Provincia { get; set; }

        public DataTable RecuperarTodos()
        {
            string consulta = "select * from Pacientes where borrado = 0 ORDER BY 2";

            //BDHelper oDatos = new BDHelper();
            return BDHelper.GetDBHelper().ConsultaSQL(consulta);
        }
        public DataTable RecuperarFiltrados(string DNI)
        {
            string consulta = "select * from Pacientes where borrado = 0  and dni =" + DNI;

            //BDHelper oDatos = new BDHelper();
            return BDHelper.GetDBHelper().ConsultaSQL(consulta);
        }
        public DataTable RecuperarEstadistica()
        {
            string consulta = "Select o.nombre, count(p.nombre) as 'CantidadPacientes' from Pacientes p join ObraSocial o on (p.obra_social = o.nombre) group by o.nombre" ;

            //BDHelper oDatos = new BDHelper();
            return BDHelper.GetDBHelper().ConsultaSQL(consulta);
        }
        public DataTable RecuperarFiltrados2(string nombre, string apellido, string DNI, string ciudad, string obraSocial)
        {
            string consulta = "SELECT * From Pacientes p " +
                "where p.borrado = 0 ";


            if (nombre != string.Empty)
                consulta += " AND (p.nombre ='" + nombre + "'";
            if (apellido != "")
                consulta += " or p.apellido= '" + apellido + "'";
            if (DNI != "")
                consulta += " or p.DNI=" + DNI;
            if (ciudad != string.Empty)
                consulta += " or p.ciudad ='" + ciudad + "'";
            if (obraSocial != "")
                consulta += " or p.obra_social= '" + obraSocial + "')";


            //return BDHelper2.GetDBHelper().ConsultaSQL(consulta);
            //BDHelper oDatos = new BDHelper();

            //return BDHelper.obtenerInstancia().consultar(consulta);
            return Datos.Datos.obtenerInstancia().consultar(consulta);
        }

    }
}
