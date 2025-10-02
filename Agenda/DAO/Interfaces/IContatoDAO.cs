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
        public bool InserirContato(Contato input);

        public bool AlterarContato(Contato input);

        public void DeletarContato(int id);

        public List<Contato> ObterContatos();

        public Contato ObterContatoPorId(int id);
    }
}
