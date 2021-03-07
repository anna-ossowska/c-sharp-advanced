using PeopleViewer.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        { 
            // selectedPerson is a method level variable,
            // it means that if get } of RefreshButton_Click method, this variable should be Garbage Collected

            // BUT this variable was in scope when we created a lambda expression
            // So we can grab the reference to that viariable and we can use it in the body of our lambda,
            // even though it would normally be out of scope
            // Thus, selectedPerson can also be called a CAPTURED variable
            // This is how we form a CLOSURE
            Person selectedPerson = PersonListBox.SelectedItem as Person;

            var repository = new PeopleRepository();
            repository.GetPeopleCompleted +=
                // types don't need to be included inside lambda expressions
                (repoSender, repoArgs) =>
                {
                    PersonListBox.ItemsSource = AddSort(AddFilters(repoArgs.Result));
                    if (selectedPerson != null)
                        PersonListBox.SelectedItem =
                            PersonListBox.Items.OfType<Person>().SingleOrDefault(
                                p => p.FirstName == selectedPerson.FirstName &&
                                    p.LastName == selectedPerson.LastName
                            );
                };
            repository.GetPeopleAsync();
            //selectedPerson = null;
        }

        private IEnumerable<Person> AddFilters(IEnumerable<Person> data)
        {
            int startYear = Int32.Parse(StartDateTextBox.Text);
            int endYear = Int32.Parse(EndDateTextBox.Text);

            if (DateFilterCheckBox.IsChecked.Value)
                data = data
                    .Where(p => p.StartDate.Year >= startYear)
                    .Where(p => p.StartDate.Year <= endYear);

            if (NameFilterCheckBox.IsChecked.Value)
                data = data.Where(p => p.FirstName == NameTextBox.Text);

            return data;
        }

        private IOrderedEnumerable<Person> AddSort(IEnumerable<Person> data)
        {
            if (LastNameSortButton.IsChecked.Value)
                return data.OrderBy(p => p.LastName);

            if (FirstNameSortButton.IsChecked.Value)
                return data.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);

            if (DateSortButton.IsChecked.Value)
                return data.OrderBy(p => p.StartDate);

            if (RatingSortButton.IsChecked.Value)
                return data.OrderByDescending(p => p.Rating);

            return data.OrderBy(p => p.LastName);
        }

        //void repository_GetPeopleCompleted(object sender, GetPeopleCompletedEventArgs e)
        //{
        //    PersonListBox.ItemsSource = e.Result;
        //}
    }
}
