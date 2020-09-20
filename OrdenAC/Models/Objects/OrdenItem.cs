using System;
namespace OrdenAC.Models.Objects
{
    public class OrdenItem
    {

        public int OrdenItemId { get; set; }
        public OrdenModel Orden { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorTotal { get; set; }

        public OrdenItem()
        {
        }
    }
}
