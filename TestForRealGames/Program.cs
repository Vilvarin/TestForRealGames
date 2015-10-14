using System;

namespace TestForRealGames
{
    class Program
    {
        /// <summary>
        /// Массив входных текстов.
        /// </summary>
        /// <remarks>
        /// В реальном приложении тексты могли бы браться из файла,
        /// базы данных, запросом к серверу или записываться пользователем
        /// через графический интерфейс. В задании точно не указано, поэтому для простоты пишу в коде.
        /// Аналогично с выходными данными - пишу в консоль.
        /// </remarks>
        private static string[] inputTexts = new string[]{
            "Коту скоро сорок суток.",
            "Дорого небо, да надобен огород",
        };

        static void Main(string[] args)
        {
            try
            {
                BookCompany company = new BookCompany();

                foreach(string text in inputTexts){
                    company.OrderBook(text, TextStyle.FlipChars);
                    company.OrderBook(text, TextStyle.FlipWords);
                }

                Book[] outputTextASC = company.EmbarkBooks(SortType.ASC);
                Book[] outputTextDESC = company.EmbarkBooks(SortType.DESC);

                Console.Write("Тексты отсортированы по возрастанию: \n");
                WriteBooksInConsole(outputTextASC);
                Console.Write("\n --- \n");

                Console.Write("\n\n\n");

                Console.Write("Тексты отсортированы по убыванию: \n");
                WriteBooksInConsole(outputTextDESC);
                Console.Write("\n --- \n");

                Console.Read();
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
                Console.Write(e.Data);
                Console.Read();
            }
        }

        private static void WriteBooksInConsole(Book[] books)
        {
            foreach (Book book in books)
            {
                Console.Write("Текст книги: " + book.Text + "\n");
                Console.Write("Тип текста: " + book.Style.ToString() + "\n");
                Console.Write("Сортировка: " + book.Sort.ToString() + "\n");
                Console.Write("\n");
            }
        }
    }
}
