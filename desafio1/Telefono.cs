using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Telefono
    {
        public Telefono(string modelo, string marca)
        { 
            this.Modelo = modelo;
            this.Marca = marca;
        }
        public Telefono() { }
        
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        public string Modelo { get; }
        public string Marca { get; }
        public string NumeroTelefonico { get; set; }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if(value == 1 || value == 2 || value == 3) 
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

        public string llamar()
        {
            return "Realizando llamada...";
        }

        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }
    }
}
