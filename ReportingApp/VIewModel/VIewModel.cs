using ReportingApp.DAL.Repository;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System;
using ReportingApp.DAL.Models;
using DevExpress.Mvvm.Xpf;
using DevExpress.Mvvm.Native;

namespace ReportingApp.VIewModel
{
    class VIewModel : ViewModelBase
    {
        CustomerRepository repo;

        public VIewModel()
        {
            if(DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                Customers = new ObservableCollection<Customer>();
            }
            else
            {
                repo = new CustomerRepository();
                Customers = new ObservableCollection<Customer>(repo.getCustomers());
            }
            

        }

        public ObservableCollection<Customer> Customers
        {
            get => GetValue<ObservableCollection<Customer>>();
            private set => SetValue(value);

        }
    }
}
