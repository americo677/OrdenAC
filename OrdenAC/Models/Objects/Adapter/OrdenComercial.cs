using System;
namespace OrdenAC.Models.Objects.Adapter
{
    /// <summary>
    /// Adaptee: Esta es la funcionalidad deseada y que actualmente no hay compatibilidad con la funcionalidad existente.
    /// </summary>
    public class OrdenComercial
    {
        public string[][] GetListado(int byId=-1)
        {
            string[][] ordenes = new string[4][];

            ordenes[0] = new string[] { "100", "Deepak", "Team Leader" };
            ordenes[1] = new string[] { "101", "Rohit", "Developer" };
            ordenes[2] = new string[] { "102", "Gautam", "Developer" };
            ordenes[3] = new string[] { "103", "Dev", "Tester" };

            return ordenes;
        }

        public OrdenComercial()
        {
        }
    }
}