using System;
using System.Collections.Generic;

namespace TestForRealGames
{
    class BookFactory
    {
        List<Book> books = new List<Book>();

        /// <summary>
        /// Отдаёт массив с книгами.
        /// </summary>
        /// <returns>массив заказанных книг</returns>
        public Book[] GetBooks()
        {
            Book[] result = books.ToArray();
            return result;
        }

        /// <summary>
        /// Создаёт книгу и запоминает её в массиве. Указывает размер в зависимости от стиля.
        /// </summary>
        /// <param name="text">текст книги</param>
        /// <param name="textStyle">стиль текста</param>
        public void CreateProduct(string text, TextStyle textStyle)
        {
            BookSize size;

            switch (textStyle)
	        {
		        case TextStyle.FlipChars:
                    size = BookSize.Small;
                    break;

                case TextStyle.FlipWords:
                    size = BookSize.Big;
                    break;

                default:
                    throw new InvalidOperationException("Передан незарегистрированный размер книги");
	        }

            Book product = new Book(text, textStyle, size);
            books.Add(product);
        }
    }
}
