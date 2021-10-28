using Solution1.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Solution1.Infra.Mappers
{
    public static class BookMapping
    {
        public static Book Map(SqlDataReader reader)
        {
            return new Book { Id = reader.GetInt32(0), Name = reader.GetString(1) };
        }
    }
}
