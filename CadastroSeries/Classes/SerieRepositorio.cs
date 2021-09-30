using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroSeries.Interfaces;

namespace CadastroSeries
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade) //A Entidade pode ser considerada um OBJETO
        {
            listaSerie[id] = entidade; //O Index utiliza a ID recebida para atualizar a série
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir(); //Utilizamos o método excluir pra alterar a propriedade do campo excluido para True, mantendo o dado salvo
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade); //Adiciona a Entidade(nosso objeto) dentro da lista de série
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
