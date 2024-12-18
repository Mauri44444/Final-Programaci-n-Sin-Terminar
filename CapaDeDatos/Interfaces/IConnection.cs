
using System.Data;

namespace CapaDeDatos
{
    public interface IConnection: IParameters
    {
        void CreateCommand(string storeprocedure, string referente);
int Insert();
void InsertWithoutID();
bool Exists();
void Update();
void Delete();
DataTable List();
DataRow Find();

    }
}
