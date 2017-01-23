//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
// First name
// Last name
// Age (0...100)
// Gender (m or f)
// Personal ID number (e.g. 8306112507)
// Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

namespace Problem10EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName, lastName;
            byte age;
            bool isMale;
            long personalIdNumber;
            int uniqueNumber;

            firstName = "Ivan";
            lastName = "Ivanov";
            age = 18;
            isMale = true;
            personalIdNumber = 9601035487;
            uniqueNumber = 27560001;

            Console.WriteLine("Name: "+ firstName + " " +lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + (isMale == true ? "M" : "F"));
            Console.WriteLine("Personal Number: " + personalIdNumber);
            Console.WriteLine("Work Number: " + uniqueNumber);
        }
    }
}
