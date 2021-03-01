using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace FuncActionDelegates
{
    public partial class MainWindow : Window
    {
        // Declaring a variable of type PersonFormat which is a delegate type
        // PersonFormat formatPerson;
        Func<Person, string> formatPerson;

        public MainWindow()
        {
            InitializeComponent();
            PersonListBox.ItemsSource = People.GetPeople();
        }

        // In order to assign a value to formatPerson viariable we check the values of radio buttons inside the UI
        // Then we assign an appropriate method
        private void AssignDelegate()
        {
            if (Option1Button.IsChecked.Value)
                formatPerson = p => p.ToString();

            else if (Option2Button.IsChecked.Value)
                formatPerson = p => p.LastName.ToUpper();
 
            else if (Option3Button.IsChecked.Value)
                formatPerson = p => p.FirstName.ToLower();

            else if (Option4Button.IsChecked.Value)
                formatPerson = p => string.Format("{0}, {1}", p.LastName, p.FirstName);
        }

        private void ProcessDataButton_Click(object sender, RoutedEventArgs e)
        {
            OutputList.Items.Clear();

            AssignDelegate();

            foreach (Person person in PersonListBox.Items)
                OutputList.Items.Add(person.ToString(formatPerson));
        }
    }
}
