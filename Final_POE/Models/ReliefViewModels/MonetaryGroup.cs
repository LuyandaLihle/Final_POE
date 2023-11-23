using System.ComponentModel.DataAnnotations;

namespace Final_POE.Models.ReliefViewModels
{
    public class MonetaryGroup
    {
        [DataType(DataType.Date)]
        public DateTime? DonationDate { get; set; }

        public int MonetaryCount { get; set; }
    }
}
