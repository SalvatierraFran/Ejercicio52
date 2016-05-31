using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local:Llamada
    {
        /*Atributo*/
        protected float _costo;
        //public Llamada llamadaUno;

        /*Propiedad*/
        public float Costo
        {
            get { return this._costo; }
        }

        /*Constructores*/
        public Local(Llamada unaLlamada, float Costo):base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            //this.llamadaUno = unaLlamada;
        }

        public Local(string Origen, float Duracion, string Destino, float Costo):base(Origen, Destino, Duracion)
        {
            this._costo = Costo;
        }

        /*Métodos*/
        private float CalcularCosto()
        { }

        public void Mostrar()
        { }
    }
}
