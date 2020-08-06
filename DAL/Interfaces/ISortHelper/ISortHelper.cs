using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Interfaces.ISortHelper
{
    public interface ISortHelper<T>
    {
        IEnumerable<T> ApplySort(IQueryable<T> enrities, string orderByQueryString);
    }
}
