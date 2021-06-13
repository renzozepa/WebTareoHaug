namespace ClsData
{
    using System.Data.SqlClient;
    public class Usuario
    {
        public static SqlDataReader GetUsuarioLogin(ClsEntity.Usuario peObjUsuario)
        {
            return ClsFunciones.BDFunciones.EjecutarDataReader("SP_LOGIN", new SqlParameter("@USUARIO", peObjUsuario.USUARIO),
                                                                           new SqlParameter("@CLAVE", peObjUsuario.CLAVE));
        }
    }
}
