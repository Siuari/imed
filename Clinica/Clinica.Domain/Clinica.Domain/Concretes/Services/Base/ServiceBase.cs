using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Interfaces.Services.Base;

namespace Clinica.Domain.Concretes.Services.Base
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Salvar()
        {
            _repositoryBase.Salvar();
        }
    }
}
