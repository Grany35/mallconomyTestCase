namespace TestCase.Core.Settings;

public class MongoSettings:IMongoSettings
{
    public string ConnectionString { get; set; }
    public string Database { get; set; }
}