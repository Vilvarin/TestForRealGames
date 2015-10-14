using System;
using System.Collections;
using System.Collections.Generic;

namespace TestForRealGames
{
    class BookCompany
    {
        BookFactory factory = new BookFactory();

        IStyle flipperChars = new FlipCharsStyle();
        IStyle flipperWords = new FlipWordsStyle();

        /// <summary>
        /// Обрабатывает текст, и вызывает фабричный метод.
        /// </summary>
        public void OrderBook(string text, TextStyle textStyle)
        {
            switch (textStyle)
            {
                case TextStyle.FlipChars:
                    text = flipperChars.HandleText(text);
                    break;

                case TextStyle.FlipWords:
                    text = flipperWords.HandleText(text);
                    break;

                default:
                    throw new InvalidOperationException("Передан незарегистрированный стиль текста");
            }

            factory.CreateProduct(text, textStyle);
        }

        /// <summary>
        /// забирает книги у фабрики и сортирует их
        /// </summary>
        /// <remarks>Используется стандартная сортировка .NET</remarks>
        /// <param name="sortType">Тип сортировки</param>
        /// <returns>отсортированный массив заказанных книг</returns>
        public Book[] EmbarkBooks(SortType sortType)
        {
            IComparer<Book> reverseComparer = new ReverseComparer();
            Book[] books = factory.GetBooks();

            switch (sortType)
            {
                case SortType.ASC:
                    Array.Sort(books);
                    break;

                case SortType.DESC:
                    Array.Sort(books, reverseComparer);
                    break;

                default:
                    throw new InvalidOperationException("Получен незарегистрированный способ сортировки");
            }

            return books;
        }

        /// <summary>
        /// класс сортировки в обратную сторону.
        /// </summary>
        class ReverseComparer : IComparer<Book>
        {
            public int Compare(Book x, Book y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
