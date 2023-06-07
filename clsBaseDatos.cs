﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace pryBonaderoED
{
    public class clsBaseDatos
    {

        #region OleDb/CadenaConexion
        private OleDbConnection cnx = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataAdapter adap = new OleDbDataAdapter();


        //Conectarse a la base de datos mediante la cadena de conexion y declarar la variable
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";
        private string vSQL = "";
        #endregion

        #region Metodos

        public void Listar(DataGridView dgv)
        {
            try
            {
                cnx.ConnectionString = CadenaConexion;
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = "Libro";
                adap = new OleDbDataAdapter(cmd);
                DataSet DS = new DataSet();
                adap.Fill(DS, "Libro");
                dgv.DataSource = null;
                dgv.DataSource = DS.Tables["Libro"];
                cnx.Close();



            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        public void Listar(DataGridView dgv, string vSQL)
        {
            try
            {
                cnx.ConnectionString = CadenaConexion;
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = vSQL;
                adap = new OleDbDataAdapter(cmd);
                DataSet DS = new DataSet();
                adap.Fill(DS, "Resultado");
                dgv.DataSource = null;
                dgv.DataSource = DS.Tables["Resultado"];
                cnx.Close();



            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }





        #endregion


    }
}
