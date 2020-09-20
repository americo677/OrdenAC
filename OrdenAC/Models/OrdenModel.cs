using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdenAC.Models
{
    /// <summary>  
    /// OrdenModel: Clase principal core de la solución configurada para el uso de EF.
    /// </summary>
    [DataContract]
    public class OrdenModel
    {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdenModelId { get; set; }
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime FechaRegistro { get; set; }
        [DataMember]
        public int OficinaVentaId { get; set; }
        [DataMember]
        public string Cliente { get; set; }
        [DataMember]
        public string Producto { get; set; }

        public OrdenModel(int oficinaVentaId, string cliente, string producto)
        {
            //OrdenModelId = 0;
            //FechaRegistro = new DateTime(1970, 1, 1);
            OficinaVentaId = oficinaVentaId;
            Cliente = cliente;
            Producto = producto;
        }
    }
}
