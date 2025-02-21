﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CharityHub.Data.Validation;

namespace CharityHub.Data.Models
{
    public class Campaign
    {
        [Required]
        [Key]
        public Guid CampaignId { get; set; }
        [Required]
        public int CampaignCode { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string CampaignTitle { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(MAX)")]
        public string CampaignThumbnail { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string CampaignDescription { get; set; }
        [Required]
        [MaxLength(11)]
        [CampaignStatusValidation]
        public string CampaignStatus { get; set; }
        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal TargetAmount { get; set; }
        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal CurrentAmount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        [MaxLength(100)]
        public string PartnerName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(MAX)")]
        public string PartnerLogo { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string PartnerNumber { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

        public IList<Donation> Donations { get; set; }
        public IList<UserFollows> UserFollows { get; set; }
        public IList<AdminAction> AdminActions { get; set; }
    }
}
