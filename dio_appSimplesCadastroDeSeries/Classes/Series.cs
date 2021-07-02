using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dio_appSimplesCadastroDeSeries.Classes.Base;

namespace dio_appSimplesCadastroDeSeries.Classes
{
    public class Series : SerieBase
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private int StartSerie { get; set; }
        private string Genero { get; set; }

        public Series(int id, string name, string description, int startSerie, string genero)
        {
            ID = id;
            Name = name;
            Description = description;
            StartSerie = startSerie;
            Genero = genero;
        }

        public string retornaAll()
        {
            string retorno = "Nome da série: " + Name;
            retorno += "\nDescrição da série: " + Description;
            retorno += "\nAno de início da série: " + StartSerie;
            retorno += "\nGenero: : " + Genero;
            return retorno;
        }

        public string retornaName()
        {
            return Name;
        }

        public string retornaDescription()
        {
            return Description;
        }

        public int retornaStartSerie()
        {
            return StartSerie;
        }

        public string retornaGenero()
        {
            return Genero;
        }

        public string retornaId()
        {
            return (ID + 1).ToString();
        }

        public void editSerie(string name, string description, int startSerie, string genero)
        {
            Name = name;
            Description = description;
            StartSerie = startSerie;
            Genero = genero;
        }

        public void editName(string name)
        {
            Name = name;
        }
        public void editDescription(string description)
        {
            Description = description;
        }
        
        public void editStart(int startSerie)
        {
            StartSerie = startSerie;
        }

    }
}
