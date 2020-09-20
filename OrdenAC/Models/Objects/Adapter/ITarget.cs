using System;
using System.Collections.Generic;

namespace OrdenAC.Models.Objects.Adapter
{
    /// <summary>
    ///  Interface: Esta es la interfaz que se usará para lograr la funcionalidad de obtener una lista de órdenes.
    /// </summary>
    public interface ITarget
    {
        List<string> GetOrdenList();
    }
}
