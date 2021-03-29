using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Domain;

namespace API.Data
{
    public class SqlCommander 
    {
        private readonly DataContext _context;

        public SqlCommander(DataContext context)
        {
            _context = context;
        }
       
    }
}