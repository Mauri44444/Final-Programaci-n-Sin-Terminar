using CapaDeDatos;

namespace CapaDeNegocio
{
    internal interface ISingletonUsuario: IGenericSingleton<Usuario>
    {
        bool DniExist(Usuario data);
        bool MailExist(Usuario data);
        string FindByMail(Usuario data);
        string FindByDni(Usuario data);

        string List();
    }
}
