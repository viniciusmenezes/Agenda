using AgendaApi.Contexto;
using AgendaApi.Entidades;
using AgendaApi.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaApi.Serviços
{
    public class ContatosService : iContatosService
    {
        private AppDbContext _contexto;

        public ContatosService(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public dynamic Contatos()
        {
            return _contexto.Contato.ToList(); //retorna todos os contatos
        }

        public dynamic BuscarContato(int id)
        {
            return _contexto.Contato.FirstOrDefault(c => c.Id == id); //busca um contato pelo nome
        }

        public dynamic Pesquisar(string nome)
        {
            return _contexto.Contato.FirstOrDefault(c => c.Nome == nome); //busca um contato pelo nome
        }

        public dynamic NovoContato(dynamic contato)
        {
            try
            {

                _contexto.Add(JsonConvert.DeserializeObject<Contato>(contato.ToString()));
            }catch(Exception e)
            {

            }
            return _contexto.SaveChanges();
        }

        public dynamic EditarContato(dynamic contato)
        {
            try
            {
                Contato obj = JsonConvert.DeserializeObject<Contato>(contato.ToString());
                var cont = _contexto.Contato.FirstOrDefault(c => c.Id == obj.Id);
                cont.Nome = obj.Nome;
                cont.Email = obj.Email;
                cont.Telefone = obj.Telefone;

                _contexto.Contato.Update(cont);
            }catch(Exception e)
            {

            }
            return _contexto.SaveChanges();
        }

        public dynamic ExcluirContato(int id)
        {
            var contato = _contexto.Contato.FirstOrDefault(c => c.Id == id);
            try
            {
                _contexto.Contato.Remove(contato);
            }
            catch (Exception e) { }
            return _contexto.SaveChangesAsync();

        }
    }
}
