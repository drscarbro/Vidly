using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a Customer Name.")]
        [StringLength(225)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Required(ErrorMessage = "Please select a valid Membership Type.")]
        public byte MembershipTypeId { get; set; }

        [MembershipAge]
        public DateTime? BirthDay { get; set; }
    }
}