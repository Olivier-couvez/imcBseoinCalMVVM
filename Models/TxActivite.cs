using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcPoidsMVVM.Models
{
    public class TxActivite
    {
        private decimal _id;

        public decimal Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _txActivite;

        public string TxActiv
        {
            get { return _txActivite; }
            set { _txActivite = value; }
        }
    }
}
