using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using CommunityToolkit.Mvvm.ComponentModel;
using Dolgozok.Desktop.Models;
using Dolgozok.Desktop.Repos;

namespace Dolgozok.Desktop
{
    public partial class ControlPanelViewModel : ObservableObject
    {
        private readonly DolgozokRepo _repo;

        [ObservableProperty]
        private string _numberOfWorkers = string.Empty;

        [ObservableProperty]
        private string _workersWithSalary = string.Empty;

        [ObservableProperty]
        private string _workersWithoutSalary = string.Empty;

        [ObservableProperty]
        private string _averageSalary = string.Empty;

        [ObservableProperty]
        public ObservableCollection<Manyworker> _dolgozok = new ObservableCollection<Manyworker>();

        public ControlPanelViewModel(DolgozokRepo repo)
        {
            _repo = repo;
            NumberOfWorkers = $"{_repo.GetNumberOfWorkers()} fő";
            WorkersWithSalary = $"{_repo.GetNumberOfWorkersWithSalary()} fő";
            WorkersWithoutSalary = $"{_repo.GetNumberOfWorkersWithoutSalary()} fő";
            AverageSalary = $"{_repo.GetAverageSalary()} Ft";

            _dolgozok.Clear();
            foreach (var worker in _repo.GetAll())
            {
                _dolgozok.Add(worker);
            }
        }
    }
}
