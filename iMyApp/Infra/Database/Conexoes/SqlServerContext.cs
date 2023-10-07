using System.Configuration;


namespace Database.Conexoes
{
    internal static class SqlServerContext
    {

        internal static string Conexao => ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;

    }
}
