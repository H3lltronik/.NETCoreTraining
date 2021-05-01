namespace Catalog.Settings {
    public class MongoDbSettings {
        public string host { get; set; }
        public int port { get; set; }

        public string User { get; set; }
        public string Password { get; set; }

        public string ConnectionString { 
            get {
                return $"mongodb://{User}:{Password}@{host}:{port}";
            }
        }
    }
}