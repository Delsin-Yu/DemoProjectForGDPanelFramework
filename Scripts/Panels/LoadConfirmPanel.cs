using GDPanelFramework.Panels;
using Godot;

namespace Game;

public partial class LoadConfirmPanel : UIPanelArg<string, bool>
{
    [Export] private Button _yes;
    [Export] private Button _no;
    [Export] private Label _text;

    protected override void _OnPanelInitialize()
    {
        _yes.Pressed += () => ClosePanel(true);
        _no.Pressed += () => ClosePanel(false);
    }

    protected override void _OnPanelOpen(string arg)
    {
        _text.Text = arg;
        _no.GrabFocus();
    }
}