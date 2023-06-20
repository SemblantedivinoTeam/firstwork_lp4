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
        int indicePerguntaAtual;
        int acertos;
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
            btnProximaPergunta.Enabled = false;
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
            
            string diretorioMateria = diretorioAtual + cmbDisciplinas.Text;
            string[] arquivos = Directory.GetFiles(diretorioMateria, "*.txt");
            string caminhoArquivo = arquivos[indicePerguntaAtual];

            // Lê a resposta correta do arquivo de texto
            string respostaCorreta;
            using (StreamReader leitor = new StreamReader(caminhoArquivo))
            {
                // Pula as primeiras 6 linhas (enunciado e alternativas)
                for (int i = 0; i < 6; i++)
                {
                    leitor.ReadLine();
                }
                // Lê a resposta correta na linha 7
                respostaCorreta = leitor.ReadLine();
            }

            // Verifica a resposta selecionada pelo usuário
            if (rdbA.Checked && respostaCorreta == "A")
            {
                txtResolucao.Text = questao.ResoluçãoFinal;
                acertos += 5;

            }

            else if (rdbB.Checked && respostaCorreta == "B")
            {
                txtResolucao.Text = questao.ResoluçãoFinal;
                acertos += 5;
            }
            else if (rdbC.Checked && respostaCorreta == "C")
            {
                txtResolucao.Text = questao.ResoluçãoFinal;
                acertos += 5;
            }
            else if (rdbD.Checked && respostaCorreta == "D")
            {
                txtResolucao.Text = questao.ResoluçãoFinal;
                acertos += 5;
            }
            else if (rdbE.Checked && respostaCorreta == "E")
            {
                txtResolucao.Text = questao.ResoluçãoFinal;
                acertos += 5;
            }
            else
            {
                txtResolucao.Text = "Resposta incorreta!";
                acertos -= 5;
            }
            rdbA.Enabled = false;
            rdbB.Enabled = false;
            rdbC.Enabled = false;
            rdbD.Enabled = false;
            rdbE.Enabled = false;

            if(acertos<=0)
            {
                acertos = 0;
            }

            lblAcertos.Text = acertos.ToString() + " % de acertos";
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
            rdbE.Checked = false;
            btnResponder.Enabled = false;
            btnProximaPergunta.Enabled = true;

            if(acertos == 25)
            {
                button1.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInicioMacaco inico = new FormInicioMacaco();

            inico.ShowDialog();
            
            
        }

        private void btnProximaPergunta_Click(object sender, EventArgs e)
        {
            btnResponder.Enabled = true;
            rdbA.Enabled = true;
            rdbB.Enabled = true;
            rdbC.Enabled = true;
            rdbD.Enabled = true;
            rdbE.Enabled = true;

            // Define o diretório da matéria selecionada na comboBox1
            string diretorioMateria = diretorioAtual + cmbDisciplinas.Text;
            // Obtém um vetor de strings contendo o diretório para todos os arquivos
            string[] arquivos = Directory.GetFiles(diretorioMateria, "*.txt");

            // Verifica se há mais perguntas disponíveis
            if (indicePerguntaAtual < arquivos.Length - 1)
            {
                indicePerguntaAtual++; // Incrementa o índice para avançar para a próxima pergunta

                // Cria objeto da classe Questão
                questao = new Questão();

                // Cria um leitor para ler as informações da próxima questão
                StreamReader leitor = new StreamReader(arquivos[indicePerguntaAtual]);

                // Preenche os atributos da questão com as informações lidas do arquivo
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
                rdbC.Text = questao.altC;
                rdbD.Text = questao.altD;
                rdbE.Text = questao.altE;
                txtResolucao.Text = ""; // Limpa o campo de resolução

                leitor.Close();
            }
            else
            {
                MessageBox.Show("Você chegou à última pergunta!");
            }
            btnProximaPergunta.Enabled = false;
        }

        private void lblAcertos_Click(object sender, EventArgs e)
        {
            
        }

        private void txtResolucao_TextChanged(object sender, EventArgs e)
        {
            string diretorioMateria = diretorioAtual + cmbDisciplinas.Text;
            string[] arquivos = Directory.GetFiles(diretorioMateria, "*.txt");
            string caminhoArquivo = arquivos[indicePerguntaAtual];

            // Lê a resposta correta do arquivo de texto
            string respostaCompletaa;
            using (StreamReader leitor2 = new StreamReader(caminhoArquivo))
            {
                // Pula as primeiras 6 linhas (enunciado e alternativas)
                for (int i = 0; i < 7; i++)
                {
                    leitor2.ReadLine();
                }
                // Lê a resposta correta na linha 7
                respostaCompletaa= leitor2.ReadLine();
            }


            txtResolucao.Text = questao.ResoluçãoFinal +"; " + respostaCompletaa;


        }
    }
}
