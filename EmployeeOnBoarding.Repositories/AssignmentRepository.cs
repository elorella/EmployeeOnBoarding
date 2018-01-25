using EmployeeOnBoarding.Domain.Assignment;

namespace EmployeeOnBoarding.Repositories
{
    public class AssignmentRepository : BaseRepository<Assignment>
    {

        public AssignmentRepository()
        {
        }

        /*
        public async Task<List<FutureTransactionMongoDto>> GetNeovestFutureTransactions(Date date)
        {
            var mongoCollection = _database.GetCollection<FutureTransactionMongoDto>(nameof(FutureTransactionMongoDto));

            var startDateUtc = new DateConverter().ToDateTime(date).ToUniversalTime();
            var endDateUtc = startDateUtc.AddDays(1);

            var filterBuilder = Builders<FutureTransactionMongoDto>.Filter;

            var filter = filterBuilder.Gte(x => x.TransactTime, new BsonDateTime(startDateUtc)) &
                         filterBuilder.Lt(x => x.TransactTime, new BsonDateTime(endDateUtc));

            var trades = (await mongoCollection.FindAsync(filter))
                .ToList();

            return trades;
        }

        public async Task<List<FutureTransactionMongoDto>> GetNeovestFutureTransactions(IEnumerable<string> orderIds)
        {
            var mongoCollection = _database.GetCollection<FutureTransactionMongoDto>(nameof(FutureTransactionMongoDto));

            var filterBuilder = Builders<FutureTransactionMongoDto>.Filter;


            var filters = new List<FilterDefinition<FutureTransactionMongoDto>>();
            foreach (var orderId in orderIds)
            {
                filters.Add(filterBuilder.Eq(x => x.ClOrdId, orderId));
            }

            var filter = filterBuilder.Or(filters);

            var trades = (await mongoCollection.FindAsync(filter))
                .ToList();

            return trades;
        }

        public async Task<FutureTransactionMongoDto> GetNeovestFutureTransactionById(string futureNeovestTransactionId)
        {
            var futureTransactionMongoDtoCollection = _database.GetCollection<FutureTransactionMongoDto>(nameof(FutureTransactionMongoDto));

            var result = await futureTransactionMongoDtoCollection.FindAsync(
                futureTransactionMongoDto =>
                    futureTransactionMongoDto.GeneratedTransactionId.Equals(futureNeovestTransactionId)
            );

            return result.SingleOrDefault();
        }

        public void SaveNeovestFutureTransaction(FutureTransactionMongoDto futureTransactionMongoDto)
        {
            _database.GetCollection<FutureTransactionMongoDto>(nameof(FutureTransactionMongoDto))
                .InsertOne(futureTransactionMongoDto);
        }
        */

    }
}
