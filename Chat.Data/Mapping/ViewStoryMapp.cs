﻿using Chat.Core.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Data.Mapping
{
    public class ViewStoryMapp : IEntityTypeConfiguration<ViewStory>
    {
        public void Configure(EntityTypeBuilder<ViewStory> builder)
        {
            
        }
    }
}
