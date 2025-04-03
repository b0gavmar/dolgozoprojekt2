using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        private int _newSalary = 0;

        [ObservableProperty]
        private Employee _currentEmployee;

        [ObservableProperty]
        public ObservableCollection<Employee> _dolgozok = new ObservableCollection<Employee>();

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
            _currentEmployee = _dolgozok.FirstOrDefault();
        }

        [RelayCommand]
        public void PaySalary(Employee employee)
        {
            if (employee != null)
            {
                employee.Pay(1000);
                OnPropertyChanged(nameof(Dolgozok));
                NumberOfWorkers = $"{_repo.GetNumberOfWorkers()} fő";
                WorkersWithSalary = $"{_repo.GetNumberOfWorkersWithSalary()} fő";
                WorkersWithoutSalary = $"{_repo.GetNumberOfWorkersWithoutSalary()} fő";
                AverageSalary = $"{_repo.GetAverageSalary()} Ft";
            }
        }

        [RelayCommand]
        public void RemoveEmployee(Employee employee)
        {
            if (employee != null)
            {
                _dolgozok.Remove(employee);
                NumberOfWorkers = $"{_repo.GetNumberOfWorkers()} fő";
                WorkersWithSalary = $"{_repo.GetNumberOfWorkersWithSalary()} fő";
                WorkersWithoutSalary = $"{_repo.GetNumberOfWorkersWithoutSalary()} fő";
                AverageSalary = $"{_repo.GetAverageSalary()} Ft";
            }
        }
    }
}
