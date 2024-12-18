using CapaDeDatos;
using CapaDeNegocio.Clases;

namespace CapaDeNegocio.Interfaces
{
    internal interface ISingletonCarrera: IGenericSingleton<Carrera>
    {
        bool NombreExist(Carrera data);
        bool SiglaExist(Carrera data);

        string List();
    }
}
