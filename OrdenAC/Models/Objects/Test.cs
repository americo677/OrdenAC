using System;
using OrdenAC.Models.Objects.Factory;
using OrdenAC.Models.Objects.Singleton;

namespace OrdenAC.Models.Objects
{
    public class Test
    {
        public Test()
        {

            foreach(OficinaVenta oficina in SingletonOficinas.GetLista())
            {
                Console.WriteLine($"{oficina.OficinaVentaId} - {oficina.Nombre}");
            }

            OrdenFactory factory = null;

            factory = new OrdenOfiZPrincipalFactory(1, new DateTime(2020, 10, 10), "Mi cliente favorito", "Macbook Pro 2020");

            IOrden ordenPrincipal = factory.CreateOrden();

            ordenPrincipal.GetCliente();

            factory = new OrdenOfiZNorteFactory(2, new DateTime(2020, 10, 10), "Mi cliente favorito", "Lenovo 820");

            IOrden ordenNorte = factory.CreateOrden();

            ordenNorte.GetCliente();

        }
    }
}
