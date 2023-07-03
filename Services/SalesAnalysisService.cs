using sales_analysis.Context;
using sales_analysis.Entities;
using sales_analysis.Models;
using System.Globalization;

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
            return new SalesAnalysisModel() { product_model = data?.product_name, total_sales_amount = String.Format(new CultureInfo("en-IN", false), "{0:n}", Convert.ToInt32(data?.total_sales_amount)) };
        }

        public SalesAnalysisModel GetBottomProduct()
        {
            var data = _context.sales_records.OrderBy(t => t.total_sales_amount).FirstOrDefault();
            return new SalesAnalysisModel() { product_model = data?.product_name, total_sales_amount = String.Format(new CultureInfo("en-IN", false), "{0:n}", Convert.ToInt32(data?.total_sales_amount)) };
        }

        public SalesAnalysisModel GetTotalSales()
        {
            var data = _context.sales_records.Sum(t => t.total_sales_amount);
            return new SalesAnalysisModel() { total_sales_amount = String.Format(new CultureInfo("en-IN", false), "{0:n}", Convert.ToInt32(data)) };
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
                    var sales_info = new SalesAnalysisModel() { location = location_name, product_model = t.product_name, total_sales_amount = String.Format(new CultureInfo("en-IN", false), "{0:n}", Convert.ToInt32(t.total_sales_amount)) };
                    sales_list.Add(sales_info);
                });
                return sales_list;
            }
            return null;
        }

        public GroupedBarChartViewModel GetAllSales()
        {
            var data = _context.sales_records.GroupBy(item => new { item.product_name, item.location_id }).Select(t => new
            {
                location = _context.locations.Where(s => s.location_id == t.Key.location_id).Select(s => s.name).FirstOrDefault(),
                t.Key.product_name,
                total_sales_amount = t.Sum(s => s.total_sales_amount)
            }).OrderBy(s => s.location).ToList();
            if (data != null && data.Count > 0)
            {
                GroupedBarChartViewModel dataset = new GroupedBarChartViewModel
                {
                    Labels = data.Select(t => t.location).Distinct().ToList(),
                    Datasets = data.GroupBy(d => d.product_name)
                                .Select(item => new GroupedBarChartDataset
                                {
                                    Label = item.Key,
                                    Data = item.Select(t => t.total_sales_amount).ToList(),
                                    BackgroundColor = GetBackgroundColor(item.Key.ToLower())
                                }).ToList()
                };
                return dataset;
            }
            return null;
        }

        private string GetBackgroundColor(string model)
        {
            if (model == "va1")
            {
                return "rgba(75, 192, 192, 0.5)";
            }
            else if (model == "va2")
            {
                return "rgba(255, 99, 132, 0.5)";
            }
            else if (model == "va3")
            {
                return "rgba(54, 162, 235, 0.5)";
            }
            else
            {
                return "rgba(0, 0, 0, 0.5)";
            }
        }
    }
}
