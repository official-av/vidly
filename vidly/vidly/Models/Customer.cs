using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; } //isNavigationProperty
        public byte MembershipTypeId { get; set; }
    }
}