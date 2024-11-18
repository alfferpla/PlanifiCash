using System;
using Pro10Prosper.MVVM.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro10Prosper.MVVM.ViewModels
{
    public class TransactionsViewModel
    {
        public Transaction Transaction { get; set; } = new Transaction();

        public string SaveTransaction()
        {
            App.TransactionsRepo.SaveItem(Transaction);
            return App.TransactionsRepo.StatusMessage;
        }
    }
}
