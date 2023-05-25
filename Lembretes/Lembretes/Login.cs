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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            mostrarSenha.Checked= true; 
        }

        List<Usuario> listaUsuarios = new List<Usuario>();

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void mostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            SetPasswordChar();
        }
        private void SetPasswordChar()
        {
            senhaLogin.UseSystemPasswordChar = !mostrarSenha.Checked;
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Salva os usuários no XML
            listaUsuarios = CarregarUsuarioXML();

            // Procura o usuário nos dados salvos
            Usuario usuario = listaUsuarios.FirstOrDefault(u => u.Email == emailLogin.Text && u.Senha == senhaLogin.Text);

            // Se tiver o usuário
            if (usuario != null)
            {
                // Mensagem de boas-vindas
                MessageBox.Show("Bem-vindo " + usuario.Nome + "!");

                // Fecha o login
                this.Hide();
                List<LembreteItem> lembretesUsuario = CarregarLembretesUsuario(usuario);

                // Abre a tela de lembretes
                Lembretes formulariop = new Lembretes(usuario, lembretesUsuario);
                formulariop.Show();
            }
            else
            {
                MessageBox.Show("E-mail ou senha inválidos");
            }
        }

        private List<LembreteItem> CarregarLembretesUsuario(Usuario usuario)
        {
            List<LembreteItem> lembretesUsuario = new List<LembreteItem>();

            if (File.Exists(usuario.ArquivoLembretes))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<LembreteItem>));

                using (StreamReader reader = new StreamReader(usuario.ArquivoLembretes))
                {
                    lembretesUsuario = (List<LembreteItem>)serializer.Deserialize(reader);
                }
            }

            return lembretesUsuario;
        }



        private List<Usuario> CarregarUsuarioXML()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            if (File.Exists("usuario.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));

                using (StreamReader reader = new StreamReader("usuario.xml"))
                {
                    listaUsuarios = (List<Usuario>)serializer.Deserialize(reader);
                }
            }

            return listaUsuarios;
        }

        private void facaCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Redirecionar para a tela de cadastro
                Cadastro Cadastro = new Cadastro();
                Cadastro.Show();
                this.Hide();
        }
    }
}
