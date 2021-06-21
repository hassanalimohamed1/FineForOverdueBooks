using System;

namespace FineForOverdueBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of books: ");
            int number_of_books = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of number of days overdue: ");
            int number_of_days_overdue = Convert.ToInt32(Console.ReadLine());

            Console.Write($"The Amount for the overdue book/s is: {Library_fine(number_of_books, number_of_days_overdue).ToString("C")}.");
        }
        private static double Library_fine(int number_of_books, int number_of_days_overdue)
        {
            const double first_seven = 0.10;
            const double after_seven = 0.20;
            double fineamount;

            if (number_of_days_overdue > 7)
            {

                fineamount = ((first_seven * Convert.ToDouble(number_of_days_overdue)) + ((number_of_days_overdue - 7) * after_seven) * number_of_books);
                return fineamount;
            }

            else
            {

                fineamount = (first_seven * Convert.ToDouble(number_of_days_overdue) * number_of_books);

                return fineamount;
            }
        }
    }
}
