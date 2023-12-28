using DAL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgrenciEkle(Ogretmen ogr)
        {
            try
            {
                SqlParameter[] p =
                        {
                                new SqlParameter("@Ad", ogr.Ad),
                                new SqlParameter("@Soyad", ogr.Soyad),
                                new SqlParameter("@Tcno", ogr.Tcno)
                        };

                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblOgretmen (Ad,Soyad,Tcno) values (@Ad,@Soyad,@Tcno)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //if (cn != null && cn.State != ConnectionState.Closed)
                //{
                //    //cn.Close();
                //    cn.Dispose();

                //    cmd.Dispose();
                //}
            }
        }

    }
}
