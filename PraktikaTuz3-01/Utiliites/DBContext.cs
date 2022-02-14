using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraktikaTuz3_01.Entities;

namespace PraktikaTuz3_01.Utiliites
{
    class DBContext
    {
        private static SampleDBEntities _context { get; set; }

        public static SampleDBEntities Context
        {
            get
            {
                if (_context == null)
                    _context = new SampleDBEntities();
                return _context;
            }
        }
    }
}
