using ClickHouse.Client.ADO;
using ClickHouse.Client.Copy;
using ClickHouse.Client.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Shared.Database.ClickHouse
{
    public class ClickHouseConnector
    {
        public async Task WriteData(IEnumerable<IClickHouseData> datas)
        {
            if (datas == null || !datas.Any())
            {
                Console.WriteLine("Datas not contains element.");
                return;
            }

            using var connection = new ClickHouseConnection("Host=localhost;Protocol=http;Port=8123;Username=default;Password=");

            var firstElement = datas.First();
            using var bulkWriter = new ClickHouseBulkCopy(connection)
            {
                DestinationTableName = firstElement.GetDatabaseAndTableName(),
                BatchSize = datas.Count(),
                ColumnNames = firstElement.GetColumnNames(),
            };

            var res = datas.Select(x => x.GetValues()).ToArray();

            await bulkWriter.InitAsync();
            await bulkWriter.WriteToServerAsync(res);
        }

        public async Task<IEnumerable<UserClicksClickHouseData>> ReadData(long userId)
        {
            using var connection = new ClickHouseConnection("Host=localhost;Protocol=http;Port=8123;Username=default;Password=");

            var data = await connection.ExecuteReaderAsync($"SELECT * FROM default.user_clicks WHERE user_id = {userId};");

            var result = new List<UserClicksClickHouseData>();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    var ent = new UserClicksClickHouseData()
                    {
                        UserId = long.Parse(data["user_id"].ToString()),
                        KeyName = data["key_name"].ToString(),
                    };

                    if (!string.IsNullOrEmpty(data["key_code"].ToString()))
                    {
                        ent.KeyCode = long.Parse(data["key_code"].ToString());
                    }
                    else
                    {
                        ent.KeyCode = null;
                    }
                    result.Add(ent);
                }
            }

            Console.WriteLine(result.Count);

            return result;

            //var version = await connection.ExecuteScalarAsync("SELECT version();");
            //Console.WriteLine(version);
        }
    }
}
