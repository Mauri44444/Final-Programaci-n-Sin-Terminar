using CapaDeNegocio.Interfaces;
using System;

namespace CapaDeNegocio.Clases
{
    public class Carrera : ICarrera
    {
        internal Singleton S { get => Singleton.GetInstance; }

        #region IID
        public int ID { get; set; }

        #endregion

        #region ICarrera
        public string Nombre { get; set; }
        public string Sigla { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }

        public bool NombreExist()
        {

            return S.ISC.NameExist(this);

        }
        public bool SiglaExist()
        {
            return S.ISC.SiglaExist(this);

        }
        public string List()
        {

            return S.ISC.List();
        }
        #endregion

        #region IABMC
        public void Add()
        {
            S.ISC.Add(this);
        }
        public void Erase()
        {
            S.ISC.Erase(this);
        }

        public string Find()
        {
            return S.ISC.Find(this);
        }


        public void Modify()
        {
            S.ISC.Modify(this);
        }
        #endregion
    }
}
