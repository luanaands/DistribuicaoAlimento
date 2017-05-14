using DistribuaAlimento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuaAlimento.Repositorio.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        Contexto contexto { get; }

        void Commit();

        void CommitAndRefreshChanges();

        void RollbackChanges();
    }
}
