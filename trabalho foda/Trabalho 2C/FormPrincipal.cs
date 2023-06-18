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

// Atenção: o arquivo executável (.exe) contendo o seu programa compilado assim como a pasta de Questões podem ser encontrados na pasta /bin
// Confira a pasta /bin

namespace Trabalho_2C
{
    public partial class FormPrincipal : Form
    {
        // Questão atual
        Questão questao;
        // diretorio atual
        string diretorioAtual;

        public FormPrincipal()
        {
            // Não precisa se preocupar aqui -----------------------

            // Inicializa os componentes do formulário (método interno que "arruma" os controles na tela de acordo com o que foi desenhado no Designer
            InitializeComponent();

            // Recebe o diretório em que o programa propriamente (arquivo .exe) está sendo executado
            diretorioAtual = Directory.GetCurrentDirectory();

            // Dado o diretório atual, cria um caminho que aponta para a pasta Questões
            diretorioAtual += @"\..\..\..\Questões\";

            // Método que retorna um vetor de strings contendo o diretório de todas as pastas que estão dentro da pasta Questões
            string[] diretorios = Directory.GetDirectories(diretorioAtual);

            // Percorre cada string dentro do vetor de strings
            for(int i = 0; i < diretorios.Length; i++)
            {
                // Para cada caminho, quero obter apenas o nome da disciplina
                string nomeDaDisciplina = diretorios[i].Remove(0, diretorioAtual.Length);
                // Vou adicionar o nome da disciplina aos itens da comboBox1
                cmbDisciplinas.Items.Add(nomeDaDisciplina);
            }
            // Não precisa se preocupar aqui -----------------------

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Não precisa se preocupar aqui -----------------------
            // Define o diretório da matéria selecionada na comboBox1
            string diretorioMateria = diretorioAtual + cmbDisciplinas.Text;
            // Obtém um vetor de strings contendo o diretório para todos os arquivos
            string[] arquivos = Directory.GetFiles(diretorioMateria, "*.txt");
            // Não precisa se preocupar aqui -----------------------

            // Caso não haja nenhum arquivo no diretorio da matéria selecionada, mostrar uma mensagem ao usuário
            if (arquivos.Length == 0) MessageBox.Show("Não há questões na pasta selecionada!");
            // Caso haja algum arquivo no diretorio da matéria selecionada, o enunciado do primeiro exercício é carregado como exemplo
            else
            {
                // Cria objeto da classe Questão
                questao = new Questão();

                // Cria um leitor para ler as informações da questão
                StreamReader leitor = new StreamReader(arquivos[0]);

                // Preenche os atriburos de questão com as informações lidas do arquivo
                questao.enunciado = leitor.ReadLine();
                questao.altA = leitor.ReadLine();
                questao.altB = leitor.ReadLine();
                questao.altC = leitor.ReadLine();
                questao.altD = leitor.ReadLine();
                questao.altE = leitor.ReadLine();
                questao.ResoluçãoFinal = leitor.ReadLine();

                // Preenche os controles do formulário usando o objeto questão
                txtEnunciado.Text = questao.enunciado;
                rdbA.Text = questao.altA;
                rdbB.Text = questao.altB;
                rdbD.Text = questao.altC;
                rdbC.Text = questao.altD;
                rdbE.Text = questao.altE;

                leitor.Close();
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (questao.Resultado != rdbA.Checked)
            {
                txtResolucao.Text = "resposta errada";
            }
            else
            {
                txtResolucao.Text = questao.ResoluçãoFinal;
            }

            if (questao.Resultado != rdbB.Checked)
            {
                txtResolucao.Text = "resposta errada";
            }
            else
            {
                txtResolucao.Text = questao.ResoluçãoFinal;
            }

            if (questao.Resultado != rdbC.Checked)
            {
                txtResolucao.Text = "resposta errada";
            }
            else
            {
                txtResolucao.Text = questao.ResoluçãoFinal;
            }

            if (questao.Resultado != rdbD.Checked)
            {
                txtResolucao.Text = "resposta errada";
            }
            else
            {
                txtResolucao.Text = questao.ResoluçãoFinal;
            }

            if (questao.Resultado != rdbE.Checked)
            {
                txtResolucao.Text = "resposta errada";
            }
            else
            {
                txtResolucao.Text = questao.ResoluçãoFinal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInicioMacaco inico = new FormInicioMacaco();

            inico.ShowDialog();
            
            
        }
    }
}
