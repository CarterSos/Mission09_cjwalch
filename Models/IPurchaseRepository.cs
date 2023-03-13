using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_cjwalch.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; } // public is default

        public void SavePurchase(Purchase purchase);


    }
}
