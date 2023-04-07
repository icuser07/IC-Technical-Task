using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Domain.Base
{
    internal interface IEntity
    {
        long Id { get; set; }

        DateTime CreatedAt { get; set; }
    }
}