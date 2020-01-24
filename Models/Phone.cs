using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Phone
    {

        public Phone()
        {
            phoneId = 0;
            phoneName = "";
            manufacturer = "";
            MSRP = 0.0;
            screenSize = 0.0;
            dateReleased = new DateTime(2000, 1, 1);

        }

        public int phoneId { get; set; }
        public string phoneName { get; set; }
        public string manufacturer { get; set; }
        public double MSRP { get; set; }
        public double screenSize { get; set; }
        public DateTime dateReleased { get; set; }

    }
}