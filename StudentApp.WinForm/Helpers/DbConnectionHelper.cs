using System.Data.SqlClient;

namespace StudentApp.WinForm.Helpers
{
    public class DbConnectionHelper
    {
        public SqlConnection Connection => GetConnection();
        private SqlConnection GetConnection()
        {
            return new SqlConnection("server=.\\SQLExpress; database=StudentDb; integrated security=true;");
        }

        //SRP => SINGLE RESPONSIBILITY => TEK SORUMLULUK
        //public void OpenOrCloseConnection()
        //{
        //    if (Connection.State == System.Data.ConnectionState.Closed)
        //    {
        //        Connection.Open();
        //    }
        //    else
        //    {
        //        Connection.Close();
        //    }
        //}

        //public void OpenConnection()
        //{
        //    Connection.Open();
        //}

        //public void CloseConnection() {
        //    Connection.Close();
        //}
    }
}
