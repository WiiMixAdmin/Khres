using System;
using System.Collections.ObjectModel;

namespace Khres.Models
{
    public class Leave
    {
        public int Id { get; set; }
        public bool IsUrgent { get; set; }
        public DateTime LastUpdated { get; set; }
        public LeaveDetail Detail { get; set; }
    }
}