using CapaDeDatos;
using CapaDeNegocio.Clases;
using CapaDeNegocio.Interfaces;
using System;
using System.Data;

namespace CapaDeNegocio
{
    internal partial class SingletonCarrera : ISingletonCarrera
    {
        #region InstanciaSingletonCarrera
        public ISingletonCarrera ISC { get => this; }
        #endregion

        #region IgenericSingletonCarrera
        void IGenericSingleton<Carrera>.Add(Carrera Data)
        {
            if (Data.NombreExist()) throw new Exception("Existe otra carrera con el mismo Nombre");
            if (Data.SiglaExist()) throw new Exception("Existe otra carrera con las mismas Siglas");

            IConnection.CreateCommand("Carreras_Insert", "Carrera");
            IConnection.ParameterAddVarChar("Nombre", Data.Nombre);
            IConnection.ParameterAddInt("Duracion", Data.Duracion);
            IConnection.ParameterAddVarChar("Sigla", Data.Sigla);
            IConnection.ParameterAddVarChar("Titulo", Data.Titulo);
            Data.ID = IConnection.Insert();
        }

        void IGenericSingleton<Carrera>.Erase(Carrera Data)
        {
            IConnection.CreateCommand("Carreras_Delete", "Carreras");
            IConnection.ParameterAddInt("ID", Data.ID);
            IConnection.Delete();
        }

        void IGenericSingleton<Carrera>.Find(Carrera Data)
        {
            IConnection.CreateCommand("Carreras_Find", "Carrera");
            IConnection.ParameterAddInt("ID", Data.ID);
            DataRow Dr = IConnection.Find();
            return IJsonConverter.RowToJson(Dr);
        }

        void IGenericSingleton<Carrera>.Modify(Carrera Data)
        {
            if (Data.NombreExist()) throw new Exception("Existe otra carrera con el mismo Nombre");
            if (Data.SiglaExist()) throw new Exception("Existe otra carrera con las mismas Siglas");

            IConnection.CreateCommand("Carreras_Update", "Carrera");
            IConnection.ParameterAddInt("ID", Data.ID);
            IConnection.ParameterAddInt("Duracion", Data.Duracion);
            IConnection.ParameterAddVarChar("Nombre", Data.Nombre);
            IConnection.ParameterAddVarChar("Sigla", Data.Sigla);
            IConnection.ParameterAddVarChar("Titulo", Data.Titulo);
            IConnection.Update();
        }
        #endregion

        #region SingletonCarrera

        bool ISingletonCarrera.NombreExist(Carrera Data)
        {
            IConnection.CreateCommand("Carreras_NombreExist", "Carreras");
            IConnection.ParameterAddInt("ID", Data.ID);
            IConnection.ParameterAddVarChar("Nombre", Data.Nombre);
            return IConnection.Exists();
        }
        bool ISingletonCarrera.SiglaExist(Carrera Data)
        {
            IConnection.CreateCommand("Carreras_SiglaExist", "Carreras");
            IConnection.ParameterAddInt("ID", Data.ID);
            IConnection.ParameterAddInt("Sigla", Data.Sigla);
            return IConnection.Exists();
        }
        string ISingletonCarrera.List()
        {
            try
            {
                IConnection.CreateCommand("Carreras_List", "Usuario");
                DataTable Dt = IConnection.List();
                return IJsonConverter.TableToJson(Dt);
            }
            catch (Exception)
            {
                throw new Exception("ERROR: no se pudo listar los usuarios");
            }
        }
        #endregion
    }
}
