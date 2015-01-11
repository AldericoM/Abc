using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using OCC.basicas;

namespace OCC.dao
{
    class Dao_pessoa
    {
        private string strConect = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Aldérico\Desktop\bd_occ2.mdf;Integrated Security=True;Connect Timeout=30";
        //private string strConect = @"Data Source=(LocalBD)\v11.0;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\bd_occ.mdf;Integrated Security=True;Connect Timeout=30";
        private DataSet dataSet;
        private SqlDataAdapter adapter;
        private SqlConnection conection;

        public string inserirPessoa(Pessoa p)
        {
            try
            {
                int strCodigo = p.Codigo; int strIdEnderecoPessoa = p.IdEnderecoPessoa; string strTipoPessoa = p.TipoPessoa; string strSexo = p.TipoSexo; string strNome = p.Nome;
                int strRg = p.Rg; int strCpf = p.Cpf; string strEstadoCivil = p.EstadoCivil; int strIdade = p.Idade;
                int strTelefone = p.Telefone; int strCelular = p.Celular; int strWhatsapp = p.Whatsapp;
                string strEmail = p.Email; string strRedeSocial = p.RedeSocial; string strDataCadastro = p.DataCadastro; string strDataNascimento = p.DataNascimento;
                string strObservacao = p.ObservacaoPessoa;

                conection = new SqlConnection(strConect);
                SqlCommand Command = new SqlCommand();
                Command.Connection = conection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = @"INSERT INTO pessoa(endereco_idEndereco, codigo, tipoDePessoa, nome, rg, cpf, estado_civil, idade, telefone, celular, whatsapp, email, redeSocial, data_nascimento, data_cadastro) values(@endereco_idEndereco, @codigo, @tipoDePessoa, @nome, @rg, @cpf, @estado_civil, @idade, @telefone, @celular, @whatsapp, @email, @redeSocial, @data_nascimento, @data_cadastro)";

                SqlParameter prmCodigo = new SqlParameter("@codigo", SqlDbType.Int);
                prmCodigo.Value = strCodigo;
                Command.Parameters.Add(prmCodigo);

                SqlParameter prmIdEnderecoPessoa = new SqlParameter("@endereco_idEndereco", SqlDbType.Int);
                prmIdEnderecoPessoa.Value = strIdEnderecoPessoa;
                Command.Parameters.Add(prmIdEnderecoPessoa);

                SqlParameter prmTipoPessoa = new SqlParameter("@tipoDePessoa", SqlDbType.VarChar);
                prmTipoPessoa.Value = strTipoPessoa;
                Command.Parameters.Add(prmTipoPessoa);

                SqlParameter prmSexo = new SqlParameter("@sexo", SqlDbType.VarChar);
                prmSexo.Value = strSexo;
                Command.Parameters.Add(prmSexo);

                SqlParameter prmNome = new SqlParameter("@nome", SqlDbType.VarChar);
                prmNome.Value = strNome;
                Command.Parameters.Add(prmNome);

                SqlParameter prmRg = new SqlParameter("@rg", SqlDbType.Int);
                prmRg.Value = strRg;
                Command.Parameters.Add(prmRg);

                SqlParameter prmCpf = new SqlParameter("@cpf", SqlDbType.Int);
                prmCpf.Value = strCpf;
                Command.Parameters.Add(prmCpf);

                SqlParameter prmEstadoCivil = new SqlParameter("@estado_civil", SqlDbType.VarChar);
                prmEstadoCivil.Value = strEstadoCivil;
                Command.Parameters.Add(prmEstadoCivil);

                SqlParameter prmIdade = new SqlParameter("@idade", SqlDbType.Int);
                prmIdade.Value = strIdade;
                Command.Parameters.Add(prmIdade);

                SqlParameter prmTelefone = new SqlParameter("@telefone", SqlDbType.Int);
                prmTelefone.Value = strTelefone;
                Command.Parameters.Add(prmTelefone);

                SqlParameter prmCelular = new SqlParameter("@celular", SqlDbType.Int);
                prmCelular.Value = strCelular;
                Command.Parameters.Add(prmCelular);

                SqlParameter prmWhatsapp = new SqlParameter("@whatsapp", SqlDbType.Int);
                prmWhatsapp.Value = strWhatsapp;
                Command.Parameters.Add(prmWhatsapp);

                SqlParameter prmEmail = new SqlParameter("@email", SqlDbType.VarChar);
                prmEmail.Value = strEmail;
                Command.Parameters.Add(prmEmail);
                
                SqlParameter prmRedeSocial = new SqlParameter("@redeSocial", SqlDbType.VarChar);
                prmRedeSocial.Value = strRedeSocial;
                Command.Parameters.Add(prmRedeSocial);

                SqlParameter prmDataCadastro = new SqlParameter("@data_cadastro", SqlDbType.VarChar);
                prmDataCadastro.Value = strDataCadastro;
                Command.Parameters.Add(prmDataCadastro);

                SqlParameter prmDataNascimento = new SqlParameter("@data_nascimento", SqlDbType.VarChar);
                prmDataNascimento.Value = strDataNascimento;
                Command.Parameters.Add(prmDataNascimento);

                conection.Open();
                Command.ExecuteNonQuery();
            
                return "Pessoa Cadastrada com sucesso!";
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

        public string atualizarPessoa(Pessoa p)
        {
            try
            {
                int strIdPessoa = p.IdPessoa;
                int strCodigo = p.Codigo; int strIdEnderecoPessoa = p.IdEnderecoPessoa; string strTipoPessoa = p.TipoPessoa; string strSexo = p.TipoSexo; string strNome = p.Nome;
                int strRg = p.Rg; int strCpf = p.Cpf; string strEstadoCivil = p.EstadoCivil; int strIdade = p.Idade;
                int strTelefone = p.Telefone; int strCelular = p.Celular; int strWhatsapp = p.Whatsapp;
                string strEmail = p.Email; string strRedeSocial = p.RedeSocial; string strDataCadastro = p.DataCadastro; string strDataNascimento = p.DataNascimento;
                string strObservacao = p.ObservacaoPessoa;

                conection = new SqlConnection(strConect);
                SqlCommand Command = new SqlCommand();
                Command.Connection = conection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = @"UPDATE pessoa SET endereco_idEndereco=@endereco_idEndereco, codigo=@codigo, tipoDePessoa=@tipoDePessoa, nome=@nome, rg=@rg, cpf=@cpf, estado_civil=@estado_civil, idade=@idade, telefone=@telefone, celular=@celular, whatsapp=@whatsapp, email=@email, redeSocial=@redeSocial, data_nascimento=@data_nascimento, data_cadastro=@data_cadastro WHERE idPessoa=@idPessoa";

                SqlParameter prmIdPessoa = new SqlParameter("@idPessoa", SqlDbType.Int);
                prmIdPessoa.Value = strIdPessoa;
                Command.Parameters.Add(prmIdPessoa);

                SqlParameter prmIdEnderecoPessoa = new SqlParameter("@endereco_idEndereco", SqlDbType.Int);
                prmIdEnderecoPessoa.Value = strIdEnderecoPessoa;
                Command.Parameters.Add(prmIdEnderecoPessoa);

                SqlParameter prmCodigo = new SqlParameter("@codigo", SqlDbType.Int);
                prmCodigo.Value = strCodigo;
                Command.Parameters.Add(prmCodigo);

                SqlParameter prmTipoPessoa = new SqlParameter("@tipoDePessoa", SqlDbType.VarChar);
                prmTipoPessoa.Value = strTipoPessoa;
                Command.Parameters.Add(prmTipoPessoa);

                SqlParameter prmSexo = new SqlParameter("@sexo", SqlDbType.VarChar);
                prmSexo.Value = strSexo;
                Command.Parameters.Add(prmSexo);

                SqlParameter prmNome = new SqlParameter("@nome", SqlDbType.VarChar);
                prmNome.Value = strNome;
                Command.Parameters.Add(prmNome);

                SqlParameter prmRg = new SqlParameter("@rg", SqlDbType.Int);
                prmRg.Value = strRg;
                Command.Parameters.Add(prmRg);

                SqlParameter prmCpf = new SqlParameter("@cpf", SqlDbType.Int);
                prmCpf.Value = strCpf;
                Command.Parameters.Add(prmCpf);

                SqlParameter prmEstadoCivil = new SqlParameter("@estado_civil", SqlDbType.VarChar);
                prmEstadoCivil.Value = strEstadoCivil;
                Command.Parameters.Add(prmEstadoCivil);

                SqlParameter prmIdade = new SqlParameter("@idade", SqlDbType.Int);
                prmIdade.Value = strIdade;
                Command.Parameters.Add(prmIdade);

                SqlParameter prmTelefone = new SqlParameter("@telefone", SqlDbType.Int);
                prmTelefone.Value = strTelefone;
                Command.Parameters.Add(prmTelefone);

                SqlParameter prmCelular = new SqlParameter("@celular", SqlDbType.Int);
                prmCelular.Value = strCelular;
                Command.Parameters.Add(prmCelular);

                SqlParameter prmWhatsapp = new SqlParameter("@whatsapp", SqlDbType.Int);
                prmWhatsapp.Value = strWhatsapp;
                Command.Parameters.Add(prmWhatsapp);

                SqlParameter prmEmail = new SqlParameter("@email", SqlDbType.VarChar);
                prmEmail.Value = strEmail;
                Command.Parameters.Add(prmEmail);

                SqlParameter prmRedeSocial = new SqlParameter("@redeSocial", SqlDbType.VarChar);
                prmRedeSocial.Value = strRedeSocial;
                Command.Parameters.Add(prmRedeSocial);

                SqlParameter prmDataNascimento = new SqlParameter("@data_nascimento", SqlDbType.VarChar);
                prmDataNascimento.Value = strDataNascimento;
                Command.Parameters.Add(prmDataNascimento);

                SqlParameter prmDataCadastro = new SqlParameter("@data_cadastro", SqlDbType.VarChar);
                prmDataCadastro.Value = strDataCadastro;
                Command.Parameters.Add(prmDataCadastro);

                SqlParameter prmObservacao = new SqlParameter("@observacao", SqlDbType.VarChar);
                prmObservacao.Value = strObservacao;
                Command.Parameters.Add(prmObservacao);

                conection.Open();
                Command.ExecuteReader();

                return "Pessoa Atualizada com sucesso!";
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

        public void removerAluno(int idPessoa)
        {
            try
            {
                int strIdPessoa = idPessoa;
                conection = new SqlConnection(strConect);
                conection.Open();
                SqlCommand Command = new SqlCommand();
                Command.Connection = conection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = @"DELETE FROM pessoa WHERE idPessoa=@idPessoa";

                SqlParameter prmIdPessoa = new SqlParameter("@idPessoa", SqlDbType.Int);
                prmIdPessoa.Value = strIdPessoa;
                Command.Parameters.Add(prmIdPessoa);

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

        public DataSet getListarPessoa()
        {
            conection = new SqlConnection(strConect);
            conection.Open();
            SqlCommand Command = new SqlCommand();
            Command.Connection = conection;
            Command.CommandType = System.Data.CommandType.Text;
            Command.CommandText = @"SELECT * FROM pessoa";
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
