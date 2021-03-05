using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Penerangan.Emedia2u.Web.DTO
{
    public class MediaDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string MediaAbbrev { get; set; }
        public string Kategori { get; set; }
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        public string IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string MediaCatCode { get; set; }
        public int RowNo { get; set; }
    }
}