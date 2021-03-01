using System;

namespace FuncActionDelegates
{
    // Class which contains the methods that we can use for the delegate
    // All the methods have a similar signatures: they take a Person as a parameter and return a string
    // That means they match the method signature of the delegate, and we can assign them to our delegate variable

    public static class Formatters
    {
        //public static string Default(Person input)
        //{
        //    return input.ToString();
        //}

        //public static string LastNameToUpper(Person input)
        //{
        //    return input.LastName.ToUpper();
        //}

        //public static string FirstNameToLower(Person input)
        //{
        //    return input.FirstName.ToLower();
        //}

        //public static string FullName(Person input)
        //{
        //    return string.Format("{0}, {1}", input.LastName, input.FirstName);
        //}
    }
}