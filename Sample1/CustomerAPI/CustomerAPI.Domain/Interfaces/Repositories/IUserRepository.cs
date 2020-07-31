namespace CustomerAPI.Domain.Interfaces.Repositories
{
    public interface IUserRepository<T> : IRepository<T> where T : class
    {
        #region Public Methods

        T RegisterUser(T entity);

        #endregion Public Methods
    }
}