using System;
using System.Collections.Generic;
using System.Text;

namespace HelensPieShop.Infrastructure
{
    public class Feedback
    {
        public int FeedbackId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public bool ContactMe { get; set; }

    }
}
