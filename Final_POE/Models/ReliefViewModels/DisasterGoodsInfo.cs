using Final_POE.Models.Donation;

namespace Final_POE.Models.ReliefViewModels
{
    public class DisasterGoodsInfo
    {
        public Disaster DisasterVM { get; set; }
        public Good GoodVM { get; set; }
        public Category CategoryVM { get; set; }
        public GoodsPurchase GoodsPurchaseVM { get; set; }
    }
}
