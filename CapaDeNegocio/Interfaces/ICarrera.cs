

namespace CapaDeNegocio.Interfaces
{
    internal interface ICarrera: IABMC
    {
        string Nombre { get; set; }
        string Sigla { get; set; }
        string Titulo { get; set; }
        int Duracion { get; set; }

        bool NombreExist();
        bool SiglaExist();
    }
}
