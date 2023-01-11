using System.ComponentModel.DataAnnotations.Schema;

namespace InvMgmt_MVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Column(TypeName ="char(50)")]

        public string ProductName { get; set; }

        [Column(TypeName ="char(50)")]
        public string Category { get; set; }

        public int AvailableQty { get; set; }

        public int UnitPrice { get; set; }
    }
}
