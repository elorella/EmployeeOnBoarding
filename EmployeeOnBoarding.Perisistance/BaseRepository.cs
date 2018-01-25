using System;
using System.Collections;
using System.Collections.Generic;
using EmployeeOnBoarding.Domain;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace EmployeeOnBoarding.Perisistance
{
    public class BaseRepository<TEntity> where TEntity : IEntity
    {
        private readonly string _collectionName;
        private readonly IMongoDatabase _database;

        public BaseRepository(MongoCredentials mongoCredentials)
        {
            var pack = new ConventionPack
            {
                new EnumRepresentationConvention(BsonType.String)
            };

            var collections = typeof(TEntity).ToString().Split('.');
            _collectionName = collections[collections.Length - 1];
            ConventionRegistry.Register("EnumStringConvention", pack, t => true);
            _database = MongoTools.GetMongoDatabase(mongoCredentials);
        }

        public virtual IEnumerable<TEntity> Get()
        {
            var mongoDtoCollection = _database.GetCollection<TEntity>(_collectionName);
            var result = mongoDtoCollection.WithReadPreference(ReadPreference.Nearest);
            return result.AsQueryable();
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
        
        public virtual void Delete(int id)
        {

        }

        public virtual void Update(TEntity entityToUpdate)
        {

        }
    }
}
