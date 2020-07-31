namespace CustomerAPI.EFCore.Entities
{
    public class User
    {
        #region Public Properties

        public int Id { get; set; }
        public string PasswordHash { get; set; }
        public string Username { get; set; }

        #endregion Public Properties
    }
}