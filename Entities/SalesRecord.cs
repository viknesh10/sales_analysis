using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace sales_analysis.Entities
{
    public class SalesRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sales_id { get; set; }
        [ForeignKey("location_id")]
        public int location_id { get; set; }
        public Location location { get; set; }
        public string product_name { get; set; }
        public int price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int total_units
        {
            get { return _total_units; }
            set { _total_units = value; }
        }
        public int total_sales_amount
        {
            get { return _total_units * price; }
            set { }
        }
        public DateTime sales_date { get; set; } = DateTime.UtcNow;

        private int _total_units;
        private int _price;
    }
}
