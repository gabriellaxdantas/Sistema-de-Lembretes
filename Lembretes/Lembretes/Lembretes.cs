using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lembretes
{
    public partial class Lembretes : Form
    {
        private string nomeUser;
        private List<LembreteItem> listaLembretes;
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private Usuario usuarioAtual;

        public Lembretes(Usuario usuario, List<LembreteItem> lembretes)
        {
            InitializeComponent();
            usuarioAtual = usuario;
            listaLembretes = lembretes;
            nomeUser = usuario.Nome;
        }

        private void Lembretes_Load(object sender, EventArgs e)
        {
            // como decisão de projeto, coloquei a data mínima possível para 
            // lembretes como a do dia atual, já que o usuário pode achar necessário
            // registrar um lembrete para o dia  atual
            dataLembrete.MinDate = DateTime.Today;
            // código para a data no futuro:
            // dataLembrete.MinDate = DateTime.Today.AddDays(1);
            dataLembrete.Format = DateTimePickerFormat.Short;

            // carrega o usuario e atualiza o grid view caso haja algo
            CarregarUsuarios();
            CarregarLembretes(); // Carrega os lembretes do usuário atual

            if (usuarioAtual.Lembretes == null)
            {
                usuarioAtual.Lembretes = new List<LembreteItem>();
            }
            else
            {
                listaLembretes = usuarioAtual.Lembretes;
            }

            AtualizarDataGridView(listaLembretes);
        }

        private void CarregarUsuarios()
        {
            // Verificar se o arquivo de usuários existe
            if (File.Exists("usuarios.xml"))
            {
                // cria uma instância de Xml Serializer para a classe List<Usuario>
                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));

                // lê o arquivo XML e desserializar a lista de usuários
                using (StreamReader reader = new StreamReader("usuarios.xml"))
                {
                    listaUsuarios = (List<Usuario>)serializer.Deserialize(reader);
                }
            }
        }

        private void SalvarUsuarios()
        {
            // cria uma instância de Xml Serializer para a classe List<Usuario>
            XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));

            // grava a lista de usuários no arquivo XML
            using (StreamWriter writer = new StreamWriter("usuarios.xml"))
            {
                serializer.Serialize(writer, listaUsuarios);
            }
        }

        private void CarregarLembretes()
        {
            // aqui acontece a verficação dos lembretes para o usuário atual
            // ele olha se há algum lembrete salvo no arquivo xml referente a esse usuário
            // Verifica se o arquivo de lembretes do usuário existe
            if (File.Exists(usuarioAtual.ArquivoLembretes))
            {
                // Cria uma instância de XmlSerializer para a classe List<Lembrete>
                XmlSerializer serializer = new XmlSerializer(typeof(List<LembreteItem>));

                // Lê o arquivo XML e desserializa a lista de lembretes do usuário
                using (StreamReader reader = new StreamReader(usuarioAtual.ArquivoLembretes))
                {
                    usuarioAtual.Lembretes = (List<LembreteItem>)serializer.Deserialize(reader);
                }
            }
            else
            {
                usuarioAtual.Lembretes = new List<LembreteItem>(); // Cria uma nova lista de lembretes para o usuário
            }
        }

        private void SalvarLembretes()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<LembreteItem>));

            using (StreamWriter writer = new StreamWriter(usuarioAtual.ArquivoLembretes))
            {
                serializer.Serialize(writer, usuarioAtual.Lembretes);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // pega o nome digitado no textBox e a data 
            // informada e atribui ao nome e data da classe
            string nome = nomeLembrete.Text;
            DateTime data = dataLembrete.Value.Date;

            // verificações de nome e data (não pode ter nome em branco
            // e a data tem que ser presente ou futura)
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

            // instanciando um novo lembrete
            LembreteItem lembrete = new LembreteItem
            {
                Nome = nome,
                Data = data,
                Usuario = usuarioAtual.Nome
            };

            // adicionando o lembrete ao usuario logado
            usuarioAtual.Lembretes.Add(lembrete);

            // limpa os campos
            nomeLembrete.Clear();
            dataLembrete.Value = DateTime.Today;

            // salva o lembrete e atualiza o grid view 
            SalvarLembretes();
            AtualizarDataGridView(usuarioAtual.Lembretes);
        }

        private void AtualizarDataGridView(List<LembreteItem> lembretes)
        {
            if (lembretes.Any())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lembretes.OrderBy(l => l.Data).ToList();
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Não há lembretes disponíveis.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // pega o índice da linha selecionada
                int indiceLinha = dataGridView1.SelectedRows[0].Index;

                // remove o lembrete da lista de lembretes do usuário atual
                usuarioAtual.Lembretes.RemoveAt(indiceLinha);

                // salva os lembretes atualizados
                SalvarLembretes();

                // atualiza o grid view
                AtualizarDataGridView(usuarioAtual.Lembretes);
            }
            else
            {
                MessageBox.Show("Clique em um lembrete para removê-lo.");
            }
        }
    }

    // cria a classe lembrete
    public class LembreteItem
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Usuario { get; set; }
    }
}
