using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class Report
    {
        //with a POCO, you typically have properties that represent the data you want to store or manipulate. but there is no business logic or behavior associated with it. This allows for separation of concerns, where the data model is separate from the business logic or presentation logic.
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

    }
}
