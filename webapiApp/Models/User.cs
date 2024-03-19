using Microsoft.EntityFrameworkCore;

namespace webapiApp.Models
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private int _edad;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public Usuario(int id, string nombre, string apellido, int edad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
    }
}