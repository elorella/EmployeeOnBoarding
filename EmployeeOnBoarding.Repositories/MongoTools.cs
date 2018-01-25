using MongoDB.Driver;

namespace EmployeeOnBoarding.Repositories
{
    public class MongoTools
    {
        public static IMongoDatabase GetMongoDatabase(MongoCredentials mongoCredentials)
        {
            var mongoCredential = MongoCredential.CreateCredential(
                mongoCredentials.DatabaseName,
                mongoCredentials.UserName,
                mongoCredentials.Password);
            var settings = new MongoClientSettings
            {
                Server = new MongoServerAddress(mongoCredentials.ServerAddress),
                Credential =  mongoCredential
            };
            var client = new MongoClient(settings);
            var database = client.GetDatabase(mongoCredentials.DatabaseName);
            return database;
        }
    }
}
