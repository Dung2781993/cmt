using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Foolproof;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class CampaignViewModel
    {
        public int CampaignId { get; set; }

        [Required(ErrorMessage = "Please select a Business Format")]
        [Editable(true)]
        [UIHint("BusinessFormatEditor")]
        public string BusinessFormat { get; set; }

        public string CampaignCode { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        public string CampaignName { get; set; }

        [Required(ErrorMessage = "Please select a Campaign Type")]
        [Editable(true)]
        [UIHint("CampaignTypeEditor")]
        public int CampaignTypeId { get; set; }

        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


        [Required(ErrorMessage = "Please select a store Format")]
        [Editable(true)]
        [UIHint("StoreFormatEditor")]
        public int StoreOptionId { get; set; }


        [Required]
        [DisplayName("Start Date")]
        [UIHint("Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:u}")]
        //[Range(typeof(DateTime), "16/2/2004", "13/4/2024", ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayName("End Date")]
        [UIHint("Date")]
        [DataType(DataType.Date)]
        [GreaterThanOrEqualTo("StartDate")]  // revist date validation (foolproof package)
        public DateTime EndDate { get; set; }

        [Editable(false)]
        public int RedemptionCodeId { get; set; }

        [Editable(true)]
        [DisplayName("Is Locked")]
        public bool IsLocked { get; set; }

        [Editable(false)]
        public string CreatedBy { get; set; }
        //[Range(typeof(DateTime), "1/2/2004", "3/4/2024", ErrorMessage = "Value for {0} must be between {1} and {2}")]
    }
}