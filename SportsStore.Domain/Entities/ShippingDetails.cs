using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Domain.Entities {

    public class ShippingDetails {
        [Required(ErrorMessage = "Please enter a valid name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter at least the first address line.")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please enter a valid city name.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a valid state.")]
        public string State { get; set; }
        
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a valid country name.")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
