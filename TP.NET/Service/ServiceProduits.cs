using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP.NETDAL.Model;

namespace TP.NET.Service
{
    public class ServiceProduits
    {
        public ServiceProduits()
        {

        }

        public List<Produits> findAll()
        {
            using (VenteEnLigneEntities context = new  VenteEnLigneEntities())
            {
                return context.Produits.Include("Image").ToList();
            }
        }
    }
}