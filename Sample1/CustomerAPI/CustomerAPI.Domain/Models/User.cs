namespace CustomerAPI.Domain.Models
{
    public class User
    {
        #region Public Properties

        public int Id { get; set; }
        public string PasswordHash { get; set; }
        public string UserName { get; set; }

        #endregion Public Properties
    }
}