using Chat.Core.Domain.Messages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Data.Mapping
{
    public class FilesMapp : IEntityTypeConfiguration<Files>
    {
        public void Configure(EntityTypeBuilder<Files> builder)
        {
            throw new NotImplementedException();
        }
    }
}
