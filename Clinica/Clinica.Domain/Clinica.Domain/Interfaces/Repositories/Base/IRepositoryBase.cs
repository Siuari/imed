using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Clinica.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntity>
    {
        ICollection<TEntity> Listar();
        ICollection<TEntity> Listar(Expression<Func<TEntity, bool>> predicate);
        void Inserir(TEntity entity);
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
        void Salvar();
    }
}
