using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class FaireDataModel
    {
        [Key]
        public int id { get; set; }
        public string? name { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? zip { get; set; }

        [DefaultValue(false)]
        public bool isDeleted { get; set; }


    }
}
