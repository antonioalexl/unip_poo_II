using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IContatoDAO
    {
        public bool Inserir(Contato input);

        public bool Alterar(Contato input);

        public bool Excluir(int id);


        public List<Contato> ObterTodos();

        public Contato ObterPorId(int id);


        public bool SalvarContato(Contato input);
    }
}
