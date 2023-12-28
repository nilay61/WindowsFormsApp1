using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ogretmenkayit : Form
    {
        public ogretmenkayit()
        {
            InitializeComponent();
        }
        bool Ogretmenkayit(Ogretmen ogr)
        {
            //SqlConnection cn = null;
            SqlConnection cn = null;
            try
            {
                using(cn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=OkulDB; Integrated Security=true")){
                    using (SqlCommand cmd = new SqlCommand($"Insert into tblOgrenciler values(@Ad,@Soyad,@Tcno)", cn))
                    //'{ogr.Ad}','{ogr.Soyad}','{ogr.Tcno}' aslında valuesin içi böyleydi ama sql injection hatalarını engellemek için kaldırdık.)
                    {
                        SqlParameter[] p =
                        {
                                new SqlParameter("@Ad", ogr.Ad),
                                new SqlParameter("@Soyad", ogr.Soyad),
                                new SqlParameter("@Tcno", ogr.Tcno)
                        };
                        cmd.Parameters.AddRange(p);

                        cn.Open();
                        int sonuc = cmd.ExecuteNonQuery();
                        return sonuc > 0;

                    }
                }
            }
            catch(SqlException ex) 
            {
                throw;
            
            }
            catch (Exception ex)
            {
                throw;
            }
            finally 
            { /*if(cn != null && cn.State != ConnectionState.Closed) 
                { 
                    cn.Close();
                }
                */
                
            }
        }


        
        // Dispose= bir veriyi bellekten tamamen heap bölgesinden atma,silme kullanılamaz hale getirme.
        //Garbage Collector= Heap bölgesinde iişi biten verileri bellekten atar yani dispose işlemi yapar. Ama bazı nesneleri toplayıp atmaz onları özellikle dispose etmemiz gerekir.
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                var ogretmen = new Ogretmen();
                ogretmen.Ad=txtad.Text.Trim();
                ogretmen.Soyad=txtsoyad.Text.Trim();
                ogretmen.Tcno=txttc.Text.Trim();
                */

                var obl = new OgretmenBL();
                bool sonuc = Ogretmenkayit(new Ogretmen { Ad= txtad.Text.Trim(), Soyad=txtsoyad.Text.Trim(), Tcno=txttc.Text.Trim()});
                MessageBox.Show(sonuc ? "ekleme başarılı" : "ekleme başarısız");
            }
            catch (SqlException ex) 
            { 
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("bu numara zaten kayıtlı");
                        break;
                    default:
                        MessageBox.Show("veritabanı hatası");
                        break;

                }//switch

            }// catch
            catch 
            {
                MessageBox.Show("bilinmeyen hata");
            }
        }

    }
}
