using System;
namespace OrdenAC.Models.Objects.Factory
{

    /// <summary>  
    /// Interface: 'Orden'.
    /// </summary> 
    public interface IOrden
    {
        public int GetOrdenId();
        public DateTime GetFechaRegistro();
        public int GetOficinaVentaId();
        public string GetCliente();
        public string GetItem();

    }
}
