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
        string stringConexao = "";

        public bool AlterarContato(Contato input)
        {
            string query = "update contato set nome = @nome  ,email = @email ,telefone = @telefone where id_contato = @id  ";


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

        public bool DeletarContato(int id)
        {
            string query = "delete from contato where id_contato  = @id;";


            using (var con = new NpgsqlConnection(stringConexao))
            {
                try
                {
                    con.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("id", 4);
                        var linhasAfetadas = command.ExecuteNonQuery();
                        return linhasAfetadas > 0;

                        

                    }
                }
                catch (Exception ex)
                {

                    throw (ex);

                }
            }
        }

        public bool InserirContato(Contato input)
        {
            string query = "INSERT INTO contato (nome, email, telefone) VALUES (@nome, @email, @telefone);";
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

        public Contato ObterContatoPorId(int id)
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
                                Telefone = reader["telefone"] != DBNull.Value ? reader["telefone"].ToString() : ""
                            };
                        }
                    }
                }
            }

            return contato;
        }

        public List<Contato> ObterContatos()
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
                            Contato contato = new Contato();
                            contato.Id_Contato = Convert.ToInt32(reader["id_contato"]);
                            contato.Nome = reader["nome"] != DBNull.Value ? reader["nome"].ToString() : "";
                            contato.Email = reader["email"] != DBNull.Value ? reader["email"].ToString() : "";
                            contato.Telefone = reader["telefone"] != DBNull.Value ? reader["telefone"].ToString() : "";
                            lstRetorno.Add(contato);
                        }
                        
                    }
                }
            }
            return lstRetorno;
        }
    }
}
