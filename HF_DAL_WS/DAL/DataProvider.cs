﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace HealthcareFamilyDAL
{
    public class DataProvider
    {
        private static SqlConnection _con;

        static DataProvider()
        {
            // Get connection string from web.conf or app.conf
            string strConnection = ConfigurationManager.ConnectionStrings["HeathCareFamilyDB"].ConnectionString;
            _con = new SqlConnection(strConnection);
        }

        public static DataTable ExecuteQuery(string strQuery)
        {
            DataTable resTable = new DataTable();

            try
            {
                _con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(strQuery, _con);

                adapter.Fill(resTable);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while excute SQL: " + ex.Message);
            }
            finally
            {
                _con.Close();
            }

            return resTable;
        }

        public static void ExecuteNonQuery(string strQuery)
        {
            try
            {
                _con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = _con;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while excute SQL: " + ex.Message);
            }
            finally
            {
                _con.Close();
            }
        }

        public static void ExecuteStoredProcedure(SqlCommand cmd)
        {
            try
            {
                _con.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while excute SQL: " + ex.Message);
            }
            finally
            {
                _con.Close();
            }
        }
    }
}
