using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dio_appSimplesCadastroDeSeries.Classes;

namespace dio_appSimplesCadastroDeSeries.Interface
{
    public interface IRepositorio
    {
        List<Series> retornaLista();
        void addSerie(string name, string description, int startSerie, string genero);
        Series retornaSerieId(int id);
        public string retornaAll(int id);
        void removeSerie(int ID);
    }
}
