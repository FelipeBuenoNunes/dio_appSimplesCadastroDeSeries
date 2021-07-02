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
using dio_appSimplesCadastroDeSeries.Enumerador;

namespace dio_appSimplesCadastroDeSeries
{
    public partial class FormEditar : Form
    {
        public Series serie { set;  get; }
        public FormEditar(Series series)
        {
            InitializeComponent();
            serie = series;
            setarLabel();
            setarGeneros();
        }

        private void setarLabel()
        {
            oldName.Text = "Nome: " + serie.retornaName();
            oldDescription.Text = "Descrição: " + serie.retornaDescription();
            oldGenero.Text = "Genero: " + serie.retornaGenero();
            oldStartSerie.Text = "Início da série: " + serie.retornaStartSerie();
        }

        private void setarGeneros()
        {
            foreach (var i in Enum.GetValues(typeof(Generos)))
            {
                comboNewGenero.Items.Add(i);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                serie.editSerie(newName.Text, newDescription.Text, int.Parse(newStartSerie.Text), comboNewGenero.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Algo foi digitado incorretamente, verifique os dados e digite corretamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");
            }
            Close();
            
        }
    }
}
