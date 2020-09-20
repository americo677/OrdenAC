using System;
using OrdenAC.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;



namespace OrdenAC.Services
{
    /// <summary>  
    /// Interface: Interfaz de los servicios expuestos para el intercambio de órdenes con los subsistemas de la solución.
    /// </summary>
    [ServiceContract]
    public interface IOrdenService
    {
        [OperationContract]
        List<OrdenModel> All();

        [OperationContract]
        OrdenModel OrdenBy(int ordenModelId);

        [OperationContract]
        int Add(OrdenModel ordenModel);
    }
}