﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Service.DTO.CommonsDTO
{
    public class BaseItemDTO : BaseEntityDTO, IDateDTO
    {
        public DateTime CreateON { get; set; }
        public DateTime UpdateON { get; set; }
        public string LocalCreate { get; set; }
        public string LocalUpdate { get; set; }
    }
}
