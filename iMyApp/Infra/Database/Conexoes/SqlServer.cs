namespace Database.Conexoes
{
    internal static class SqlServer
    {

        internal static string StrConexao()
        {

            return @"Data Source=localhost;Initial Catalog=iMyApp;User ID=sa;Password=sql2022";
            //return "Server=localhost;Database=iMyApp;User Id=sa;Password=sql2022;Trusted_Connection=False; TrustServerCertificate=True;";
        }
    }
}
