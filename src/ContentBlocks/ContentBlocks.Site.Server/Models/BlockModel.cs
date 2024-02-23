using System;
using System.Collections.Generic;

namespace ContentBlocks.Site.Server.Models;

public class BlockModel
{
    public required Type ComponentType { get; init; }
    public required IDictionary<string, object> Parameters { get; init; }
}