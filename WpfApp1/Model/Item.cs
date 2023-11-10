using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1.Model
{
   public  class Item:INotifyPropertyChanged
    {
        public int Id_item { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Owner_id { get; set; }

        public string? Category_id {  get; set; }

        public string? Title_item { get; set; }

        public string? Description_item { get; set;}

        public bool Aviability_item {  get; set; }

        public string? Image_item { get; set; }

        public DateTime Date_posted_item { get; set; }
       

    }
}
