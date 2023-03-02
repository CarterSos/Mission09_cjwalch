using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_cjwalch.Models
{
    public interface IBookstoreRepository // interface is a template for a class that ensures it will be used correctly
    {
        IQueryable<Book> Books { get; }
    }
}
