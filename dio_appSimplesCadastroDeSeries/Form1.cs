using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dio_appSimplesCadastroDeSeries.Repositorio;
using dio_appSimplesCadastroDeSeries.Classes;
using dio_appSimplesCadastroDeSeries.Enumerador;

namespace dio_appSimplesCadastroDeSeries
{
    public partial class Form1 : Form
    {
        private int id = 0;
        public Form1()
        {
            InitializeComponent();
            iniciar();
        }

        //Iniciar partes do programa
        private void iniciar()
        {
            foreach(var i in Enum.GetValues(typeof(Generos)))
            {
                comboGeneros.Items.Add(i);
            }

            comboNames.Items.Clear();
            foreach (Series series in repositorio.retornaLista())
            {
                comboNames.Items.Add(series.retornaName());
            }
            contagem.Text = id.ToString();
        }

        private void atualizar()
        {
            comboNames.Items.Clear();
            foreach (Series series in repositorio.retornaLista())
            {
                comboNames.Items.Add(series.retornaName());
            }
            contagem.Text = id.ToString();
        }

        private void textBox1_TextChanged(object sesnder, EventArgs e)
        {
        }

        RepositorioSeries repositorio = new RepositorioSeries();


        private void btRegister_Click(object sender, EventArgs e)
        {
            try
            {
                repositorio.addSerie(seriesName.Text, seriesDescription.Text, int.Parse(seriesStart.Text), comboGeneros.Text);
                MessageBox.Show("Cadastrado com sucesso");
                comboNames.Items.Add(seriesName.Text);
                id++;
                contagem.Text = id.ToString();
                seriesName.Clear();
                seriesDescription.Clear();
                seriesStart.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Algo foi digitado incorretamente, verifique os dados e digite corretamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void comboGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void visualizarSerie_Click(object sender, EventArgs e)
        {
            try
            {
                FormVisualizarSerie visualizarSerie = new(repositorio.retornaSerieId(comboNames.SelectedIndex));
                visualizarSerie.ShowDialog();
             }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Está série não está cadastrada");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FormEditar form = new(repositorio.retornaSerieId(comboNames.SelectedIndex));
                form.ShowDialog();
                atualizar();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Está série não está cadastrada");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void excluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                repositorio.removeSerie(comboNames.SelectedIndex);
                id--;
                atualizar();
                MessageBox.Show("Série excluida com sucesso");
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Série ja excluida ou não existente");
            }
            catch(Exception)
            {
                MessageBox.Show("Algo deu errado");
            }
        }
    }
}




