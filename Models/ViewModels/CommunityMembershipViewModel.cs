﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Models.ViewModels
{
    public class CommunityMembersipViewModel
    {
        public string CommunityId { get; set; }
        public string Title { get; set; }
        public bool IsMember { get; set; }
    }
}
