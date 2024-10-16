using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using КозловControl9.Model;

namespace КозловControl9
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Kozlov_StudlagerEntities _context = new Kozlov_StudlagerEntities();
        public static Kozlov_StudlagerEntities GetContext()
        {
            if (_context == null)
            {
                _context = new Kozlov_StudlagerEntities();
                return _context;
            }
            else
            {
                return _context;
            }
        }
    }
}
