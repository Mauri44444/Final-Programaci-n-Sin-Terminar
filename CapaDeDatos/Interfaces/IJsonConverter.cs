
using System.Data;

namespace CapaDeDatos
{
    public interface IJsonConverter
    {
string RowToJson(DataRow Dr);

string TableToJson(DataTable Dt);
    }
}
