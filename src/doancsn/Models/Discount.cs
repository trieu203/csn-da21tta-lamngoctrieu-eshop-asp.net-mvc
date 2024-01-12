using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace doancsn.Models
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Amout { get; set; }
        public string? Code { get; set; }
        public DateTime? StartDay { get; set; }
        public DateTime? EndDay { get; set; }


    }
}
