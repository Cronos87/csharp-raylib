using System.Numerics;
using HelloWorld.Managers;
using Raylib_cs;

namespace HelloWorld.Scenes;

/// <summary>
/// The boot scene is the first scene that is shown when the game starts.
/// </summary>
class BootScene : Scene
{
    #region Fields

    Vector2 _textPosition = new(12, 12);
    Texture2D _logo;

    #endregion

    #region Load and Unload Content

    public override void LoadContent()
    {
        _logo = Raylib.LoadTexture("assets/images/logo.png");
    }

    public override void UnloadContent()
    {
        Raylib.UnloadTexture(_logo);
    }

    #endregion

    #region Update and Draw

    public override void Update(float deltaTime)
    {
        if (Raylib.IsKeyDown(KeyboardKey.Up))
        {
            _textPosition.Y -= 2;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.Down))
        {
            _textPosition.Y += 2;
        }

        if (Raylib.IsKeyDown(KeyboardKey.Left))
        {
            _textPosition.X -= 2;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.Right))
        {
            _textPosition.X += 2;
        }

        if (Raylib.IsKeyReleased(KeyboardKey.Enter))
        {
            ScenesManager.ChangeScene(new MainMenuScene());
        }
    }

    public override void Draw()
    {
        Raylib.ClearBackground(Color.SkyBlue);
        Raylib.DrawTexture(_logo, (int)_textPosition.X, (int)_textPosition.Y, Color.White);
    }

    #endregion
}
