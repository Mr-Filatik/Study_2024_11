using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Database.ClickHouse
{
    public interface IClickHouseData
    {
        public string GetDatabaseAndTableName();
        public string[] GetColumnNames();
        public object[] GetValues();
    }
}
