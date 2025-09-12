using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Agenda.Repositorios
{
    public class ContatoRepositorio
    {



        public void InserirContato()
        {
            string stringConexao = "Host=localhost;Database=dbAgenda;Username=postgres;Password=123456;";
            string query = "INSERT INTO contato (nome, email, telefone) VALUES (@nome, @email, @telefone);";
            using (var con = new NpgsqlConnection(stringConexao))
            {

                //  var con = new NpgsqlConnection(stringConexao);
                try
                {
                    con.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, con))
                    {

                        command.Parameters.AddWithValue("nome", "Alex Lopes");
                        command.Parameters.AddWithValue("email", "contato@sanklo.com.br");
                        command.Parameters.AddWithValue("telefone", "17993300758");

                        command.ExecuteNonQuery();



                    }
                    Console.WriteLine("Contato adicionado com sucesso");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
              
            }
        }

        public void AlterarContato()
        {
            string stringConexao = "Host=localhost;Database=dbAgenda;Username=postgres;Password=123456;";

            string query = "update contato set nome = @nome  ,email = @email ,telefone = @telefone where id_contato = @id  ";      




            using (var con = new NpgsqlConnection(stringConexao))
            {
                try
                {
                    con.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("nome", "Antonio Alex Lopes");
                        command.Parameters.AddWithValue("email", "antonio.lopes@docente.unip.br");
                        command.Parameters.AddWithValue("telefone", "(16) 12121211");
                        command.Parameters.AddWithValue("id", 4);

                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine("Contato alterado com sucesso");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }

        public void DeletarContato()
        {
            string stringConexao = "Host=localhost;Database=dbAgenda;Username=postgres;Password=123456;";

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
            string stringConexao = "Host=localhost;Database=dbAgenda;Username=postgres;Password=123456;";

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
