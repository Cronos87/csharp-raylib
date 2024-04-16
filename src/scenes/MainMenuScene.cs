using HelloWorld.Managers;
using Raylib_cs;

namespace HelloWorld.Scenes;

/// <summary>
/// Delegate for menu items.
/// </summary>
delegate void MenuCallback();

/// <summary>
/// Main menu of the game.
/// </summary>
class MainMenuScene : Scene
{
    #region Fields

    /// <summary>
    /// Menu items with their callbacks.
    /// </summary>
    readonly Dictionary<string, MenuCallback> _menuItems = new(){
        {"Start Game", () => ScenesManager.ChangeScene(new BootScene())},
        {"Exit", Exit}
    };

    int _selectedItem = 0;

    #endregion

    #region Update and Draw

    public override void Update(float deltaTime)
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Up))
        {
            _selectedItem = Math.Max(0, _selectedItem - 1);
        }
        else if (Raylib.IsKeyPressed(KeyboardKey.Down))
        {
            _selectedItem = Math.Min(_menuItems.Count - 1, _selectedItem + 1);
        }

        if (Raylib.IsKeyReleased(KeyboardKey.Enter))
        {
            var item = _menuItems.ElementAt(_selectedItem);
            item.Value.Invoke();
        }
    }

    public override void Draw()
    {
        Raylib.ClearBackground(Color.SkyBlue);
        Raylib.DrawText("Main Menu!", 50, 50, 20, Color.Black);

        int i = 0;

        foreach (var item in _menuItems)
        {
            var menuEntryColor = i == _selectedItem ? Color.Red : Color.Black;
            Raylib.DrawText(item.Key, 50, 100 + i++ * 20, 20, menuEntryColor);
        }
    }

    #endregion

    #region Menu Items Callbacks

    /// <summary>
    /// Callback for the exit menu item that will close the game.
    /// </summary>
    private static void Exit()
    {
        GameManager.CloseGame();
    }

    #endregion
}
