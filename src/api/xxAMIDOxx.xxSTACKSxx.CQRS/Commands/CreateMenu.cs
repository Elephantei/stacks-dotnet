﻿using System;
using Amido.Stacks.Application.CQRS.Commands;

namespace xxAMIDOxx.xxSTACKSxx.CQRS.Commands
{
    public partial class CreateMenu : ICommand
    {
        public int OperationCode => (int)Common.Operations.OperationCode.CreateMenu;

        public Guid CorrelationId { get; }

        public Guid RestaurantId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Enabled { get; set; }

    }
}