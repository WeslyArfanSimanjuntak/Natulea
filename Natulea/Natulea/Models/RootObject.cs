using System;
using System.Collections.Generic;
using System.Text;

namespace Natulea.Models
{
    public class RootObject
    {

        public List<Content> content { get; set; }
        public bool lastPage { get; set; }
        public int numberOfElements { get; set; }
        public object sort { get; set; }
        public int totalElements { get; set; }
        public bool firstPage { get; set; }
        public int number { get; set; }
        public int size { get; set; }
    }
}
