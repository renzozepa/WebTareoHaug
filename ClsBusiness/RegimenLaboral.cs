namespace ClsBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class RegimenLaboral
    {
        public static List<ClsEntity.RegimenLaboral> GetAllRegimenLaboral(string sucursal,ClsEntity.RegimenLaboral peObjRegimenLaboral)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.RegimenLaboral.GetAllRegimenLaboral(sucursal,peObjRegimenLaboral);
            List<ClsEntity.RegimenLaboral> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.RegimenLaboral>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.RegimenLaboral loobjRegimenLaboral = new ClsEntity.RegimenLaboral
                    {
                        NroProyectoEsquema = Convert.ToString(lodtrDataRead["NroProyectoEsquema"]),
                        NroEsquemaPlanilla = Convert.ToString(lodtrDataRead["NroEsquemaPlanilla"]),
                        CodEsquemaPlanilla = Convert.ToString(lodtrDataRead["CodEsquemaPlanilla"]),
                        Descripcion = Convert.ToString(lodtrDataRead["Descripcion"])
                    };
                    loListRes.Add(loobjRegimenLaboral);
                }
            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
        public static List<ClsEntity.RegimenLaboral> GetAllRegimenLaboralxId(string sucursal,ClsEntity.RegimenLaboral peObjRegimenLaboral)
        {
            SqlDataReader lodtrDataRead = default(SqlDataReader);
            lodtrDataRead = ClsData.RegimenLaboral.GetAllRegimenLaboralxId(sucursal,peObjRegimenLaboral);
            List<ClsEntity.RegimenLaboral> loListRes = null;
            if ((lodtrDataRead.HasRows))
            {
                loListRes = new List<ClsEntity.RegimenLaboral>();
                while ((lodtrDataRead.Read()))
                {
                    ClsEntity.RegimenLaboral loobjRegimenLaboral = new ClsEntity.RegimenLaboral
                    {
                        NroProyectoEsquema = Convert.ToString(lodtrDataRead["NroProyectoEsquema"]),
                        NroEsquemaPlanilla = Convert.ToString(lodtrDataRead["NroEsquemaPlanilla"]),
                        CodEsquemaPlanilla = Convert.ToString(lodtrDataRead["CodEsquemaPlanilla"]),
                        Descripcion = Convert.ToString(lodtrDataRead["Descripcion"])
                    };
                    loListRes.Add(loobjRegimenLaboral);
                }
            }
            lodtrDataRead = null;
            GC.Collect();
            return loListRes;
        }
    }
}
