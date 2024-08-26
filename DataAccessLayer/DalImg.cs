using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalImg
    {
        public static void SetImageData(string a,  Modelimg obj)
        //public static void SetImageData(string a, string Modelimg)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO tblImages (userid,imageId,imagePath) VALUES (@a, @b, @c)", con);
            cmd.Parameters.AddWithValue("@a", a);
            cmd.Parameters.AddWithValue("@b", obj.ImageId);
            cmd.Parameters.AddWithValue("@c", obj.ImagePath);

            cmd.ExecuteNonQuery();

            con.Close();

        }
    }
}
