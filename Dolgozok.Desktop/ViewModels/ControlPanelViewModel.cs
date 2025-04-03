using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Dolgozok.Desktop.Models;

namespace Dolgozok.Desktop
{
    public partial class ControlPanelViewModel: ObservableObject
    {
        private DolgozokContext _context;

        [ObservableProperty]
        private string _numberOfWorkers = string.Empty;

        [ObservableProperty]
        private string _workersWithSalary = string.Empty;

        [ObservableProperty]
        private string _workersWithoutSalary = string.Empty;

        [ObservableProperty]
        private string _averageSalary = string.Empty;

        public ControlPanelViewModel(DolgozokContext context)
        {
            _context = context;
        }
    }
}
