using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP.NETDAL.Model;
using Utils;

namespace TP.NET.Service
{
    public class ServiceProduits
    {
        private ErrorHandler _eh;
        public ServiceProduits(ErrorHandler pEh)
        {
            this._eh = pEh;
        }

        public List<Produits> findAll()
        {
            using (VenteEnLigneEntities context = new  VenteEnLigneEntities())
            {
                return context.Produits.Include("Images").ToList();
            }
        }

        internal Produits findByID(int id)
        {
            using (VenteEnLigneEntities context = new VenteEnLigneEntities())
            {
                return context.Produits.Include("Images").Where(p => p.id == id).FirstOrDefault();
            }
        }
    }
}