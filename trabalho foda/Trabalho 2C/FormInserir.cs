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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabalho_2C
{
    public partial class FormInserir : Form
    {

        int fileNumber = 1;
        // Questão atual
        inserção inserir;
        // diretorio atual
        string diretorioAtual;
        public FormInserir()
        {
            InitializeComponent();

            diretorioAtual = Directory.GetCurrentDirectory();
            diretorioAtual += @"\..\..\..\Questões\";

            string[] diretorios = Directory.GetDirectories(diretorioAtual);

            for (int i = 0; i < diretorios.Length; i++)
            {
                string nomeDaDisciplina = diretorios[i].Remove(0, diretorioAtual.Length);
                cmbdisciplinas.Items.Add(nomeDaDisciplina);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string diretorioMateria = diretorioAtual + cmbdisciplinas.Text;
            string[] arquivos = Directory.GetFiles(diretorioMateria, "*.txt");
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            string inputText = txtenunciado.Text;
            inserir = new inserção();
            // Verifica se o texto de entrada não está vazio
            if (!string.IsNullOrEmpty(inputText))
            {
                try
                {
                    string filePath =  diretorioAtual + cmbdisciplinas.Text + @"\" + cmbdisciplinas.Text + " " + fileNumber + @".txt"; ;

                    fileNumber++;
                    if (fileNumber > 10)
                        fileNumber = 1;

                    // Verifica se o arquivo existe
                    if (!File.Exists(filePath))
                    {
                        using (FileStream fs = File.Create(filePath))
                        {
                            fs.Close();
                        }

                    }

                    // Escreve o texto de entrada no arquivo
                    File.WriteAllText(filePath, inputText);


                    MessageBox.Show("Informações salvas com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar as informações: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira alguma informação na caixa de texto.");
            }
        }
    }
}
