using System;
using System.Collections.Generic;
using System.Linq;
using OrdenAC.Models;
using OrdenAC.Services;

namespace OrdenAC
{
    /// <summary>  
    /// Clase implementación de la interfaz IOrdenService: Clase de implementación de los servicios expuestos para el intercambio de órdenes con los subsistemas de la solución.
    /// </summary>
    public class WSOrdenService : IOrdenService
    {

        public List<OrdenModel> All()
        {
            List<OrdenModel> ordenes = new List<OrdenModel>();

            using (var dbContext = new OrdenACDBContext())
            {
                ordenes = new List<OrdenModel>(dbContext.Ordenes);
            }

            return ordenes;
        }

        public OrdenModel OrdenBy(int ordenModelId)
        {
            throw new NotImplementedException();
        }

        public int Add(OrdenModel ordenModel)
        {
            using (var dbContext = new OrdenACDBContext())
            {

                using (var dbTransaction = dbContext.Database.BeginTransaction())
                {

                    if (!dbContext.Ordenes.Any())
                    {
                        //dbContext.Ordenes.Add(entity: ordenModel);
                        dbContext.Ordenes.AddAsync(entity: ordenModel);
                        dbContext.SaveChanges();
                        dbTransaction.Commit();
                    }
                    else
                    {
                        dbTransaction.Rollback();
                    }

                }
            }
            return 0;

        }
    }
}
