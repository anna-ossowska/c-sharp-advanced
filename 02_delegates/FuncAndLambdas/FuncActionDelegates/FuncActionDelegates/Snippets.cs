/* Formatters 

        public static string Default(Person input)
        {
            return input.ToString();
        }

        public static string LastNameToUpper(Person input)
        {
            return input.LastName.ToUpper();
        }

        public static string FirstNameToLower(Person input)
        {
            return input.FirstName.ToLower();
        }

        public static string FullName(Person input)
        {
            return string.Format("{0}, {1}", input.LastName, input.FirstName);
        }

*/

/* Assign Delegate

            if (Option1Button.IsChecked.Value)
                proc = Formatters.Default;
            else if (Option2Button.IsChecked.Value)
                proc = Formatters.LastNameToUpper;
            else if (Option3Button.IsChecked.Value)
                proc = Formatters.FirstNameToLower;
            else if (Option4Button.IsChecked.Value)
                proc = Formatters.FullName;

*/

/* Assign Action

            if (OptionAButton.IsChecked.Value)
                act += p => OutputList.Items.Add(
                    p.Average(r => r.Rating).ToString("#.#"));

            if (OptionBButton.IsChecked.Value)
                act += p => OutputList.Items.Add(p.Min(s => s.StartDate));

            if (OptionCButton.IsChecked.Value)
                act += p => MessageBox.Show(
                    p.OrderByDescending(r => r.Rating).First().LastName);

            if (OptionDButton.IsChecked.Value)
                act += p =>
                    {
                        p.ForEach(c => Console.Write(c.LastName[0]));
                        Console.WriteLine();
                    };
*/