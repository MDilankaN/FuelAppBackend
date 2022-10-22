namespace FuelAppBackend.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string CollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty ;
    }
}
