﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ads.Model;

namespace Ads.Service.Contracts
{
    public interface IAdBaseService
    {
        AdBase GetById(int id);
    }
}
