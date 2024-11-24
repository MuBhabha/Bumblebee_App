namespace BumbleBee.Models
{
    public class FundingRequest
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string CompanyBackground { get; set; } = string.Empty;
        public string ProjectDetails { get; set; } = string.Empty;
        public decimal FundingAmount { get; set; }
        public string IntendedImpact { get; set; } = string.Empty;
        public string SupportingDocumentPath { get; set; } = string.Empty; 
    }
}
