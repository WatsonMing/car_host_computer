using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

public class MysqlConnector
{
    public MysqlConnector()
    {}
    #region  建立MySql数据库连接
    /// <summary>
    /// 建立数据库连接.
    /// </summary>
    /// <returns>返回MySqlConnection对象</returns>
    public MySqlConnection GetMysqlConnection()
    {
        MySqlConnection myconn = null;
        myconn = new MySqlConnection("Host =localhost;Database=farming;Username=root;Password=759138426");
        return myconn;
    }
    #endregion

    #region  执行MySqlCommand命令
    /// <summary>
    /// 执行MySqlCommand
    /// </summary>
    /// <param name="M_str_sqlstr">SQL语句</param>
    public void ExeUpdate(string M_str_sqlstr)
    {
        MySqlConnection mysqlcon = GetMysqlConnection();
        MySqlCommand mysqlcom = mysqlcon.CreateCommand();
        mysqlcom.CommandText = M_str_sqlstr;
        try
        {
            mysqlcon.Open();
            mysqlcom.ExecuteNonQuery();
            mysqlcom.Parameters.Clear();
        }
        catch (Exception ex) {
            MessageBox.Show("操作失败，信息为："+'\n'+ex.Message);
        }
        
    }
    #endregion

    #region  创建MySqlDataReader对象
    /// <summary>
    /// 创建一个MySqlDataReader对象
    /// </summary>
    /// <param name="M_str_sqlstr">SQL语句</param>
    /// <returns>返回MySqlDataReader对象</returns>
    public MySqlDataReader ExeQuery(string M_str_sqlstr)
    {
        MySqlConnection mysqlcon = GetMysqlConnection();
        MySqlCommand mysqlcom = mysqlcon.CreateCommand();
        mysqlcon.Open();
        mysqlcom.CommandText= M_str_sqlstr;
        MySqlDataReader mysqlread = mysqlcom.ExecuteReader();
        mysqlcom.Parameters.Clear();
        return mysqlread;
    }
    public int count(string cmdText)
    {
        MySqlConnection mysqlcon = GetMysqlConnection();
        int count=0;
        using (var cmd = new MySqlCommand(cmdText, mysqlcon))
        {
            mysqlcon.Open();
            count = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine(count.ToString());
        }
        return count;
    }
    #endregion
}