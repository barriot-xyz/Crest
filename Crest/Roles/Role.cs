﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Roles
{
    public record Role : IEntity<ulong>
    {
        public ulong Id { get; }
    }
}