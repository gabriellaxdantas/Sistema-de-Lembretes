using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.DataFormats;

namespace Lembretes
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            mostrarSenha.Checked = true;

        }

        List<Usuario> listaUsuarios = new List<Usuario>();

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void SetPasswordChar()
        {
            senha.UseSystemPasswordChar = !mostrarSenha.Checked;
        }
        private void mostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            SetPasswordChar();
        }

        private void SalvarUsuarioXML(Usuario usuario)
        {
            // Ler os usuários existentes do arquivo XML, se houver
            List<Usuario> listaUsuarios = CarregarUsuarioXML();

            // Adicionar o novo usuário à lista
            listaUsuarios.Add(usuario);

            // Criar uma instância de XmlSerializer para a classe Usuario
            XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));

            // Abrir um fluxo de gravação para o arquivo XML
            using (StreamWriter writer = new StreamWriter("usuario.xml"))
            {
                // Serializar a lista de usuários atualizada e escrever os dados no fluxo de gravação
                serializer.Serialize(writer, listaUsuarios);

                // Fechar o fluxo de gravação
                writer.Close();
            }
        }

        private List<Usuario> CarregarUsuarioXML()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            // Verificar se o arquivo XML existe
            if (File.Exists("usuario.xml"))
            {
                // Criar uma instância de XmlSerializer para a classe Usuario
                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));

                // Ler o arquivo XML e desserializar os usuários
                using (StreamReader reader = new StreamReader("usuario.xml"))
                {
                    listaUsuarios = (List<Usuario>)serializer.Deserialize(reader);
                }
            }

            return listaUsuarios;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // validações
            if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(senha.Text) || string.IsNullOrEmpty(nome.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Por favor, insira um endereço de email válido.");
                return;
            }

            // Verificar se o usuário já existe
            if (UsuarioExiste(nome.Text, email.Text))
            {
                MessageBox.Show("Usuário já existe com o mesmo nome de usuário ou e-mail.");
                return;
            }

            Usuario novoUsuario = new Usuario();
            novoUsuario.Email = email.Text;
            novoUsuario.Senha = senha.Text;
            novoUsuario.Nome = nome.Text;

            novoUsuario.ArquivoLembretes = $"{novoUsuario.Nome}_lembretes.xml";

            SalvarUsuarioXML(novoUsuario);

            MessageBox.Show("Usuário salvo com sucesso!");

            Lembretes form = new Lembretes(novoUsuario, new List<LembreteItem>());

            // exibir a tela de lembretes
            form.Show();

            this.Hide();
        }

        private bool UsuarioExiste(string nome, string email)
        {
            List<Usuario> listaUsuarios = CarregarUsuarioXML();

            // Verificar se há algum usuário com o mesmo nome ou e-mail
            return listaUsuarios.Any(u => u.Nome == nome || u.Email == email);
        }

        private bool IsValidEmail(string email)
        {
            // Usar uma expressão regular para validar o formato de email
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void facaLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // redirecionar para a tela de login
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}