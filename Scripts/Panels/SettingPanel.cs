using GDPanelFramework.Panels;
using Godot;

namespace Game;

public partial class SettingPanel : UIPanel
{
    [Export] private Control _firstToFocus;
    [Export] private Button _closeButton;

    protected override void _OnPanelInitialize()
    {
        EnableCloseWithCancelKey();
        _closeButton.Pressed += ClosePanel;
    }

    protected override void _OnPanelOpen() => _firstToFocus.GrabFocus();
}