using System;
using System.Collections.Generic;

namespace OrdenAC.Models.Objects.Adapter
{
    /// <summary>
    /// Client: Esta es la clase en la que quiere lograr la funcionalidad dispuesta por el código dell Adaptee (lista de ordenes).
    /// </summary>
    public class CuentasPorCobrar
    {
        private ITarget ordenesSource;

        public CuentasPorCobrar(ITarget ordenesSource)
        {
            this.ordenesSource = ordenesSource;
        }

        public List<string> showOrdenList()
        {
            // call the clietn list in the interface
            List<string> ordenes = ordenesSource.GetOrdenList();

            foreach (var orden in ordenes)
            {
                Console.Write(orden);
            }

            return ordenes;
        }
    }
}