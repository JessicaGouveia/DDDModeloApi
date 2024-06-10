using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDModeloApi.Domain.Core.Data
{
    public interface ISeed
    {
        Task SeedAsync();
    }
}
