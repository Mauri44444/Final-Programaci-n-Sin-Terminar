

namespace CapaDeNegocio
{
    internal interface IABMC: IID
    {
        void Modify();
        void Add();

        void Erase();
        string Find();

    }
}
