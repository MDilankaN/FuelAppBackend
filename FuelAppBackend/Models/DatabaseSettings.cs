namespace FuelAppBackend.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string?[] CollectionName { get; set; }
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty ;
    }
}
