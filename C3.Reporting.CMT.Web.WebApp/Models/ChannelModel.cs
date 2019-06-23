using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class ChannelModel
    {
        public int ChannelId { get; set; }

        public int MasterCampaignId { get; set; }

        public string ChannelCode { get; set; }

        [Required]
        [StringLength(40)]
        public string ChannelName { get; set; }

        [Required(ErrorMessage = "Please select a Segment Type")]
        [Editable(true)]
        [UIHint("ChannelTypeEditor")]
        public int ChannelTypeId { get; set; }

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
        public DateTime SegStartDate { get; set; }

        [Required]
        [DisplayName("End Date")]
        [UIHint("Date")]
        [DataType(DataType.Date)]
        public DateTime SegEndDate { get; set; }

        [Editable(false)]
        public int RedemptionCodeId { get; set; }

        public bool IsLocked { get; set; }

        public string CreatedBy { get; set; }
    }
}