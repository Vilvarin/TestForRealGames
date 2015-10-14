using System;
using System.Collections.Generic;

namespace TestForRealGames
{
    class Book : IComparable<Book>
    {
        /// <summary>
        /// Текст книги
        /// </summary>
        public string Text { get; private set; }
        /// <summary>
        /// Стиль книги
        /// </summary>
        public TextStyle Style { get; private set; }
        /// <summary>
        /// Размер книги
        /// </summary>
        public BookSize Sort { get; private set; }


        public Book(string text, TextStyle style, BookSize sort)
        {
            Text = text;
            Style = style;
            Sort = sort;
        }

        /// <summary>
        /// Реализация метода сравнения интерфейса IComparable
        /// </summary>
        public int CompareTo(Book other)
        {
            if (this.Sort < other.Sort)
                return -1;

            if (this.Sort == other.Sort)
                return 0;

            if (this.Sort > other.Sort)
                return 1;

            throw new ArgumentNullException("Ошибка сортировки.");
        }
    }
}
