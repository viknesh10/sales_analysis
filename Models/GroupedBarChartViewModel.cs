namespace sales_analysis.Models
{
    public class GroupedBarChartViewModel
    {
        public List<string> Labels { get; set; }
        public List<GroupedBarChartDataset> Datasets { get; set; }
    }

    public class GroupedBarChartDataset
    {
        public string Label { get; set; }
        public List<int> Data { get; set; }
        public string BackgroundColor { get; set; }
    }
}
