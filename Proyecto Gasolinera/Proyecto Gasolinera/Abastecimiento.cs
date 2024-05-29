using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gasolinera
{
    internal class Abastecimiento
    {
        private Cliente cliente;
        private DateTime fecha;
        private string fecha2;
        private string tipo;
        private double cantidad;
        private double precio;
        private int bomba;
        private Abastecimiento siguiente;
        public Abastecimiento()
        {
            this.cliente = null;
            this.fecha = DateTime.Now;
            this.fecha2 = fecha.ToString("dd/MM/yyyy");
            this.tipo = "";
            this.cantidad = 0;
            this.precio = 0;
            this.bomba = 0;
            this.siguiente = null;
        }

        internal Cliente Cliente { get => cliente; set => cliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Fecha2 { get => fecha2; set => fecha2 = value; }
        public Abastecimiento Siguiente { get => siguiente; set => siguiente = value; }

        public string Tipo { get => tipo; set => tipo = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Bomba { get => bomba; set => bomba = value; }

    }
}
