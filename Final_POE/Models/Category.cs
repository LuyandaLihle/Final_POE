using Final_POE.Models.Donation;

namespace Final_POE.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public ICollection<Good> Goods { get; set; }
    }
}
