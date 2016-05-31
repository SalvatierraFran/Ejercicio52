using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial:Llamada
    {
        /*Atributo*/
        protected Franja _franjaHoraria;

        /*Propiedades*/
        public float CostoLlamada
        {
            get { return; }
        }

        /*Constructores*/
        public Provincial(Franja mFranja, Llamada unaLlamada):base(unaLlamada.Duracion, unaLlamada.NroDestino, unaLlamada.NroOrigen)
        {
            this._franjaHoraria = mFranja;
        }

        public Provincial(string Origen, Franja mFranja, float Duracion, string Destino):base(Origen, Destino, Duracion)
        {
            this._franjaHoraria = mFranja;
        }

        /*Métodos*/
        private float CalcularCosto()
        { }

        public void Mostrar()
        { }
    }
}
