using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ReportIt.Model
{
    public class Tbl_Violencia
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Lugar { get; set; }
        public bool Personal { get; set; }
        public string Descripcion { get; set; }
        public string Pruebas { get; set; }
    }
}
