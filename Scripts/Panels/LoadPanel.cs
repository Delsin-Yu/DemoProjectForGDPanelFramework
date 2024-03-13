using GDPanelFramework;
using GDPanelFramework.Panels;
using Godot;

namespace Game;

public partial class LoadPanel : UIPanel
{
    [Export] private PackedScene _saveDataPrefab;
    [Export] private GridContainer _grid;
    [Export] private PackedScene _confirmPanel;

    private Control _firstToSelect;

    protected override void _OnPanelInitialize()
    {
        for (var i = 0; i < 6; i++)
        {
            var instance = _saveDataPrefab.Instantiate<PlayerSaveModel>();
            _firstToSelect ??= instance;
            instance.SetValue($"Player Save #{i}", "Lorem Ipsum Dolor Sit Amet.");
            var currentI = i;
            instance.Pressed += () => _confirmPanel.CreatePanel<LoadConfirmPanel>().OpenPanel($"Load {currentI}?");
            _grid.AddChild(instance);
        }
        EnableCloseWithCancelKey();
    }

    protected override void _OnPanelOpen() => 
        _firstToSelect.GrabFocus();
}