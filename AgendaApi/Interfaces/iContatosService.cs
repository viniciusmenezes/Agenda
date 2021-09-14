using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaApi.Interfaces
{
    public interface iContatosService
    {
        dynamic Contatos();
        dynamic BuscarContato(int id);
        dynamic Pesquisar(string nome);
        dynamic NovoContato(dynamic contato);
        dynamic EditarContato(dynamic contato);
        dynamic ExcluirContato(int id);
    }
}
