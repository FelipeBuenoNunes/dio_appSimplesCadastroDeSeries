using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dio_appSimplesCadastroDeSeries.Classes;
using dio_appSimplesCadastroDeSeries.Interface;


namespace dio_appSimplesCadastroDeSeries.Repositorio
{
    class RepositorioSeries : IRepositorio
    {
        readonly List<Series> listaSeries = new();
        

        private int id = 0;
        public void addSerie(string name, string description, int startSerie, string genero)
        {
            Series newSerie = new Series(id, name, description, startSerie, genero);
            listaSeries.Add(newSerie);
            id++;
        }
        public string retornaAll(int id)
        {
            string retorno = "Nome da série: " + listaSeries[id].retornaName();
            retorno += "\nDescrição da série: " + listaSeries[id].retornaDescription();
            retorno += "\nAno de início da série: " + listaSeries[id].retornaStartSerie();
            retorno += "\nGenero: : " + listaSeries[id].retornaGenero();
            return retorno;
        }
        public Series retornaSerieId(int id)
        {
            return listaSeries[id];
        }

        public List<Series> retornaLista()
        {
            return listaSeries;
        }

        public void removeSerie(int ID)
        {
            listaSeries.Remove(retornaSerieId(ID));
        }
    }
}
