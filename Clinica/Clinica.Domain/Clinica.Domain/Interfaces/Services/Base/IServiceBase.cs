namespace Clinica.Domain.Interfaces.Services.Base
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Salvar();
    }
}
