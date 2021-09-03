using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface ISqlQueryBuilder
    {
        ISqlQueryBuilder Select(string table);
        ISqlQueryBuilder Conditon(string field, string optr, string value);
        ISqlQueryBuilder Order(string field, string direction);
        string Build();
    }
}
