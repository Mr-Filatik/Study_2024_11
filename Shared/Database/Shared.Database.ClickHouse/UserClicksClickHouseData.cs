namespace Shared.Database.ClickHouse
{
    public class UserClicksClickHouseData : IClickHouseData
    {
        public long UserId { get; set; }
        public string KeyName { get; set; }
        public long? KeyCode { get; set; }

        public string[] GetColumnNames()
        {
            return new string[]
            {
                "user_id",
                "key_name",
                "key_code",
            };
        }

        public string GetDatabaseAndTableName()
        {
            return "default.user_clicks";
        }

        public object[] GetValues()
        {
            return new object[]
            {
                UserId,
                KeyName,
                KeyCode,
            };
        }
    }
}
