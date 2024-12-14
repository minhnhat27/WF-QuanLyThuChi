using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThuChi
{
    public static class MyPublics
    {
        public static SqlConnection conMyConnection;
        public static string strMaNV, strQuyenSD, strMaCV;
        public static void ConnectDatabase()
        {
            string strConnect = "Server=LAPTOP-4C6GNV93; Database=QL_ThuChi; Integrated Security=false; UID=TN207User; PWD=TN207User";
            //string strConnect = "Server=MINHNHAT\\SQLEXPRESS; Database=QL_ThuChi; Integrated Security=false; UID=TN207User; PWD=TN207User";
            conMyConnection = new SqlConnection();
            conMyConnection.ConnectionString = strConnect;
            try
            {
                conMyConnection.Open();
            }
            catch(Exception)
            {

            }
        }
        public static void OpenData(string strSql, DataTable dtTable)
        {
            SqlDataAdapter daAdapter = new SqlDataAdapter();
            try
            {
                if (conMyConnection.State == ConnectionState.Closed)
                                conMyConnection.Open();
                daAdapter.SelectCommand = new SqlCommand(strSql, conMyConnection);
                daAdapter.Fill(dtTable);
                conMyConnection.Close();
            }
            catch (Exception)
            {

            }
        }
        public static bool TonTaiKhoaChinh(string strGiaTri, string strTenTruong, string strTable)
        {
            bool result = false;
            try
            {
                string strselect = "Select 1 From " + strTable + " Where "
                    + strTenTruong + "='" + strGiaTri + "'";
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(strselect, conMyConnection);

                SqlDataReader daReader = cmdCommand.ExecuteReader();
                if (daReader.HasRows)
                    result = true;
                daReader.Close();
                conMyConnection.Close();
            }
            catch (Exception)
            {

            }
            return result;
        }
    }
}
