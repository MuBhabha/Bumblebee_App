namespace BumbleBee.Models
{
    public class FundingRequestViewModel
    {
        public string CompanyName { get; set; } = string.Empty;
        public string CompanyBackground { get; set; } = string.Empty;
        public string ProjectDetails { get; set; } = string.Empty;
        public decimal FundingAmount { get; set; }
        public string IntendedImpact { get; set; } = string.Empty;
    }

}
