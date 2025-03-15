using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;

namespace BookHaven.Data.repository
{
    public interface ISupplierRepository
    {
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        Supplier GetSupplierById(int id);
        List<Supplier> GetAllSuppliers();
    }
}
