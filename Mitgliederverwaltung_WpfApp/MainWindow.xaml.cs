using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Mitgliederverwaltung_WpfApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Memberlist
        public ObservableCollection<Member> Members { get; set; }
        
        public MainWindow()
        {


            InitializeComponent();

            Members = new ObservableCollection<Member>
            {
                 new Member { FirstName = "Max", LastName = "Muster", Jan = true, Feb = false },
            };

            MembersDataGrid.ItemsSource = Members;


        }
    }
}
