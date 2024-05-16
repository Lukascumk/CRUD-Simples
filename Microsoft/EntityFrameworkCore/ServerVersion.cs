using MySql.EntityFrameworkCore.Infrastructure;

namespace Microsoft.EntityFrameworkCore
{
    internal class ServerVersion
    {
        internal static Action<MySQLDbContextOptionsBuilder>? Parse(string v)
        {
            throw new NotImplementedException();
        }
    }
}