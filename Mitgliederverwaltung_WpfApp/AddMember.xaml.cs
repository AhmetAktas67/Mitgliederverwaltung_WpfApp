using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mitgliederverwaltung_WpfApp
{
    /// <summary>
    /// Interaktionslogik für AddMember.xaml
    /// </summary>
    public partial class AddMember : Window
    {
        public Member NewMember { get; private set; }
        public AddMember()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                MessageBox.Show("Bitte geben Sie sowohl den Vor- als auch den Nachnamen ein.", "Fehlende Eingabe", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                NewMember= new Member
                {
                    FirstName = FirstNameTextBox.Text,

                    LastName = LastNameTextBox.Text
                };

                DialogResult = true; // Schließt das Fenster und signalisiert Erfolg
                Close();

            }

        }    
    }
}
