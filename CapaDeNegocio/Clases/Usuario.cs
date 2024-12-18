

namespace CapaDeNegocio
{
    public class Usuario :  IUsuario
    {
        internal Singleton S { get => Singleton.GetInstance; }
        
        #region IID
        public int ID { get ; set ; }

        #endregion

        #region IUsuario
        public string Nombre { get ; set ; }
        public int Dni { get; set; }
        public string Mail { get; set; }

        public bool DniExist()
        {

            return S.ISU.DniExist(this);
            
        }
        public bool MailExist()
        {
            return S.ISU.MailExist(this);

        }
       
        public string FindDni()
        {
            return S.ISU.FindByDni(this);
        }

        public string FindMail()
        {
            return S.ISU.FindByMail(this);
        }
    

        public string List()
        {

            return S.ISU.List();
        }
        #endregion

        #region IABMC
        public void Add()
        {
            S.ISU.Add(this);
        }
        public void Erase()
        {
            S.ISU.Erase(this);
        }

        public string Find()
        {
            return S.ISU.Find(this);
        }


        public void Modify()
        {
            S.ISU.Modify(this);
        }
        #endregion

    }
}
