using Godot;
using System;
using GDPanelFramework;
using GDPanelFramework.Panels;

namespace Game;

public partial class MainPanel : UIPanel
{
    [Export] private Button _load;
    [Export] private Button _setting;
    [Export] private Button _quit;

    [Export] private PackedScene _loadPanel;
    [Export] private PackedScene _settingPanel;
    
    protected override void _OnPanelInitialize()
    {
        _quit.Pressed += ClosePanel;
        _load.Pressed += () => _loadPanel.CreatePanel<LoadPanel>().OpenPanel();
        _setting.Pressed += () => _settingPanel.CreatePanel<SettingPanel>().OpenPanel();
    }

    protected override void _OnPanelOpen() => _load.GrabFocus();
}
