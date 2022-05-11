using MongoDB.Driver;

namespace JSApiRepository
{
    public class JSMongoDbContext
    {
        //public IMongoCollection<MongoEntityProductModal> Products { get; }
        public JSMongoDbContext(string connectionString, string dbName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(dbName);
            //Products = database.GetCollection<MongoEntityProductModal>("Products");
        }
    }
}
