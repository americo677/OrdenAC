using System;

namespace OrdenAC.Models.Objects.Singleton
{
    /// <summary>  
    /// Singleton para oficinas de venta: La clase singleton 'SingletonOficinas' para obtener el listado vigente de oficinas por hardcore.  
    /// </summary>
    public class SingletonOficinas
    {
        // Lazy implementa por defecto doble revisión desde .Net F. 4.0
        private static readonly Lazy<SingletonOficinas> _shared = new Lazy<SingletonOficinas>(() => new SingletonOficinas());

        private SingletonOficinas()
        {
        }

        private static OficinaVenta[] lista =
        {
            new OficinaVenta { OficinaVentaId = 1, Nombre = "Principal" },
            new OficinaVenta { OficinaVentaId = 2, Nombre = "Zona Centro" },
            new OficinaVenta { OficinaVentaId = 2, Nombre = "Zona Norte" }
        };

        public static OficinaVenta[] GetLista()
        {
            return lista;
        }

        public static SingletonOficinas Instance
        {
            get
            {
                return _shared.Value;
            }
        }
    }
}
