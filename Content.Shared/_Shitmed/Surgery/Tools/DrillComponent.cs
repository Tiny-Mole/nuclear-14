using Robust.Shared.GameStates;

namespace Content.Shared._Shitmed.Medical.Surgery.Tools;

[RegisterComponent, NetworkedComponent]
public sealed partial class DrillComponent : Component, ISurgeryToolComponent
{
    public string ToolName => "Дрель"; // Corvax-Localization
    public bool? Used { get; set; } = null;
    [DataField]
    public float Speed { get; set; } = 1f;
}
