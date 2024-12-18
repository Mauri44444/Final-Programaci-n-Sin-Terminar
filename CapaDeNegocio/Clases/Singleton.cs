using CapaDeDatos;

namespace CapaDeNegocio
{
    internal partial class Singleton : ParentSingleton
    {
        static Singleton instance => new Singleton();
        private Singleton() { }
        public static Singleton GetInstance => instance;
    }
}
