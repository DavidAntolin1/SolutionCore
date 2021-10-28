using System;
using System.Collections.Generic;
using System.Text;

namespace Solution1.Infra
{
    public static class ConnectionToLibrary
    {
        public const string connectionString = @"Data Source=(localdb)\Library;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
