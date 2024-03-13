using GDPanelFramework.Panels;
using Godot;

namespace Game;

public partial class SettingPanel : UIPanel
{
    [Export] private Control _firstToFocus;

    protected override void _OnPanelInitialize() => EnableCloseWithCancelKey();

    protected override void _OnPanelOpen() => _firstToFocus.GrabFocus();
}