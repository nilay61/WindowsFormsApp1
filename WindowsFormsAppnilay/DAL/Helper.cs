using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class Helper//veritabanı bağlantısı işlerini yapacak. insert alter, update işlerini yapması iççin oluşturuldu.
    {
        SqlConnection cn;
        SqlCommand cmd;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)//p parametresine hiçbir şey gelmezse null olsun diyoruz
        {
            using (cn = new SqlConnection(cstr))
            {
                using (cmd = new SqlCommand(cmdtext, cn))
                {
                    if (p != null)//null değilse komutun parametre dosyasına ekle
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    cn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
