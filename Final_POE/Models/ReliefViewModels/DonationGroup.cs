using System.ComponentModel.DataAnnotations;

namespace Final_POE.Models.ReliefViewModels
{
    public class DonationGroup
    {
        [DataType(DataType.Date)]
        public DateTime? DonationDate { get; set; }

        public int GoodsCount { get; set; }
    }
}
