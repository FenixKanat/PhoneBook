using System;

namespace PhoneBookApp
{
    class PhoneBook
    {
        /*
         * Class PhoneBook by Fenix Kanat. Assignment 3, Malmö university, C# course.  
         * This class has 2 initial arrays with 5 elements. The purpose of this class is to 
         * write each element of the two arrays corresponding. In this case there is phones array and
         * a names array. Each element in the names array corresponds to a number in phones array. 
         * DisplayList() will display these as it is given from the arrays. SwapValues() and SortByName() will sort 
         * each element in the arrays using bubble sort algorithm and print it to the console.
         * Then a two dimensional array is created called PhoneList which will take phones and numbers arrays content and store and print
         * it as a two dimensional array. This process is handled in FillTable() and DisplayTable()
         */
        private string[] names = { "Razmus", "Tünde", "Nedim", "Fenix", "Hans" };
        private string[] phones = { "0737187720", "0793549564", "0739966883", "0712234354", "0765832349" };

        private string[,] phoneList;

        public PhoneBook()
        {
            Console.Clear();
            DisplayList(); 
            Console.WriteLine();

            SortByName(); 
            Console.WriteLine();

            FillTable(); 
            DisplayTable(); 
        }

        public void DisplayList()
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    // Display each name and phone number corresponding.
                    Console.WriteLine(names[i] + " : " + phones[j]); 
                }
            }
        }

        private void DisplayTable()
        {
            Console.WriteLine("Elements added to phoneList:");
            for (int i = 0; i < phoneList.GetLength(0); i++)
            {
                // Show each name and phone number in the phoneList array
                Console.WriteLine(phoneList[i, 0] + " : " + phoneList[i, 1]); 
            }
        }

        private void FillTable()
        {
            // Create a two-dimensional array to store names and numbers
            phoneList = new string[names.Length, 2];

            for (int i = 0; i < names.Length; i++)
            {
                // Store the name in the first column of phoneList
                phoneList[i, 0] = $"row {i} : {names[i]}";

                // Store the number in the second column of phoneList
                phoneList[i, 1] = phones[i]; 
            }
        }

        private void SwapValues(int pos)
        {
            // Temporary variable to store a name
            string tempName = names[pos];

            // Swap names in the names array
            names[pos] = names[pos + 1];
            names[pos + 1] = tempName;

            // Temporary variable to store a phone number
            string tempPhone = phones[pos];

            // Swap phone numbers in the phones array
            phones[pos] = phones[pos + 1]; 
            phones[pos + 1] = tempPhone;
        }

        public void SortByName()
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
                {
                    if (string.Compare(names[j], names[j + 1], StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        // Swap names and numbers
                        SwapValues(j); 
                    }
                }
            }

            Console.WriteLine("Sorted names and phones:");
            for (int i = 0; i < names.Length; i++)
            {
                // Show the sorted names and numbers
                Console.WriteLine(names[i] + " : " + phones[i]); 
            }
        }

        public static void Main(string[] args)
        {
            PhoneBook phone = new PhoneBook(); 
        }
    }
}
