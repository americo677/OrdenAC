using System;
namespace OrdenAC.Models.Objects.Factory
{
    /// <summary>  
    /// Concrete factory: Clase 'Fábrica - Creadora de la clase concreta de Orden Oficina Principal'  
    /// </summary>  
    public class OrdenOfiZPrincipalFactory: OrdenFactory
    {
        private int _ordenId;
        private DateTime _fechaRegistro;
        private string _cliente;
        private string _item;

        public OrdenOfiZPrincipalFactory(int ordenId, DateTime fechaRegistro, string cliente, string item)
        {
            _ordenId = ordenId;
            _fechaRegistro = fechaRegistro;
            _cliente = cliente;
            _item = item;
        }

        protected override IOrden MakeOrden()
        {
            IOrden orden = new OrdenOfiZPrincipal(_ordenId, _fechaRegistro, _cliente, _item);
            return orden;
        }
    }
}
