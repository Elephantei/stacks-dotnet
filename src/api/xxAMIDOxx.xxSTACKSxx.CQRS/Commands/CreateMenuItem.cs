﻿using System;

namespace xxAMIDOxx.xxSTACKSxx.CQRS.Commands
{
    public partial class CreateMenuItem : ICategoryCommand
    {
        public int OperationCode => (int)Common.Operations.OperationCode.CreateMenuItem;

        public Guid CorrelationId { get; set; }

        public Guid MenuId { get; set; }

        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public bool Available { get; set; }
    }
}