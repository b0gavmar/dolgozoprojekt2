using Dolgozok.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok.Desktop.ViewModels
{
    public class MainViewModel
    {
        private DolgozokContext _context;
        public ControlPanelViewModel ControlPanelViewModel { get; set; }


        public MainViewModel()
        {
            _context = new DolgozokContext();
            ControlPanelViewModel = new ControlPanelViewModel(_context);
        }
    }
}
