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

        public void DeletarContato(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Contato> ObterContatos()
        {
            throw new NotImplementedException();
        }
    }
}
