

using System.ComponentModel.DataAnnotations;

namespace AtirAPI.Models
{
	public class Order
	{
    	public int Id { get; set; }
        [Required]
    	public int CustomerId { get; set; }
    	public virtual Customer Customer { get; set; }
    	public DateTime OrderDate { get; set; }
    	public decimal TotalAmount { get; set; }
    	public virtual ICollection<OrderItem> OrderItems { get; set; }
	}
}
