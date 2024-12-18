

namespace CapaDeDatos
{
    public class ParentSingleton
    {
        public IConnection IConnection => Connection.GetInstance;

        public IJsonConverter IJsonConverter
        {
            get => new JsonConverter();
        }
    }
}
