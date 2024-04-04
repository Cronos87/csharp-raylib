using System.Numerics;
using Raylib_cs;

namespace HelloWorld.Scenes;

/// <summary>
/// Main menu of the game.
/// </summary>
class MainMenuScene : Scene
{
    Vector2 textPosition = new(12, 12);

    readonly List<string> _menuItems = [
        "Start Game",
        "Options",
        "Exit"
    ];

    int _selectedItem = 0;

    public override void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Up))
        {
            _selectedItem = Math.Max(0, _selectedItem - 1);
        }
        else if (Raylib.IsKeyPressed(KeyboardKey.Down))
        {
            _selectedItem = Math.Min(_menuItems.Count - 1, _selectedItem + 1);
        }
    }

    public override void Draw()
    {
        Raylib.ClearBackground(Color.SkyBlue);
        Raylib.DrawText("Main Menu!", 50, 50, 20, Color.Black);

        foreach (var item in _menuItems)
        {
            var menuEntryColor = _menuItems.IndexOf(item) == _selectedItem ? Color.Red : Color.Black;
            Raylib.DrawText(item, 50, 100 + _menuItems.IndexOf(item) * 20, 20, menuEntryColor);
        }
    }
}