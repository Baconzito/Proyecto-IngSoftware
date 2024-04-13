using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace L_DA
{
    public class Conexion
    {
        SqlConnection oCnx = new SqlConnection(@"Data Source=LAPTOP-BP9IT0ML\\SQLEXPRESS;Initial Catalog=IngSoftware;Integrated Security=True");
        SqlTransaction oTransaction;
        SqlCommand oCmd;

        public bool Guardar(string query,Hashtable Parametros)
        {
            oCnx.Open();
            oCmd = new SqlCommand(query, oCnx, oTransaction);
            oCmd.CommandType = CommandType.StoredProcedure;
            oTransaction = oCnx.BeginTransaction();
            foreach(string key in Parametros.Keys)
            {
                oCmd.Parameters.AddWithValue(key, Parametros[key]);
            }
            try
            {
                oCmd.ExecuteNonQuery();
                oTransaction.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                oTransaction.Rollback();
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Leer(string query)
        {
            DataTable dt = new DataTable();
            oCmd = new SqlCommand(query,oCnx);
            oCmd.CommandType = CommandType.StoredProcedure;
            using (SqlDataAdapter Da = new SqlDataAdapter(oCmd))
            {
                Da.Fill(dt);
            }
            return dt;
        }
    }
}
