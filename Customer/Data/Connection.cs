﻿using Oracle.ManagedDataAccess.Client;
using System;


namespace LoanMs.Data
{
    public class Connection
    {
        static OracleConnection conn;
        public static OracleConnection GetConnection()
        {
            conn = new OracleConnection("Data Source = localhost:1521/XEPDB1; User id = LOAN; Password = 123");
            if (conn != null)
            {
                conn.Open();
            }
            return conn;
        }
    }
}
