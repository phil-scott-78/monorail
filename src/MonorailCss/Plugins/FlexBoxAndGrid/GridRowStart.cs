using System.Collections.Immutable;

namespace MonorailCss.Plugins.FlexBoxAndGrid;

/// <summary>
/// The grid-template-columns plugin.
/// </summary>
public class GridRowStart : BaseUtilityPlugin
{
    /// <inheritdoc />
    protected override string Property => "grid-row-start";

    /// <inheritdoc />
    protected override ImmutableDictionary<string, string> GetUtilities()
    {
        var dict = new Dictionary<string, string>();

        for (var i = 1; i <= 7; i++)
        {
            dict.Add($"row-start-{i}", i.ToString());
        }

        dict.Add("row-start-auto", "auto");
        return dict.ToImmutableDictionary();
    }
}