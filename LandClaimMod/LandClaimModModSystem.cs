using Vintagestory.API.Common;

namespace LandClaimMod;

public class LandClaimModModSystem : ModSystem
{
    private ICoreAPI api;
    
    public override void Start(ICoreAPI api)
    {
        base.Start(api);
        this.api = api;
    }
}