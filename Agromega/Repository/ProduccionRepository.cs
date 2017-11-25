using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agromega.Models;
using System.Data.SqlClient;
using System.Data;

namespace Agromega.Repository
{
    public class ProduccionRepository : IProduccionRepository
    {
        SqlConnection cn;
        Conexion con = new Conexion();
        public List<Produccion> GetCultivoSuelo(string suelo, string cultivo)
        {
            cn = con.GetConection();
            List<Produccion> pd = new List<Produccion>();
            SqlCommand cmd = new SqlCommand("GetProdClimaSuelo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Suelo", suelo);
            cmd.Parameters.AddWithValue("@Cultivo", cultivo);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            cn.Open();
            sd.Fill(dt);
            cn.Close();

            foreach(DataRow dr in dt.Rows)
            {
                pd.Add(
                    new Produccion
                    {
                        NombreProducto=Convert.ToString(dr["NombreProducto"])
                    }
                );
            }
            return pd;  
        }
    }
}