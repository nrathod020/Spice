namespace Spice.Models.VIewModel
{
    public class SubCategoryAndCategoryViewModel
    {
        public IEnumerable<Category> CategoryList { get; set; }
        public SubCategory subCategory { get; set; }
        public List<String> SubCategoryList { get; set; }
        public String StatusMessage { get; set; }
    }
}
