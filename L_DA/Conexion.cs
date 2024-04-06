using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace L_DA
{
    public class Conexion
    {
        SqlConnection oCnx = new SqlConnection("");
        SqlTransaction oTransaction;
        SqlCommand oCmd;

        public bool Guardar(string query)
        {
            oCnx.Open();
            oCmd = new SqlCommand(query, oCnx, oTransaction);
            oTransaction = oCnx.BeginTransaction();
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
            using (SqlDataAdapter Da = new SqlDataAdapter(oCmd))
            {
                Da.Fill(dt);
            }
            return dt;
        }


       
    }
}
