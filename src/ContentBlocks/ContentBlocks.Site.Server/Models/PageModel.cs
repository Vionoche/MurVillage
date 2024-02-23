using System.Collections.Generic;

namespace ContentBlocks.Site.Server.Models;

public class PageModel
{
    public required List<BlockModel> Blocks { get; init; }
}