using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dio_appSimplesCadastroDeSeries.Classes;

namespace dio_appSimplesCadastroDeSeries
{
    public partial class FormVisualizarSerie : Form
    {
        private Series Serie{ set; get; }
        public FormVisualizarSerie(Series serie)
        {
            Serie = serie;
            InitializeComponent();
        }

        private void VisualizarSerie_Load(object sender, EventArgs e)
        {
            SetarSerie(Serie);            
        }

        private void SetarSerie(Series serie)
        {
            visualizaId.Text = "ID: " + serie.retornaId();
            visualizaName.Text = "Name:  " + serie.retornaName();
            visualizaDescricao.Text = "Descrição: " + serie.retornaDescription();
            visualizaStartSerie.Text = "Início da série: " + serie.retornaStartSerie();
            visualizarGenero.Text = "Genero: " + serie.retornaGenero();
        }
    }
}
