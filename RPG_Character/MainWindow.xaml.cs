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
        private Random _rng = new Random();
        public MainWindow()
        {
            InitializeComponent();
            updateStats();
            int d1 = RPGChar.RollDice(2, 20);
            int d2 = RPGChar.RollDice(1000, 8);
            MessageBox.Show(d1.ToString());
            MessageBox.Show(d2.ToString());
            
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
            double odds = .5;

            characterSheet.PartyMembers.Clear();
            foreach (ListBoxItem i in listPotentialMembers.Items)
            {
                if (_rng.NextDouble() > odds)
                {
                    RPGChar r = new RPGChar()
                    { Name = i.Content.ToString() };
                    characterSheet.PartyMembers.Add(r);
                }
            }

            listPartyMembers.Items.Clear();
            foreach (RPGChar r in characterSheet.PartyMembers)
            {
                ListBoxItem i = new ListBoxItem();
                i.Content = r.Name;
                listPartyMembers.Items.Add(i);
            }

            string output = "";
            foreach (RPGChar r in characterSheet.PartyMembers)
            {
                output += $"{r.Name}\n - { r.Strength}\n";
            }
            MessageBox.Show(output);
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
