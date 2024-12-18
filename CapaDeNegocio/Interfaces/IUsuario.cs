

namespace CapaDeNegocio
{
    internal interface IUsuario: IABMC
    {
        string Nombre { get; set; }
        int Dni { get; set; } 
        string Mail { get; set; }

        bool DniExist();
        bool MailExist();
        string FindMail();
        string FindDni();
    }
}
