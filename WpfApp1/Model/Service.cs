using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Service
    {

        public int Id_service {  get; set; }

        public int Id_provider {  get; set; }
        
        public string? Title_service {  get; set; }

        public string? Description_service { get;set; }

        public DateTime Date_posted_service { get; set; }

        public bool Status_service {  get; set; }   
    }
}
