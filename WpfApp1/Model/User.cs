using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class User
    {

        public int Id_user { get; set; }

        public string? Email {  get; set; } 

        public string? User_name { get; set; }

        public string? University { get; set; }

        public double Rating {  get; set; } 

        public DateTime User_joined {  get; set; }

        public string FormattedDate => User_joined.ToString("dddd, dd MMMM yyyy");
    
        internal class Reciever
        {

        }

        internal class Sender
        {

        }
    }
}
