﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstracts
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }

        string CreatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        string UpdatedBy { get; set; }

    }
}
