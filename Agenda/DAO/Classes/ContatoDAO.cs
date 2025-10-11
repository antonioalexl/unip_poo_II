using DAO.Interfaces;
using Modelos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Classes
{
    public class ContatoDAO : IContatoDAO
    {
        string stringConexao = "Host=localhost;Database=dbAgenda;Username=postgres;Password=123456;";

        public bool Alterar(Contato input)
        {
            string query = "update contato set nome = @nome  ,email = @email ,telefone = @telefone, data_nascimento = @data_nascimento where id_contato = @id  ";


            using (var con = new NpgsqlConnection(stringConexao))
            {
                try
                {
                    con.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("nome", input.Nome);
                        command.Parameters.AddWithValue("email", input.Email);
                        command.Parameters.AddWithValue("telefone", input.Telefone);
                        command.Parameters.AddWithValue("id", input.Id_Contato);
                        command.Parameters.AddWithValue("data_nascimento", input.DataNascimento);


                        

                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public bool Excluir(int id)
        {
            string query = "delete from contato where id_contato  = @id;";


            using (var con = new NpgsqlConnection(stringConexao))
            {
                try
                {
                    con.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("id", id);
                        var linhasAfetadas = command.ExecuteNonQuery();

                        return true;

                    }
                }
                catch (Exception ex)
                {

                    throw (ex);
                }
            }
        }

        public bool Inserir(Contato input)
        {
            string query = "INSERT INTO contato (nome, email, telefone,data_nascimento) VALUES (@nome, @email, @telefone, @data_nascimento);";
            using (var con = new NpgsqlConnection(stringConexao))
            {

                try
                {
                    con.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, con))
                    {

                        command.Parameters.AddWithValue("nome", input.Nome);
                        command.Parameters.AddWithValue("email", input.Email);
                        command.Parameters.AddWithValue("telefone", input.Telefone);
                        command.Parameters.AddWithValue("data_nascimento", input.DataNascimento);

                        

                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        public Contato ObterPorId(int id)
        {
            string query = "SELECT * FROM contato WHERE id_contato = @id";
            Contato contato = null;

            using (var con = new NpgsqlConnection(stringConexao))
            {
                con.Open();

                using (var command = new NpgsqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // só espera um registro
                        {
                            contato = new Contato
                            {
                                Id_Contato = Convert.ToInt32(reader["id_contato"]),
                                Nome = reader["nome"] != DBNull.Value ? reader["nome"].ToString() : "",
                                Email = reader["email"] != DBNull.Value ? reader["email"].ToString() : "",
                                Telefone = reader["telefone"] != DBNull.Value ? reader["telefone"].ToString() : "",
                                 DataNascimento = reader["data_nascimento"] != DBNull.Value ? Convert.ToDateTime(reader["data_nascimento"]) : (DateTime?)null
                            };
                        }
                    }
                }
            }

            return contato;
        }

        public List<Contato> ObterTodos()
        {
            string query = "select * from contato";

            List<Contato> lstRetorno = new List<Contato>();

            using (var con = new NpgsqlConnection(stringConexao))
            {

                con.Open();
               
                using (var command = new NpgsqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {

                        //percorre todas as linhas
                        while (reader.Read())
                        {
                            //Criar um objeto do tipo contato
                            Contato contato = new Contato();
                            contato.Id_Contato = Convert.ToInt32(reader["id_contato"]);
                            contato.Nome = reader["nome"].ToString();
                            contato.Telefone = reader["telefone"].ToString();
                            contato.Email = reader["email"].ToString();
                            contato.DataNascimento = reader["data_nascimento"] != DBNull.Value ? Convert.ToDateTime(reader["data_nascimento"]) : (DateTime?)null;



                            //adicionar na lista
                            lstRetorno.Add(contato);

                        }
                      
                    }
                }
            }
            return lstRetorno;
        }
    }
}
