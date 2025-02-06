using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.DataAccess
{
    public class SqlLiteBookDataContext : BookContext
    {
        public SqlLiteBookDataContext(IConfiguration Configuration) : base(Configuration)
        {

        }
    }
}
