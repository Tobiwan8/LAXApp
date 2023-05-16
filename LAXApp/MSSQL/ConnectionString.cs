namespace LAXApp.MSSQL
{
    internal class ConnectionString
    {
        private string _connectionString = @"Server = 192.168.0.3,1433; Initial Catalog = LAXMovieDB; persist security info = true; User ID=sa; Password=Passw0rd";
        internal string ConnectionToSql
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
    }
}
