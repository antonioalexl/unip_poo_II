using Aula06.Modelos;
using Aula06.Repositorios;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Agenda.Repositorios
{
    public class ContatoRepositorio
    {
        string stringConexao = AppSettings.ConnectionString;

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

        public void DeletarContato()
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

                        MessageBox.Show("Contato removido com sucesso, linhas removidas:" + linhasAfetadas);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.Message);

                }
            }
        }

        public void SelecionarContatos()
        {

            string query = "select * from contato";

            using (var con = new NpgsqlConnection(stringConexao))
            {

                con.Open();
                string resultado = "";
                using (var command = new NpgsqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {

                        //percorre todas as linhas
                        while (reader.Read())
                        {
                            //percorre todas as colunas da linha
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                //Console.WriteLine("{0}\t", reader[i]);
                                resultado += reader[i] + " ";
                                //resultado = Environment.NewLine;

                            }

                            Console.WriteLine();
                        }
                        MessageBox.Show(resultado);
                    }
                }
            }

        }
    }
}
