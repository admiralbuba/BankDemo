using BankSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
    public class BankSingleton
    {
        private static BankSingleton instance;
        public static BankSingleton Instance => instance ??= new BankSingleton();   
        public ProcessingCenter ProcessingCenter { get; set; }
        public BankSingleton() => ProcessingCenter = new ProcessingCenter();


    }
}
