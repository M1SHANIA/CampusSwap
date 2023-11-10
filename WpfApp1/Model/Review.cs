using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Review
    {
        public int Id_review {  get; set; }

        public int Id_author { get; set; }

        public int Id_target_user {  get; set; }

        public string? Rating_review {  get; set; }

        public string? Comment { get; set;}

        public DateTime Date_posted_review {get; set; }

        



    }
}
