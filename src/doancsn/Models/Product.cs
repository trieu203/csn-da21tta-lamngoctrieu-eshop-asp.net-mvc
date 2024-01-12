using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace doancsn.Models
{
    public class Product
    {
        internal object ProductID;

        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public decimal Price { get; set; }

        public decimal NewPrice { get; set; }

        public int Quantity { get; set; }

        public bool IsNew { get; set; }

        public bool IsBestSeller { get; set; }

        public bool IsSale {  get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        [ForeignKey("Discount")]
		public int DiscountId { get; set; }

        public virtual Discount? Discount  { get; set; }

	}
}
