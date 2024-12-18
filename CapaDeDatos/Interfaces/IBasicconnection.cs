using System.Data.SqlClient;


namespace CapaDeDatos
{
    public interface IBasicConnection
    {
        SqlConnection MyConnection { get; set; }
        SqlCommand MyCommand { get; set; }
        string Referente { get; set; }
        string ConnectionString { get; set; }
        void OpenConnection();
    }
}
