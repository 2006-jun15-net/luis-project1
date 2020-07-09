using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }

    }
}
