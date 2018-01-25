namespace EmployeeOnBoarding.Repositories
{
    public class MongoCredentials
    {
        public string DatabaseName { get; }
        public string UserName { get; }
        public string Password { get; }
        public string ServerAddress { get; }

        public MongoCredentials(string databaseName, string userName, string password, string serverAddress)
        {
            DatabaseName = databaseName;
            UserName = userName;
            Password = password;
            ServerAddress = serverAddress;
        }
    }
}