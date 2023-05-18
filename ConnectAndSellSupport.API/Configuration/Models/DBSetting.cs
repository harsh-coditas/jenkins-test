namespace ConnectAndSellSupport.API.Configuration.Models
{
    public class DBSetting
    {
        public string Name { get; set; }
        public string DataSourceName { get; set; }
        public string DbName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class ReplicaDBSetting
    {
        public string Name { get; set; }
        public string DataSourceName { get; set; }
        public string DbName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
