using Solution1.Core.Models;
using Solution1.Core.Services;
using Solution1.Infra.Mappers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Solution1.Infra
{
    public class BookRepository : IBookRepository
    {
        
        public List<Book> GetAllBooks()
        {
            List<Book> listOfBooks = new List<Book>();
            using (SqlConnection connection = new SqlConnection(ConnectionToLibrary.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Queries.BookQueries.GetAllBooks, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Book book = BookMapping.Map(reader);
                        listOfBooks.Add(book);
                    }
                }
            }
            return listOfBooks;
        }
    }
}
