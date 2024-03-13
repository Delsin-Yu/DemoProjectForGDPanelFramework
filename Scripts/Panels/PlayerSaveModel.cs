using Godot;

namespace Game;

[GlobalClass]
public partial class PlayerSaveModel : Button
{
    [Export] private Label _saveName;
    [Export] private Label _saveDescription;

    public void SetValue(string name, string description)
    {
        _saveName.Text = name;
        _saveDescription.Text = description;
    }
}