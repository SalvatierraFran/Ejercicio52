using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        /*Atributos*/
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        /*Propiedades*/
        public float GananciaPorLocal
        {
            get { return; }
        }

        public float GananciaPorProvincial
        {
            get { return; }
        }

        public float GananciaTotal
        {
            get { return; }
        }

        /*Constructores*/
        public Centralita()
        { }

        public Centralita(string nombreEmpresa)
        {
            this._razonSocial = nombreEmpresa;
        }

        /*Métodos*/
        private float CalcularGanancia(TipoLlamada Tipo)
        { }

        public void Mostrar()
        { }

        public void OrdenarLlamadas()
        { }
    }

    public enum TipoLlamada
    {
        Local, Provincial, Todas
    }

    public enum Franja
    {
        Franja_1, Franja_2, Franja_3
    }
}
