using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSMSOOPProject
{
    internal class clsDBHandler
    {
        private string ConnectionString = $"Data Source=DESKTOP-2T7IMJL\\SQLEXPRESS;Initial Catalog=VSMS-DB_OOP-FP;Integrated Security=True;";

        public bool mtdGetUsernameFromTable(string username, string tableName, string password)
        {
            bool UserExists = false;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            string Query = $"select * from Users where Username = '{username}' AND Password = '{password}'";
            SqlCommand command = new SqlCommand(Query, sqlConnection);
            try
            {  

            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            bool checkReader = reader.Read();
            if (checkReader)
            {
                UserExists = true;
            }
            else
            {
                UserExists = false;
            }
            sqlConnection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return UserExists;
        }

        public void ChangePasswordByTable(string username, string password, string newpassword, string tablename)
        {
            string value, query;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            try
            {
                sqlConnection.Open();
                query = $"Update {tablename} set Password = '{newpassword}' where Username = '{username}' AND Password = '{password}'";
                SqlCommand sqlDataReader = new SqlCommand(query, sqlConnection);
                int QueryRunChecker = sqlDataReader.ExecuteNonQuery();
                sqlConnection.Close();

                if(QueryRunChecker == 1) 
                {
                    MessageBox.Show("Password Changed");  
                }
                else
                {
                    MessageBox.Show("Password is not Changed. Some Error Occured");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
