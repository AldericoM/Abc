using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Common;
using System.Data;
using OCC.basicas;
using System.Data.SqlClient;

namespace OCC.dao
{
    class Dao_aluno
    {
        //private string strConect = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\bd_occ.mdf;Integrated Security=True; Connect Timeout=30;User Instance=False";

        private string strConect = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Aldérico\Desktop\bd_occ2.mdf;Integrated Security=True;Connect Timeout=30";
        
        //private string strConect = "server=AldericoPC/Aldérico/SQLEXPRESS; Database=bd_occ.mdf;Integrated Security=SSPI";

        //private string strConect = @"C:\Users\Aldérico\Desktop\bd_occ.mdf";

        private DataSet dataSet;
        private SqlDataAdapter adapter;
        private SqlConnection conection;

        public string inserirAluno(Aluno a)
        {
            try
            {
                int idPesso = a.IdPessoa; int idResponsavel = a.IdResponsavel; int idOrquestra = a.IdOrquestra;
                string strNome = a.Nome; string strInstrumento = a.Instrumento; string strMaestro = a.Maestro; string strMaestroAsssistente = a.MaestroAssistente;
                string strTurno = a.Turno; int strIdTurma = a.IdTurma; double strPeso = a.Peso; string strTamanhoCamisa = a.TamanhoCamisa;
                int strTamanhoCalsa = a.TamanhoCalsa; int strTamanhoSapato = a.TamanhoSapato; string strObservacoes = a.ObservacaoAluno;

                conection = new SqlConnection(strConect);                
                SqlCommand Command = new SqlCommand();
                Command.Connection = conection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = @"INSERT INTO aluno(pessoa_idPessoa, responsavel_idResponsavel, orquestra_idOrquestra, turma_idTurma, instrumento, maestro, maestro_assistente, turno, peso, tamanhoCamisa, tamanhoCalca, tamanhoSapato, observacoes) values(@pessoa_idPessoa, @responsavel_idResponsavel, @orquestra_idOrquestra, @idTurma, @instrumento, @maestro, @maestro_assistente, @turno, @peso, @tamanhoCamisa, @tamanhoCalca, @tamanhoSapato, @observacoes)";

                SqlParameter prmIdPessoa = new SqlParameter("@pessoa_idPessoa", SqlDbType.Int);
                prmIdPessoa.Value = idPesso;
                Command.Parameters.Add(prmIdPessoa);

                SqlParameter prmIdResponsavel = new SqlParameter("@responsavel_idResponsavel", SqlDbType.Int);
                prmIdResponsavel.Value = idResponsavel;
                Command.Parameters.Add(prmIdResponsavel);

                SqlParameter prmIdOrquestra = new SqlParameter("@orquestra_idOrquestra", SqlDbType.Int);
                prmIdOrquestra.Value = idOrquestra;
                Command.Parameters.Add(prmIdOrquestra);

                SqlParameter prmIdTurma = new SqlParameter("@idTurma", SqlDbType.Int);
                prmIdTurma.Value = strIdTurma;
                Command.Parameters.Add(prmIdTurma);

                SqlParameter prmInstrumento = new SqlParameter("@instrumento", SqlDbType.VarChar);
                prmInstrumento.Value = strInstrumento;
                Command.Parameters.Add(prmInstrumento);

                SqlParameter prmMaestro = new SqlParameter("@maestro", SqlDbType.VarChar);
                prmMaestro.Value = strMaestro;
                Command.Parameters.Add(prmMaestro);

                SqlParameter prmMaestroAssistente = new SqlParameter("@maestro_assistente", SqlDbType.VarChar);
                prmMaestroAssistente.Value = strMaestroAsssistente;
                Command.Parameters.Add(prmMaestroAssistente);

                SqlParameter prmTurno = new SqlParameter("@turno", SqlDbType.VarChar);
                prmTurno.Value = strTurno;
                Command.Parameters.Add(prmTurno);

                SqlParameter prmPeso = new SqlParameter("@peso", SqlDbType.Float);
                prmPeso.Value = strPeso;
                Command.Parameters.Add(prmPeso);

                SqlParameter prmTamanhoCamisa = new SqlParameter("@tamanhoCamisa", SqlDbType.VarChar);
                prmTamanhoCamisa.Value = strTamanhoCamisa;
                Command.Parameters.Add(prmTamanhoCamisa);

                SqlParameter prmTamanhoCalsa = new SqlParameter("@tamanhoCalca", SqlDbType.Int);
                prmTamanhoCalsa.Value = strTamanhoCalsa;
                Command.Parameters.Add(prmTamanhoCalsa);

                SqlParameter prmTamanhoSapato = new SqlParameter("@tamanhoSapato", SqlDbType.Int);
                prmTamanhoSapato.Value = strTamanhoSapato;
                Command.Parameters.Add(prmTamanhoSapato);

                SqlParameter prmObservacoes = new SqlParameter("@observacoes", SqlDbType.VarChar);
                prmObservacoes.Value = strObservacoes;
                Command.Parameters.Add(prmObservacoes);

                conection.Open();
                Command.ExecuteNonQuery();
                
                return "Aluno inserido com sucesso!";
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

        public void atualizarAluno(Aluno a)
        {
            try
            {
                int strIdAluno = a.IdAluno;
                int idPesso = a.IdPessoa; int idResponsave = a.IdResponsavel; int idOrquestra = a.IdOrquestra;
                string strNome = a.Nome; string strInstrumento = a.Instrumento; string strMaestro = a.Maestro; string strMaestroAsssistente = a.MaestroAssistente;
                string strTurno = a.Turno; string strTurma = a.Turno; double strPeso = a.Peso; string strTamanhoCamisa = a.TamanhoCamisa;
                int strTamanhoCalsa = a.TamanhoCalsa; int strTamanhoSapato = a.TamanhoSapato; string strObservacoes = a.ObservacaoAluno;

                conection = new SqlConnection(strConect);                
                SqlCommand Command = new SqlCommand();
                Command.Connection = conection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = @"UPDATE aluno SET instrumento=@instrumento, maestro=@maestro, maestro_assistente=@maestro_assistente, turno=@turno, turma=@turma, peso=@peso, tamanhoCamisa=@tamanhoCamisa,tamanhoCalca=@tamanhoCalca, tamanhoSapato=@tamanhoSapato, observacoes=@observacoes WHERE idAluno=@idAluno";

                SqlParameter prmIdAluno = new SqlParameter("@idAluno", SqlDbType.Int);
                prmIdAluno.Value = strIdAluno;
                Command.Parameters.Add(prmIdAluno);

                SqlParameter prmNome = new SqlParameter("@nome", SqlDbType.VarChar);
                prmNome.Value = strNome;
                Command.Parameters.Add(prmNome);

                SqlParameter prmIdPessoa = new SqlParameter("@pessoa_idPessoa", SqlDbType.Int);
                prmIdPessoa.Value = idPesso;
                Command.Parameters.Add(prmIdPessoa);

                SqlParameter prmIdResponsavel = new SqlParameter("@responsavel_idResponsavel", SqlDbType.Int);
                prmIdResponsavel.Value = idResponsave;
                Command.Parameters.Add(prmIdResponsavel);

                SqlParameter prmIdOrquestra = new SqlParameter("@orquestra_idOrquestra", SqlDbType.Int);
                prmIdOrquestra.Value = idOrquestra;
                Command.Parameters.Add(prmIdOrquestra);

                SqlParameter prmInstrumento = new SqlParameter("@instrumento", SqlDbType.VarChar);
                prmInstrumento.Value = strInstrumento;
                Command.Parameters.Add(prmInstrumento);

                SqlParameter prmMaestro = new SqlParameter("@maestro", SqlDbType.VarChar);
                prmMaestro.Value = strMaestro;
                Command.Parameters.Add(prmMaestro);

                SqlParameter prmMaestroAssistente = new SqlParameter("@maestro_assistente", SqlDbType.VarChar);
                prmMaestroAssistente.Value = strMaestroAsssistente;
                Command.Parameters.Add(prmMaestroAssistente);

                SqlParameter prmTurno = new SqlParameter("@turno", SqlDbType.VarChar);
                prmTurno.Value = strTurno;
                Command.Parameters.Add(prmTurno);

                SqlParameter prmTurma = new SqlParameter("@turma", SqlDbType.VarChar);
                prmTurma.Value = strTurma;
                Command.Parameters.Add(prmTurma);

                SqlParameter prmPeso = new SqlParameter("@peso", SqlDbType.Float);
                prmPeso.Value = strPeso;
                Command.Parameters.Add(prmPeso);

                SqlParameter prmTamanhoCamisa = new SqlParameter("@tamanhoCamisa", SqlDbType.VarChar);
                prmTamanhoCamisa.Value = strTamanhoCamisa;
                Command.Parameters.Add(prmTamanhoCamisa);

                SqlParameter prmTamanhoCalsa = new SqlParameter("@tamanhoCalca", SqlDbType.Int);
                prmTamanhoCalsa.Value = strTamanhoCalsa;
                Command.Parameters.Add(prmTamanhoCalsa);

                SqlParameter prmTamanhoSapato = new SqlParameter("@tamanhoSapato", SqlDbType.Int);
                prmTamanhoSapato.Value = strTamanhoSapato;
                Command.Parameters.Add(prmTamanhoSapato);

                SqlParameter prmObservacoes = new SqlParameter("@observacoes", SqlDbType.VarChar);
                prmObservacoes.Value = strObservacoes;
                Command.Parameters.Add(prmObservacoes);
                
                conection.Open();
                Command.ExecuteReader();

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

        public void removerAluno(int idAluno)
        {
            try
            {
                int strIdAluno = idAluno;
                conection = new SqlConnection(strConect);
                conection.Open();
                SqlCommand Command = new SqlCommand();
                Command.Connection = conection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = @"DELETE FROM aluno WHERE idAluno=@idAluno";

                SqlParameter prmIdAluno = new SqlParameter("@idAluno", SqlDbType.Int);
                prmIdAluno.Value = strIdAluno;
                Command.Parameters.Add(prmIdAluno);

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
        public SqlDataReader listarTudoAluno()
        {
            try
            {
                conection = new SqlConnection(strConect);
                conection.Open();
                SqlCommand Command = new SqlCommand();
                Command.Connection = conection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = @"SELECT * FROM aluno";

                SqlDataReader reader;
                reader = Command.ExecuteReader();
                conection.Close();
                return reader;
            }
            catch (SqlException e)
            {
                e.ToString();
                return null;
            }
            finally
            {
                conection.Close();
            }            
        }

        public DataSet getListarAluno()
        {
            conection = new SqlConnection(strConect);
            conection.Open();
            SqlCommand Command = new SqlCommand();
            Command.Connection = conection;
            Command.CommandType = System.Data.CommandType.Text;
            Command.CommandText = @"SELECT * FROM aluno";
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
