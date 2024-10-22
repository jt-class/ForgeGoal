using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgeGoal.Models
{
    public class UpdatesModel
    {
        public List<String> NotificationTypes { get; set; }
        public UpdatesModel()
        {
            NotificationTypes = new List<String>
            {
                "All Types",
                "Read",
                "Mentions"
            };
        }
    }
}
