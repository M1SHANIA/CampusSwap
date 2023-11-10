using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
   public class Transaction
    {
        public int Id_transaction { get; set; }

        public int Id_sender {  get; set; }

        public int Id_reciever { get; set;}

        public bool status {  get; set; }

        public DateTime Date_initiated { get; set; }

        public DateTime Date_completed { get; set;}

        internal class Transaction_item
        {
            public int Id_item {  get; set; }
        }

        internal class Transaction_service
        {
            public int Id_service { get; set; }
        }



    }
}
