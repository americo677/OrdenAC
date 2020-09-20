using System;
namespace OrdenAC.Models.Objects.Factory
{
    /// <summary>  
    /// Factory: La clase abstracta 'Fábrica - Creadora'
    /// </summary>
    public abstract class OrdenFactory
    {
        protected abstract IOrden MakeOrden();

        public IOrden CreateOrden()
        {
            return MakeOrden();
        }
    }
}
