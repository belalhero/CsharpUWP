using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CSharp_Project
{
    public class EmployeeInfo : INotifyPropertyChanged
    {
        public string _employeeid;
        public string _employeename;
        public string _designation;
        public string _joiningdate;
        public string _terminateon;
        public string _address;
        public string _roleplay;

        public string EmployeeID
        {
            get => this._employeeid;
            set
            {
                this._employeeid = value;
                this.OnPropertyChanged(nameof(EmployeeID));
            }
        }
        public string EmployeeName
        {
            get => this._employeename;
            set
            {
                this._employeename = value;
                this.OnPropertyChanged(nameof(EmployeeName));
            }           
        }
        public string Desingnation
        {
            get => this._designation;
            set
            {
                this._designation = value;
                this.OnPropertyChanged(nameof(Desingnation));
            }
        }

        public string JoiningDate
        {
            get => this._joiningdate;
            set
            {
                this._joiningdate = value;
                this.OnPropertyChanged(nameof(JoiningDate));
            }
        }

        public string TerminateON
        {
            get => this._terminateon;
            set
            {
                this._terminateon = value;
                this.OnPropertyChanged(nameof(TerminateON));
            }
        }

        public string Address
        {
            get => this._address;
            set
            {
                this._address = value;
                this.OnPropertyChanged(nameof(Address));
            }
        }

        public string RolePlay
        {
            get => this._roleplay;
            set
            {
                this._roleplay = value;
                this.OnPropertyChanged(nameof(RolePlay));
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
