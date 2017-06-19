using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTest.Models;
using WpfTest.mySql;

namespace WpfTest.Context
{
    class TestContext
    {
        public Test_Post GetPostData()
        {
            Test_Post item = null;
            try
            {
                string connStr = new SqlConnect().getConnectString();
                MySqlConnection Conn = new MySqlConnection(connStr);
                MySqlCommand cmd = Conn.CreateCommand();
                Conn.Open();

                cmd.CommandText = new SqlCommand().selectCmd("post");
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        int pId = (int)reader["P_Id"];
                        string content = (string)reader["P_Content"];
                        string posttime = (string)reader["P_PostTime"];
                        int sId = (int)reader["SId"];
                        string name = (string)reader["SName"];

                        item = new Test_Post { P_Id = pId, Content = content, postTime = posttime, S_Id = sId, S_Name = name };
                        break;
                    }
                }
                Conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return item;
        }
    }
}
