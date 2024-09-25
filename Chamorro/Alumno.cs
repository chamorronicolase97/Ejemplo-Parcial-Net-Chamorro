using System.Data;

namespace Chamorro.Entidades
{
    public class Alumno
    {
        private string _apellidoNombre;
        private string _dni;
        private string _email;
        private decimal? _notaPromedio;
        private DateTime? _fechaNacimiento;        

        public string ApellidoNombre { get { return _apellidoNombre; } set { _apellidoNombre = value; } }
        public string DNI { get { return _dni; } set { _dni = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public DateTime? FechaNacimiento { get { return _fechaNacimiento;  } set { _fechaNacimiento = value; } }
        public decimal? NotaPromedio { get { return _notaPromedio; } set { _notaPromedio = value; } }

        readonly int Edad;

        public Alumno() { }

        public Alumno(DataRow dr)
        {
            _apellidoNombre = null;
            if (dr["ApellidoNombre"] != DBNull.Value) ApellidoNombre = (string)dr["ApellidoNombre"];
            _dni = null;
            if (dr["DNI"] != DBNull.Value) DNI = (string)dr["DNI"];
            _email = null;
            if (dr["Email"] != DBNull.Value) Email = (string)dr["Email"];
            _notaPromedio = null;
            if (dr["NotaPromedio"] != DBNull.Value) NotaPromedio = (decimal)dr["NotaPromedio"];
            _fechaNacimiento = null;
            if (dr["FechaNacimiento"] != DBNull.Value) FechaNacimiento = (DateTime)dr["FechaNacimiento"];

            Edad = DateTime.Compare(DateTime.Now, _fechaNacimiento ?? DateTime.Now);
        }

    }
}
