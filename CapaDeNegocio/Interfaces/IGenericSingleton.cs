

namespace CapaDeDatos
{
    public interface IGenericSingleton<T>
    {
        void Add(T Data);

        void Erase(T Data);


        void Modify(T Data);

        string Find(T Data);

    }   
}
