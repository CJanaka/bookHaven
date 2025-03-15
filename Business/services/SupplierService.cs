using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;
using BookHaven.Data.repository;

namespace BookHaven.Business.services
{
    public class SupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public void AddSupplier(Supplier supplier) => _supplierRepository.AddSupplier(supplier);

        public void UpdateSupplier(Supplier supplier) => _supplierRepository.UpdateSupplier(supplier);

        public Supplier GetSupplierById(int id) => _supplierRepository.GetSupplierById(id);

        public List<Supplier> GetAllSuppliers() => _supplierRepository.GetAllSuppliers();
    }
}
