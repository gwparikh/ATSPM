﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MOE.Common.Business.FilterExtensions
{
    [DataContract]
    public class FilterMovement
    {
        public FilterMovement()
        { }
        public FilterMovement(int movementTypeId,  string description, bool include)
        {
            MovementTypeId = movementTypeId;
            Include = include;
            Description = description;
        }

        [DataMember]
        public int MovementTypeId { get; set; }

        public string Description { get; set; }
        [DataMember]
        public bool Include { get; set; }
    }
}
