using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace UiFangSqlHelper
{
    public class SqlHelper
    {
   public static readonly string connstrpark = "Data Source=121.40.88.3;Initial Catalog=kangaroo;User ID=sa;Password=asd57491714";

        public static DataTable ExecuteDataTable(string connectionstring, CommandType cmdtype, string commandText, params SqlParameter[] cmdParms)
        {
            int CNum = 0;
            DataSet ds = new DataSet();
        ConRest:
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Data.SqlClient.SqlCommand command = new SqlCommand();
                command.CommandText = commandText;
                command.CommandType = cmdtype;
                command.Connection = con;
                command.CommandTimeout = 1000 * 60 * 10;
                if (cmdParms != null && command.Parameters.Count == 0)
                {
                    foreach (SqlParameter p in cmdParms)
                    {
                        SqlParameter pp = (SqlParameter)((ICloneable)p).Clone();
                        command.Parameters.Add(pp);
                    }
                }
                adapter.SelectCommand = command;
                try
                {
                    adapter.Fill(ds, "tb");
                }
                catch (SqlException sqlex)
                {
                    if (sqlex.State == 0 && CNum < 3)//连接失败
                    {
                        CNum++;
                        //SqlHelper.SqlConnectLog.Info(sqlex.Message + "_第" + CNum + "次重试");
                        command.Connection.Close();
                        command.Dispose();
                        goto ConRest;
                    }
                }
                finally
                {
                    command.Connection.Close();
                    command.Dispose();
                }
            }
            return ds.Tables["tb"];
        }
        public static DataTable ExecuteDataTable(string connectionstring, CommandType cmdtype, string commandText, int timeout, params SqlParameter[] cmdParms)
        {
            int CNum = 0;
            DataSet ds = new DataSet();
        ConRest:
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Data.SqlClient.SqlCommand command = new SqlCommand();
                command.CommandText = commandText;
                command.CommandType = cmdtype;
                command.Connection = con;
                command.CommandTimeout = timeout;
                if (cmdParms != null && command.Parameters.Count == 0)
                {
                    foreach (SqlParameter p in cmdParms)
                    {
                        SqlParameter pp = (SqlParameter)((ICloneable)p).Clone();
                        command.Parameters.Add(pp);
                    }
                }
                adapter.SelectCommand = command;
                try
                {
                    adapter.Fill(ds, "tb");
                }
                catch (SqlException sqlex)
                {
                    if (sqlex.State == 0 && CNum < 3)//连接失败
                    {
                        CNum++;
                        //SqlHelper.SqlConnectLog.Info(sqlex.Message + "_第" + CNum + "次重试");
                        command.Connection.Close();
                        command.Dispose();
                        goto ConRest;
                    }
                }
                finally
                {
                    command.Connection.Close();
                    command.Dispose();
                }
            }

            return ds.Tables["tb"];

        }
        public static DataTable ExecuteM_LogDataTable(string connectionstring, CommandType cmdtype, string commandText)
        {
            int CNum = 0;
            DataSet ds = new DataSet();
        ConRest:
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Data.SqlClient.SqlCommand command = new SqlCommand();
                command.CommandText = commandText;
                command.CommandType = cmdtype;
                command.Connection = con;
                adapter.SelectCommand = command;
                try
                {
                    adapter.Fill(ds, "tb");
                }
                catch (SqlException sqlex)
                {
                    if (sqlex.State == 0 && CNum < 3)//连接失败
                    {
                        CNum++;
                       // SqlHelper.SqlConnectLog.Info(sqlex.Message + "_第" + CNum + "次重试");
                        goto ConRest;
                    }
                }
                finally
                {
                    command.Connection.Close();
                    command.Dispose();
                }
            }
            return ds.Tables["tb"];
        }
        public static int InsertAndReturnID(string connectionstring, CommandType cmdtype, string commandText, params SqlParameter[] cmdParms)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                SqlCommand myCommand = new SqlCommand();
                conn.Open();
                SqlTransaction myTrans = conn.BeginTransaction();
                myCommand.Transaction = myTrans;
                try
                {
                    PrepareCommand(myCommand, conn, null, cmdtype, commandText + ";select scope_identity();", cmdParms);
                    Object o = myCommand.ExecuteScalar();
                    myCommand.Parameters.Clear();
                    myTrans.Commit();
                    return Convert.ToInt32(o);
                }
                catch (Exception e)
                {
                    try
                    {
                        myTrans.Rollback();
                        return 0;
                    }
                    catch (SqlException ex)
                    {
                        return 0;
                    }
                }
                finally
                {
                    conn.Close();
                }

            }
        }
        public static int ExecuteUpdate(string connectionstring, CommandType cmdtype, string cmdText, params SqlParameter[] cmdParms)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                try
                {
                    SqlCommand command = new SqlCommand();
                    PrepareCommand(command, con, null, cmdtype, cmdText, cmdParms);
                    int i = command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    return i;

                }
                catch
                {
                    return 0;
                }
                finally
                {
                    con.Close();
                }
            }

        }
        public static int ExecuteUpdateorInsertorDelete(SqlConnection con, CommandType cmdtype, string cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand command = new SqlCommand();
            PrepareCommand(command, con, null, cmdtype, cmdText, cmdParms);
            int i = command.ExecuteNonQuery();
            command.Parameters.Clear();
            con.Close();
            return i;
        }
        public static int ExecuteUpdateorInsertorDelete(SqlTransaction trans, CommandType cmdtype, string cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand command = new SqlCommand();
            PrepareCommand(command, trans.Connection, trans, cmdtype, cmdText, cmdParms);
            int i = command.ExecuteNonQuery();
            command.Parameters.Clear();
            trans.Connection.Close();
            return i;
        }
        public static Object ExecuteScalar(string connectionstring, CommandType cmdtype, string cmdText, params SqlParameter[] cmdParms)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand();
                PrepareCommand(command, con, null, cmdtype, cmdText, cmdParms);
                Object o = command.ExecuteScalar();
                command.Parameters.Clear();
                return o;
            }

        }
        public static Object ExecuteScalar(SqlConnection con, CommandType cmdtype, string cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand command = new SqlCommand();
            PrepareCommand(command, con, null, cmdtype, cmdText, cmdParms);
            Object o = command.ExecuteScalar();
            command.Parameters.Clear();
            return o;
        }
        public static int ExecuteScalar(SqlTransaction trans, CommandType cmdtype, string cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand command = new SqlCommand();
            PrepareCommand(command, trans.Connection, trans, cmdtype, cmdText, cmdParms);
            int i = command.ExecuteNonQuery();
            command.Parameters.Clear();
            return i;
        }
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            if (cmdParms != null)
            {
                foreach (SqlParameter sp in cmdParms)
                {
                    if (sp.Value == null)
                        sp.Value = DBNull.Value;
                }
                cmd.Parameters.AddRange(cmdParms);
            }
        }
        public static SqlDataReader ExecuteReader(string connectionstring, CommandType cmdtype, string cmdText, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                PrepareCommand(cmd, conn, null, cmdtype, cmdText, cmdParms);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }

        }
        public static DataSet ExecuteDataSet(string connectionstring, CommandType cmdtype, string commandText)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Data.SqlClient.SqlCommand command = new SqlCommand();
                command.CommandText = commandText;
                command.CommandType = cmdtype;
                command.Connection = con;
                adapter.SelectCommand = command;
                adapter.Fill(ds);
            }
            return ds;
        }
    }
}
