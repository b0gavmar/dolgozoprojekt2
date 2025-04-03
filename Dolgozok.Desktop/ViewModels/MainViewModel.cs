using Dolgozok.Desktop.Models;
using Dolgozok.Desktop.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok.Desktop.ViewModels
{
    public class MainViewModel
    {
        private DolgozokRepo _repo;
        public ControlPanelViewModel ControlPanelViewModel { get; set; }


        public MainViewModel()
        {
            _repo = new DolgozokRepo();
            ControlPanelViewModel = new ControlPanelViewModel(_repo);
        }
    }
}
