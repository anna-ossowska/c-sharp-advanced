using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using Generics.Common;
using Generics.Common.Factory;
using Generics.Common.Interface;

namespace Generics.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NonGenericButton_Click(object sender, RoutedEventArgs e)
        {
            PersonListBox.Items.Clear();

            ArrayList people = People.GetNonGenericPeople();
            people.Add("Hello"); // No compile-time error; strange runtime behavior
            people.Add(15);      // No compile-time error; strange runtime behavior
            foreach (var person in people)
            {
                PersonListBox.Items.Add(person);
                //PersonListBox.Items.Add((Person)person); // Runtime error
            }
        }

        private void GenericButton_Click(object sender, RoutedEventArgs e)
        {
            PersonListBox.Items.Clear();

            List<Person> people = People.GetGenericPeople();
            //people.Add("Hello"); // Compile-time error
            //people.Add(15);      // Compile-time error
            foreach (var person in people)
                PersonListBox.Items.Add(person);
        }

        private void RepositoryButton_Click(object sender, RoutedEventArgs e)
        {
            //IPersonRepository repo = RepositoryFactory.GetPersonRepository();
            //var people = repo.GetPeople();

            var repo = Container.Resolve<IRepository<Person, string>>();
            var people = repo.GetItems();

            foreach (var person in people)
                PersonListBox.Items.Add(person);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            PersonListBox.Items.Clear();
        }
    }
}
