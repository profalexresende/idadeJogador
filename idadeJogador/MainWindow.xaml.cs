using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace idadeJogador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            byte idade;

            //entrada de dados
            idade = Convert.ToByte(txtIdade.Text);

            //Condicional
            if (idade >= 12)//Desvio condicional Composto (trata verdadeiro e falso)
            {
                //BLOCO VERDADEIRO
                MessageBox.Show("Você pode jogar!", "Idade do Jogador",
                                  MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                //BLOCO FALSO
                MessageBox.Show("Você NÃO pode jogar!", "Idade do Jogador",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
