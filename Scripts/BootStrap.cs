using GDPanelFramework;
using Godot;
using GodotTask;

namespace Game;

public partial class BootStrap : Node
{
    [Export] private PackedScene _panel;
    
    public override void _Ready()
    {
        GDTask.NextFrame().ContinueWith(Boot);
    }

    private async GDTask Boot()
    {
        await _panel.CreatePanel<MainPanel>().OpenPanelAsync();
        GetTree().Quit();
    }
}