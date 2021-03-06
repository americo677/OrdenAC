﻿using System;
using OrdenAC.Models.Objects.Singleton;
namespace OrdenAC.Models.Objects.Factory
{
    /// <summary>  
    /// Concrete class: Una clase 'Orden concreta de la Oficina Zona Norte'  
    /// </summary>  
    public class OrdenOfiZNorte: IOrden
    {
        private readonly int _oficinaVentaId;
        private int _ordenId;
        private DateTime _fechaRegistro;
        private string _cliente;
        private string _item;

        public OrdenOfiZNorte(int ordenId, DateTime fechaRegistro, string cliente, string item)
        {
            _oficinaVentaId = SingletonOficinas.GetLista()[2].OficinaVentaId;
            _ordenId = ordenId;
            _fechaRegistro = fechaRegistro;
            _cliente = cliente;
            _item = item;
        }

        public int GetOficinaVentaId()
        {
            return _oficinaVentaId;
        }

        public int GetOrdenId()
        {
            return _ordenId;
        }

        public DateTime GetFechaRegistro()
        {
            return _fechaRegistro;
        }

        public string GetCliente()
        {
            return _cliente;
        }

        public string GetItem()
        {
            return _item;
        }
    }
}
