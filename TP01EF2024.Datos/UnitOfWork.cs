using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos.Interfaces;

namespace TP01EF2024.Datos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TP01DbContext _context;

        private IDbContextTransaction? _transaction;

        public UnitOfWork(TP01DbContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                SaveChanges();
                _transaction?.Commit();
            }
            catch (Exception)
            {
                RollBack();
                throw;
            }
        }

        public void RollBack()
        {
            _transaction?.Rollback();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
