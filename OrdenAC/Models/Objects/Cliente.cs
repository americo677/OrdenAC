using System;
namespace OrdenAC.Models.Objects
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Cliente()
        {
        }
    }
}
