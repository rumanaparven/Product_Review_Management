﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Review_Management
{
    public class ProductReviwe
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }
    }
}
