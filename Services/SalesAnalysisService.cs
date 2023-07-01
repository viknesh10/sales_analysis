using sales_analysis.Context;
using sales_analysis.Entities;
using sales_analysis.Models;

namespace sales_analysis.Services
{
    public class SalesAnalysisService
    {
        private readonly SalesAnalysisContext _context;
        public SalesAnalysisService(SalesAnalysisContext context)
        {
            _context = context;
        }

        public SalesAnalysisModel GetTopProduct()
        {
            var data = _context.sales_records.OrderByDescending(t => t.total_sales_amount).FirstOrDefault();
            if (data != null)
            {
                return new SalesAnalysisModel() { product_model = data.product_name, total_sales_amount = data.total_sales_amount };
            }
            return null;
        }

        public SalesAnalysisModel GetBottomProduct()
        {
            var data = _context.sales_records.OrderBy(t => t.total_sales_amount).FirstOrDefault();
            if (data != null)
            {
                return new SalesAnalysisModel() { product_model = data.product_name, total_sales_amount = data.total_sales_amount };
            }
            return null;
        }

        public List<SalesAnalysisModel> GetTopProductByLocation()
        {
            var data = _context.sales_records.GroupBy(t => t.location_id).Select(m => new 
            {
                location = m.Key,
                total_sales_amount = m.Sum(t => t.total_sales_amount),
                product_name = m.OrderByDescending(t => t.total_sales_amount).Select(s => s.product_name).FirstOrDefault()
            }).ToList();
            if (data != null && data.Count > 0)
            {
                List<SalesAnalysisModel> sales_list = new List<SalesAnalysisModel>();
                data.ForEach(t =>
                {
                    var location_name = _context.locations.Where(m => m.location_id == t.location).Select(s => s.name).FirstOrDefault();
                    var sales_info = new SalesAnalysisModel() { location = location_name, product_model = t.product_name, total_sales_amount = t.total_sales_amount };
                    sales_list.Add(sales_info);
                });
                return sales_list;
            }
            return null;
        }

        public List<SalesAnalysisModel> GetAllSales()
        {
            var data = _context.sales_records.GroupBy(item => new { item.product_name, item.location_id }).Select(t => new
            {
                location = t.Key.location_id,
                t.Key.product_name,
                total_sales_amount = t.Sum(s => s.total_sales_amount)
            }).ToList();
            if (data != null && data.Count > 0)
            {
                List<SalesAnalysisModel> sales_list = new List<SalesAnalysisModel>();
                data.ForEach(t =>
                {
                    var location_name = _context.locations.Where(m => m.location_id == t.location).Select(s => s.name).FirstOrDefault();
                    var sales_info = new SalesAnalysisModel() { location = location_name, product_model = t.product_name, total_sales_amount = t.total_sales_amount };
                    sales_list.Add(sales_info);
                });
                return sales_list;
            }
            return null;
        }
    }
}
