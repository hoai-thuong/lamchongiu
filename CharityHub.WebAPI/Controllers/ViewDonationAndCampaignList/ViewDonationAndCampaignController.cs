using CharityHub.Data.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharityHub.WebAPI.Controllers.ViewDonationList
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewDonationAndCampaignController : ControllerBase
    {
        private readonly CharityHubDbContext dbContext;

        public ViewDonationAndCampaignController(CharityHubDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("GetAllDonations/details")]
        public async Task<IActionResult> GetDonationDetails()
        {
            var donationDetails = await (from d in dbContext.Donations
                                         join u in dbContext.Users on d.UserId equals u.Id into userGroup
                                         from u in userGroup.DefaultIfEmpty()
                                         join c in dbContext.Campaigns on d.CampaignId equals c.CampaignId
                                         orderby d.Amount descending
                                         select new
                                         {
                                             DisplayName = u != null ? u.DisplayName : "Nha hao tam",
                                             d.Amount,
                                             c.CampaignCode,
                                             c.CampaignTitle,
                                             d.DateDonated
                                         }).ToListAsync();

            return Ok(donationDetails);
        }

        [HttpGet("SearchAllDonations/details")]
        public async Task<IActionResult> GetDonationDetailsByDisplayNameAndCampaignCode([FromQuery] string search = null)
        {
            var donationDetails = await (from d in dbContext.Donations
                                         join u in dbContext.Users on d.UserId equals u.Id into userGroup
                                         from u in userGroup.DefaultIfEmpty()
                                         join c in dbContext.Campaigns on d.CampaignId equals c.CampaignId
                                         where string.IsNullOrEmpty(search) ||
                                               c.CampaignCode.ToString().Contains(search) ||
                                               (u != null && u.DisplayName.Contains(search)) ||
                                               ("Nha hao tam".Contains(search) && u == null)
                                         orderby d.Amount descending
                                         select new
                                         {
                                             DisplayName = u != null ? u.DisplayName : "Nha hao tam",
                                             d.Amount,
                                             c.CampaignCode,
                                             c.CampaignTitle,
                                             d.DateDonated
                                         }).ToListAsync();

            return Ok(donationDetails);
        }



        [HttpGet("GetAllCampaigns")]
        public async Task<IActionResult> GetAllCampaigns()
        {
            var campaigns = await dbContext.Campaigns
                .Select(c => new
                {
                    c.CampaignTitle,
                    c.CampaignCode,
                    c.CampaignThumbnail,
                    c.CampaignDescription,
                    c.TargetAmount,
                    c.CurrentAmount,
                    c.PartnerLogo,
                    c.CampaignStatus,
                    c.PartnerName,
                    c.EndDate,
                    c.StartDate,
                    ConfirmedDonationCount = c.Donations.Count(d => d.IsConfirm)
                })
                .ToListAsync();

            return Ok(campaigns);
        }
        [HttpGet("GetAllCampaignsExceptNew")]
        public async Task<IActionResult> GetAllCampaignsExceptNew()
        {
            var campaigns = await dbContext.Campaigns
                .Where(c => c.CampaignStatus != "New") // Filter out campaigns with status "new"
                .Select(c => new
                {
                    c.CampaignTitle,
                    c.CampaignCode,
                    c.CampaignThumbnail,
                    c.CampaignDescription,
                    c.TargetAmount,
                    c.CurrentAmount,
                    c.PartnerLogo,
                    c.CampaignStatus,
                    c.PartnerName,
                    c.EndDate,
                    c.StartDate,
                    ConfirmedDonationCount = c.Donations.Count(d => d.IsConfirm)
                })
                .ToListAsync();

            return Ok(campaigns);
        }

            // GET: api/ViewDonationAndCampaign/GetCampaignCodeByDonationId/{donationId}
            [HttpGet("GetCampaignCodeByDonationId/{donationId}")]
            public async Task<IActionResult> GetCampaignCodeByDonationId(Guid donationId)
            {
                // Find the donation with the specified donationId
                var donation = await dbContext.Donations
                    .Where(d => d.DonationId == donationId)
                    .Select(d => d.CampaignId)
                    .FirstOrDefaultAsync();

                if (donation == Guid.Empty)
                {
                    return NotFound("Donation not found.");
                }

                // Find the campaign with the specified CampaignId
                var campaign = await dbContext.Campaigns
                    .Where(c => c.CampaignId == donation)
                    .Select(c => c.CampaignCode)
                    .FirstOrDefaultAsync();

                // if (string.IsNullOrEmpty(campaign))
                // {
                //     return NotFound("Campaign code not found.");
                // }

                return Ok(new { CampaignCode = campaign });
            }


            [HttpGet("GetCampaignStatus/{campaignId}")]
            public async Task<IActionResult> GetCampaignStatus(Guid campaignId)
            {
                var campaign = await dbContext.Campaigns
                    .Where(c => c.CampaignId == campaignId)
                    .Select(c => new
                    {
                    c.CampaignStatus
                    })
                    .FirstOrDefaultAsync();

                if (campaign == null)
                {
                    return NotFound("Campaign not found.");
                }

                return Ok(campaign);
            }






        }
    }
