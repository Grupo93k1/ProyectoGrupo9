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
    }
}
