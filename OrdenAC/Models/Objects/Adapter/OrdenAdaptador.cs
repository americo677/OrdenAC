using System;
using System.Collections.Generic;

namespace OrdenAC.Models.Objects.Adapter
{
    /// <summary>
    /// Adapter: Esta es la clase que que implementará ITarget y sería invocada por el Adaptee código que se quiere ejecutar por el cliente.
    /// </summary>
    public class OrdenAdaptador: OrdenComercial, ITarget
    {

        public List<string> GetOrdenList()
        {
            List<string> ordenList = new List<string>();
            //CompanyEmployees ce = new CompanyEmployees();
            string[][] ordenes = GetListado();
            foreach (string[] orden in ordenes)
            {
                ordenList.Add(orden[0]);
                ordenList.Add(",");
                ordenList.Add(orden[1]);
                ordenList.Add(",");
                ordenList.Add(orden[2]);
                ordenList.Add("\n");
            }

            return ordenList;
        }

        public OrdenAdaptador()
        {
        }
    }
}