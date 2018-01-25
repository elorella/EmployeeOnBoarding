using System;
using EmployeeOnBoarding.Domain;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace EmployeeOnBoarding.Repositories
{
    public class BaseRepository<TEntity> where TEntity :  IEntity
    {
        private readonly IMongoDatabase _database;
        private readonly string _collectionName = (typeof(TEntity).ToString());

        public BaseRepository()
        {
            var pack = new ConventionPack
            {
                new EnumRepresentationConvention(BsonType.String)
            };

            ConventionRegistry.Register("EnumStringConvention", pack, t => true);
            _database = MongoTools.GetMongoDatabase(new MongoCredentials("EmployeeOnboarding", "mongouser", "mongo123", "localhost"));
        }

       
        public virtual TEntity GetById(int id)
        {
            var mongoDtoCollection = _database.GetCollection<TEntity>(_collectionName);

            var result = mongoDtoCollection.Find(
                futureTransactionMongoDto =>
                    futureTransactionMongoDto.Id.Equals(id)
            );

            return result.SingleOrDefault();
        }

        public virtual void Insert(TEntity entity)
        {
            var exsistingItem = GetById(entity.Id);
            if (exsistingItem != null)
                throw new Exception($"Item with Id={exsistingItem.Id} already exist.");

            _database.GetCollection<TEntity>(_collectionName)
                .InsertOne(entity);
        }

        public virtual void Upsert(TEntity entity)
        {
           
        }


        public virtual void Delete(object id)
        {
           
        }
    
        public virtual void Update(TEntity entityToUpdate)
        {
           
        }

    }
}
