using ProyectoGrupo9.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo9.Clases
{
    class Turno
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "select * from Turnos where borrado = 0 ORDER BY 2, 3";

            //BDHelper oDatos = new BDHelper();
            return BDHelper.GetDBHelper().ConsultaSQL(consulta);
        }
        public DataTable RecuperarFiltrados2(string desde, string hasta, string medico)
        {
            string consulta = "SELECT * From Turnos t " +
                "where t.borrado = 0 ";

            consulta += " AND t.fecha BETWEEN '" + desde + "' AND '" + hasta + "'";
            if (medico != string.Empty)
                consulta += " AND t.medico ='" + medico + "'";



            //return BDHelper2.GetDBHelper().ConsultaSQL(consulta);
            //BDHelper oDatos = new BDHelper();

            //return BDHelper.obtenerInstancia().consultar(consulta);
            return Datos.Datos.obtenerInstancia().consultar(consulta);
        }
    }
}
