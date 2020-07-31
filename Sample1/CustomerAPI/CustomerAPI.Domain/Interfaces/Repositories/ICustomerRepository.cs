namespace CustomerAPI.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository<T> : IRepository<T> where T : class
    {
        #region Public Methods

        bool CheckForEmailAsync(string email);

        #endregion Public Methods
    }
}