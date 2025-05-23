using Content.Shared._Stalker.Characteristics;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._Stalker.Preferences.UI;

[GenerateTypedNameReferences]
public sealed partial class HumanoidProfileCharacteristicControl : Control
{
    public HumanoidProfileCharacteristicControl(Characteristic characteristic)
    {
        RobustXamlLoader.Load(this);

        var value = string.Empty;
        if (characteristic.Value > 0)
            value += "+";

        value += characteristic.Value;

        Value.Text = $"{Loc.GetString(characteristic.Name)}: {characteristic.Level} ({value})";
    }
}
