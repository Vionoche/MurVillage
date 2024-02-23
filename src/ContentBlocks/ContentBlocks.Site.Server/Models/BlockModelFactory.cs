using System.Collections.Generic;
using ContentBlocks.Site.Server.Components.Blocks;

namespace ContentBlocks.Site.Server.Models;

public static class BlockModelFactory
{
    public static BlockModel CreateBannerBlockModel(string imageUrl, string advertisementUrl)
    {
        return new BlockModel
        {
            ComponentType = typeof(BannerBlock),
            Parameters = new Dictionary<string, object>
            {
                { "ImageUrl", imageUrl },
                { "AdvertisementUrl", advertisementUrl}
            }
        };
    }

    public static BlockModel CreateFooterBlockModel()
    {
        return new BlockModel
        {
            ComponentType = typeof(FooterBlock),
            Parameters = new Dictionary<string, object>()
        };
    }

    public static BlockModel CreateHeaderBlock()
    {
        return new BlockModel
        {
            ComponentType = typeof(HeaderBlock),
            Parameters = new Dictionary<string, object>()
        };
    }

    public static BlockModel CreateTeaserBlock(string heading, string description)
    {
        return new BlockModel
        {
            ComponentType = typeof(TeaserBlock),
            Parameters = new Dictionary<string, object>
            {
                { "Heading", heading },
                { "Description", description }
            }
        };
    }
}