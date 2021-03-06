﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DapperExtensions.Mapper;
using DapperExtensions.Tests.Entities;

namespace DapperExtensions.Tests.Maps
{
    public class ExternallyMappedMap
    {
        public class ExternallyMappedMapper : ClassMapper<ExternallyMapped>
        {
            public ExternallyMappedMapper()
            {
                Table("External");
                Map(x => x.Id).Column("ExternalId");
                AutoMap();
            }
        } 
    }
}