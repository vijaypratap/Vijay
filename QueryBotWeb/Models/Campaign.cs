namespace QueryBotWeb.Models
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Budget { get; set; }
    }
}
