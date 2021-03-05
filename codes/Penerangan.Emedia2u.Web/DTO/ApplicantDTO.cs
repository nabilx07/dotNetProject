using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penerangan.Emedia2u.Web.DTO
{

    public class ApplicantDTO
    {
        private string _dob;
        private string _applicationDate;
        private string _dateIssue;
        private string _dateExpiry;

        public string Catatan { get; set; }
        public string NoBorang { get; set; }
        public string Media_Name { get; set; }
        public string StatusKad { get; set; }
        public Int16 Visit { get; set; }
        public string Arrival { get; set; }
        public string Pass_PlaceIssue { get; set; }
        public string Pass_Expiry { get; set; }
        public string CardStatus { get; set; }
        public int EnterById { get; set; }
        public string EnterDate { get; set; }
        public int EditById { get; set; }
        public int PrintById { get; set; }
        public string PrintDate { get; set; }
        public string EditDate { get; set; }
        public string ApplicationApproval { get; set; }
        public string Malaysian { get; set; }
        public string Form { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        public string TelRNo { get; set; }
        public string TelONo { get; set; }
        public string TelHpNo { get; set; }
        public string IcNo { get; set; }
        public string CardNo { get; set; }
       
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Designation { get; set; }
        public string OldCardNo { get; set; }
        public string CardColorCode { get; set; }
        public string CardStatusCode { get; set; }
        public string Emel { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoType  { get; set; }
        public string Comment { get; set; }
        public int RecordType { get; set; }
        public int ApplicantId { get; set; }
        public string Dob { get; set; }
        public int OfficerID { get; set; }
        public string ApplicationDate { get; set; }
        //public string ApplicationDate
        //{
        //    get
        //    {
        //        return string.IsNullOrEmpty(_applicationDate) ? "" : DateTime.Parse(_applicationDate).ToString("dd-MM-yyyy");
        //    }
        //    set
        //    {
        //        _applicationDate = value;
        //    }

        //}       
        public string DateIssue
        {
            get
            {
                return string.IsNullOrEmpty(_dateIssue) ? "" : DateTime.Parse(_dateIssue).ToString("dd-MM-yyyy");
            }
            set
            {
                _dateIssue = value;
            }

        }
        public string DateExpiry
        {
            get
            {
                return string.IsNullOrEmpty(_dateExpiry) ? "" : DateTime.Parse(_dateExpiry).ToString("dd-MM-yyyy");
            }
            set
            {
                _dateExpiry = value;
            }
        } 
       
    }
}
