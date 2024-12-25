using DataBook.Common;
using System;
using System.Collections;
using System.Data.SqlClient;

namespace DataBook.Data
{
    internal class DataAccessLayer : IDataAccessLayer, ILoginManager
    {
        private string CONNECTION_STRING = string.Empty;
        private SqlConnection SQL_CONNECTION;

        internal DataAccessLayer()
        {
            InitializeDataAccessLayer();
        }

        internal DataAccessLayer(string ConnectingString)
        {
            CONNECTION_STRING = ConnectingString;

            InitializeDataAccessLayer();
        }

        public bool AddDBData()
        {
            return true;
        }

        public bool UpdateDBData()
        {
            return true;
        }

        public bool DeleteDBData()
        {
            return true;
        }

        public ICollection GetDBData()
        {
            return null;
        }

        public ICollection GetDBData(Guid uqId)
        {
            return null;
        }

        public ICollection GetDBData(string strCondition)
        {
            return null;
        }

        private void InitializeDataAccessLayer()
        {
            string strTempConnection = InitializeConnection(CONNECTION_STRING);

            SQL_CONNECTION = new SqlConnection(CONNECTION_STRING);
        }

        //TODO Initialize the SQL Connection 
        private string InitializeConnection(string strConnection)
        {
            return strConnection;
        }
    }
}
