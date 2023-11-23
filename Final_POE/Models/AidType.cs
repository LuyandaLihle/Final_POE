using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Final_POE.Models
{
    public class AidType
    {
        [Display(Name = "Aid Type")]
        public int AidTypeID { get; set; }

        [Display(Name = "Aid Type")]
        public string Name { get; set; }

        public ICollection<Disaster> Disasters { get; set; }
    }
}
