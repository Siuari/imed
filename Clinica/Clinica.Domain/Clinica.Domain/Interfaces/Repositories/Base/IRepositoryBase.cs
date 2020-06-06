using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Clinica.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TKey, TEntity> 
        where TKey : struct
        where TEntity: class
    {
        ICollection<TEntity> Listar();
        ICollection<TEntity> Listar(Expression<Func<TEntity, bool>> predicate);
        void Inserir(TEntity entity);
        TEntity Atualizar(TEntity entity);
        TEntity Remover(TKey entity);
        void Salvar();
    }
}
