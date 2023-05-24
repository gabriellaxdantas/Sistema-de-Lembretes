using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lembretes
{

    public partial class Lembretes : Form
    {
        // Lita do tipo Lembrete
        private List<Lembrete> listaLembretes = new List<Lembrete>();
        public Lembretes()
        {
            InitializeComponent();
        }

        private void Lembretes_Load(object sender, EventArgs e)
        {
            dataLembrete.MinDate = DateTime.Today;
            dataLembrete.Format = DateTimePickerFormat.Short;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = nomeLembrete.Text;
            DateTime data = dataLembrete.Value.Date;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Defina um nome para o lembrete.");
                return;
            }

            if (data < DateTime.Today)
            {
                MessageBox.Show("Selecione uma data válida (hoje ou futura).");
                return;
            }

            Lembrete lembrete = new Lembrete
            {
                Nome = nome,
                Data = data
            };

            listaLembretes.Add(lembrete);

            nomeLembrete.Clear();
            dataLembrete.Value = DateTime.Today;

            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            // juntar os lembretes por data
            var grupoLembrete = listaLembretes.GroupBy(l => l.Data.Date).OrderBy(g => g.Key);

            List<Lembrete> lembretesOrdenados = grupoLembrete.SelectMany(g => g.ToList()).ToList();


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lembretesOrdenados;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // pega a linha selecionada pelo usuario
                int indiceLinha = dataGridView1.SelectedRows[0].Index;

                // remove o lembrete selecionado
                listaLembretes.RemoveAt(indiceLinha);

                AtualizarDataGridView();
            }

            else
            {
                MessageBox.Show("Clique em um lembrete para remove-lo");
            }
        }
    }

    // classe Lembrete
    public class Lembrete
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
    }
}
