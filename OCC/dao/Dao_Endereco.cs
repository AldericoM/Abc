using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCC.basicas;

namespace OCC.dao
{
    class Dao_endereco
    {
        private string strConect = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Aldérico\Desktop\bd_occ2.mdf;Integrated Security=True;Connect Timeout=30";

        private DataSet dataSet;
        private SqlDataAdapter adapter;
        private SqlConnection conection;

        public string inserirEndereco(Endereco en)
        {
            try
            {
                string strRua = en.Rua; int strNumero = en.Numero; string strBairro = en.Bairro;
                int strCep = en.Cep; string strCidade = en.Cidade; string strEstado = en.Estado;
                
                conection = new SqlConnection(strConect);                
                SqlCommand Command = new SqlCommand();
                Command.Connection = conection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = @"INSERT INTO endereco(rua, numero, bairro, cep, cidade, estado) 
                                       values(@rua, @numero, @bairro, @cep, @cidade, @estado)";

                SqlParameter prmRua = new SqlParameter("@rua", SqlDbType.VarChar);
                prmRua.Value = strRua;
                Command.Parameters.Add(prmRua);

                SqlParameter prmNumero = new SqlParameter("@numero", SqlDbType.Int);
                prmNumero.Value = strNumero;
                Command.Parameters.Add(prmNumero);

                SqlParameter prmBairro = new SqlParameter("@bairro", SqlDbType.VarChar);
                prmBairro.Value = strBairro;
                Command.Parameters.Add(prmBairro);

                SqlParameter prmCep = new SqlParameter("@cep", SqlDbType.Int);
                prmCep.Value = strCep;
                Command.Parameters.Add(prmCep);

                SqlParameter prmCidade = new SqlParameter("@cidade", SqlDbType.VarChar);
                prmCidade.Value = strCidade;
                Command.Parameters.Add(prmCidade);

                SqlParameter prmEstado = new SqlParameter("@estado", SqlDbType.VarChar);
                prmEstado.Value = strEstado;
                Command.Parameters.Add(prmEstado);

                conection.Open();
                Command.ExecuteNonQuery();

                return "Endereco inserido com sucesso!";
            }
            catch (SqlException e)
            {
                return e.ToString();
            }
            finally
            {
                conection.Close();
            }
        }

        public string atualizarEndereco(Endereco en)
        {
            try
            {
                int strIdEndereco = en.IdEndereco;
                string strRua = en.Rua; int strNumero = en.Numero; string strBairro = en.Bairro;
                int strCep = en.Cep; string strCidade = en.Cidade; string strEstado = en.Estado;

                conection = new SqlConnection(strConect);
                SqlCommand Command = new SqlCommand();
                Command.Connection = conection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = @"UPDATE endereco set rua=@rua, numero=@numero, bairro=@bairro,
                                                            cep=@cep, cidade=@cidade, estado=@estado
                                                            WHERE idEndereco=@idEndereco";

                SqlParameter prmRua = new SqlParameter("@rua", SqlDbType.VarChar);
                prmRua.Value = strRua;
                Command.Parameters.Add(prmRua);

                SqlParameter prmNumero = new SqlParameter("@numero", SqlDbType.VarChar);
                prmNumero.Value = strNumero;
                Command.Parameters.Add(prmNumero);

                SqlParameter prmBairro = new SqlParameter("@bairro", SqlDbType.VarChar);
                prmBairro.Value = strBairro;
                Command.Parameters.Add(prmBairro);

                SqlParameter prmCep = new SqlParameter("@cep", SqlDbType.Int);
                prmCep.Value = strCep;
                Command.Parameters.Add(prmCep);

                SqlParameter prmCidade = new SqlParameter("@cidade", SqlDbType.VarChar);
                prmCidade.Value = strCidade;
                Command.Parameters.Add(prmCidade);

                SqlParameter prmEstado = new SqlParameter("@estado", SqlDbType.VarChar);
                prmEstado.Value = strEstado;
                Command.Parameters.Add(prmEstado);

                SqlParameter prmIdEndereco = new SqlParameter("@idEndereco", SqlDbType.Int);
                prmIdEndereco.Value = strIdEndereco;
                Command.Parameters.Add(prmIdEndereco);

                conection.Open();
                Command.ExecuteReader();

                return "Endereco atualizado com suuuucesso!";
            }
            catch (SqlException e)
            {
                return e.ToString();
            }
            finally
            {
                conection.Close();
            }
        }

        public void removerEndereco(int idEndereco)
        {
            try
            {
                int strIdEndereco = idEndereco;
                conection = new SqlConnection(strConect);
                conection.Open();
                SqlCommand Command = new SqlCommand();
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = @"DELETE FROM endereco WHERE idEndereco = @idEndereco";

                SqlParameter prmIdEndereco = new SqlParameter("@idEndereco", SqlDbType.Int);
                prmIdEndereco.Value = idEndereco;
                Command.Parameters.Add(prmIdEndereco);

                Command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                e.ToString();
            }
            finally
            {
                conection.Close();
            }
        }

        public DataSet getListEndereco()
        {
            conection = new SqlConnection(strConect);
            conection.Open();
            SqlCommand Command = new SqlCommand();
            Command.Connection = conection;
            Command.CommandType = System.Data.CommandType.Text;
            Command.CommandText = @"SELECT * FROM endereco";
            SqlDataReader reader;
            reader = Command.ExecuteReader();

            DataSet dataSet = new DataSet();
            do
            {
                // Create new data table

                DataTable schemaTable = reader.GetSchemaTable();
                DataTable dataTable = new DataTable();

                if (schemaTable != null)
                {
                    // A query returning records was executed

                    for (int i = 0; i < schemaTable.Rows.Count; i++)
                    {
                        DataRow dataRow = schemaTable.Rows[i];
                        // Create a column name that is unique in the data table
                        string columnName = (string)dataRow["ColumnName"]; //+ "<C" + i + "/>";
                        // Add the column definition to the data table
                        DataColumn column = new DataColumn(columnName, (Type)dataRow["DataType"]);
                        dataTable.Columns.Add(column);
                    }

                    dataSet.Tables.Add(dataTable);
                    // Fill the data table we just created
                    while (reader.Read())
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                            dataRow[i] = reader.GetValue(i);
                        dataTable.Rows.Add(dataRow);
                    }
                }
                else
                {
                    // No records were returned

                    DataColumn column = new DataColumn("RowsAffected");
                    dataTable.Columns.Add(column);
                    dataSet.Tables.Add(dataTable);
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = reader.RecordsAffected;
                    dataTable.Rows.Add(dataRow);
                }
            }
            while (reader.NextResult());
            conection.Close();
            return dataSet;
        }


    }
}
