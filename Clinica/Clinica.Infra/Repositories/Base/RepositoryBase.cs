using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Clinica.Infra.Repositories.Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<Guid, TEntity> where TEntity : class
    {
        private readonly ClinicaContext _context;

        public RepositoryBase(ClinicaContext context)
        {
            _context = context;
        }

        public virtual ICollection<TEntity> Listar()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual ICollection<TEntity> Listar(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }

        public virtual void Inserir(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public virtual void Atualizar(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }


        public TEntity Remover(Guid id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(entity);

            return entity;
        }

        public void Salvar()
        {
            var result = _context.SaveChanges();

            if(result < 1)
                Console.WriteLine("O método salvar foi chamado, porém não houve alterações na base");
        }
    }
}
