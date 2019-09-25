using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CSharp_Project
{
    public class ViewModel : INotifyPropertyChanged
    {
        private List<EmployeeInfo> employeeInfos;
        private int currentEmployee;
        public Command NextEmployee { get; private set; }
        public Command PreviousEmployee { get; private set; }

        public ViewModel()
        {
            this.currentEmployee = 0;
            this.IsAtStart = true;
            this.IsAtEnd = false;
            this.NextEmployee = new Command(this.Next, () => this.employeeInfos.Count > 1 && !this.IsAtEnd);
            this.PreviousEmployee = new Command(this.Previous, () => this.employeeInfos.Count > 0 && !this.IsAtStart);
            this.employeeInfos = new List<EmployeeInfo>
            {
                new EmployeeInfo
                {
                EmployeeID = "101",
                EmployeeName = "BELAL UDDIN",
                Desingnation = "Managing Director",
                JoiningDate = "15/12/2015",
                TerminateON = "N/A",
                Address = "Chittagong, Bangladesh",
                RolePlay = "Admin, Sales, Marketing"
                },
                new EmployeeInfo
                {
                EmployeeID = "102",
                EmployeeName = "MD ZAHIDUL ISLAM",
                Desingnation = "Assistant Managing Director",
                JoiningDate = "03/09/2017",
                TerminateON = "N/A",
                Address = "Chittagong, Bangladesh",
                RolePlay = "Admin, Sales, Marketing"
                },
                new EmployeeInfo
                {
                EmployeeID = "103",
                EmployeeName = "SM RASEL SIDDIQUE",
                Desingnation = "Depoty Managing Director",
                JoiningDate = "05/03/2016",
                TerminateON = "N/A",
                Address = "Dhaka, Bangladesh",
                RolePlay = "Admin, Sales, Marketing"
                }
            };

        }

        private bool _isAtStart;
        public bool IsAtStart
        {
            get => this._isAtStart;
            set
            {
                this._isAtStart = value;
                this.OnPropertyChanged(nameof(IsAtStart));
            }
        }
        private bool _isAtEnd;
        public bool IsAtEnd
        {
            get => this._isAtEnd;
            set
            {
                this._isAtEnd = value;
                this.OnPropertyChanged(nameof(IsAtEnd));
            }
        }

        public EmployeeInfo Current { get => this.employeeInfos.Count > 0 ? this.employeeInfos[currentEmployee] : null; }

        private void Next()
        {
            if (this.employeeInfos.Count - 1 > this.currentEmployee)
            {
                this.currentEmployee++;
                this.OnPropertyChanged(nameof(Current));
                this.IsAtStart = false;
                this.IsAtEnd = (this.employeeInfos.Count - 1 == this.currentEmployee);
            }
        }
        private void Previous()
        {
            if (this.currentEmployee > 0)
            {
                this.currentEmployee--;
                this.OnPropertyChanged(nameof(Current));
                this.IsAtEnd = false;
                this.IsAtStart = (this.currentEmployee == 0);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}



