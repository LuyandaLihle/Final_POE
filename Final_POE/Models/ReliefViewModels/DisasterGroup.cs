using System.ComponentModel.DataAnnotations;

namespace Final_POE.Models.ReliefViewModels
{
    public class DisasterGroup
    {
        [DataType(DataType.Date)]
        public DateTime? Active { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ActiveDate { get; set; }

        public int DisasterCount { get; set; }

        public string Description { get; set; }
    }
}
