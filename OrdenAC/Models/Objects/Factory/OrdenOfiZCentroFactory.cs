using System;
namespace OrdenAC.Models.Objects.Factory
{
    /// <summary>  
    /// Concrete factory: Clase 'Fábrica - Creadora de la clase concreta Orden Oficina Zona Centro'  
    /// </summary>  
    public class OrdenOfiZCentroFactory: OrdenFactory
    {
        private int _ordenId;
        private DateTime _fechaRegistro;
        private string _cliente;
        private string _item;

        public OrdenOfiZCentroFactory(int ordenId, DateTime fechaRegistro, string cliente, string item)
        {
            _ordenId = ordenId;
            _fechaRegistro = fechaRegistro;
            _cliente = cliente;
            _item = item;
        }

        protected override IOrden MakeOrden()
        {
            IOrden orden = new OrdenOfiZCentro(_ordenId, _fechaRegistro, _cliente, _item);
            return orden;
        }
    }
}
