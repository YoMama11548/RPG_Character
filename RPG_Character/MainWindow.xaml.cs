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

namespace RPG_Character
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    
    
    public partial class MainWindow : Window
    {

        private RPGChar characterSheet = new RPGChar();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = characterSheet;
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Update name
            characterSheet.Name = textBoxName.Text;
            MessageBox.Show(characterSheet.Name);

        }

        private void REROLL_Click(object sender, RoutedEventArgs e)
        {
            characterSheet.Roll();
            updateStats();
        }

        private void updateStats()
        {
            textSTR.Text = characterSheet.Strength.ToString();
            textDEX.Text = characterSheet.Dexterity.ToString();
            textINT.Text = characterSheet.Intellegence.ToString();
            textCHR.Text = characterSheet.Charisma.ToString();
            textWIS.Text = characterSheet.Wisdom.ToString();
            textLUC.Text = characterSheet.Luck.ToString();
        }
    }
}
