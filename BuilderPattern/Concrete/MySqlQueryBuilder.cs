using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class MySqlQueryBuilder : ISqlQueryBuilder
    {
        private StringBuilder stringBuilder = new();
        public string Build()
        {
            return stringBuilder.ToString();
        }

        public ISqlQueryBuilder Conditon(string field, string optr, string value)
        {
            stringBuilder.Append($" WHERE {field} {optr} {value}");

            return this;
        }

        public ISqlQueryBuilder Order(string field, string direction)
        {
            stringBuilder.Append($" Order By {field} {direction}");

            return this;
        }

        public ISqlQueryBuilder Select(string table)
        {
            stringBuilder.Append($"SELECT * FROM {table}");

            return this;
        }
    }
}
