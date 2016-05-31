using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        /*Atributos*/
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        /*Propiedades*/
        public float Duracion
        {
            get { return this._duracion; }
        }

        public string NroDestino
        {
            get { return this._nroDestino; }
        }

        public string NroOrigen
        {
            get { return this._nroOrigen; }
        }

        /*Constructor*/
        public Llamada(string Origen, string Destino, float Duracion)
        {
            this._nroOrigen = Origen;
            this._nroDestino = Destino;
            this._duracion = Duracion;
        }

        /*Métodos*/
        public void Mostrar()
        { }

        public int OrdenarPorDuracion(Llamada uno, Llamada dos)
        { }
    }
}
