using System.Numerics;
using HelloWorld.Managers;
using Raylib_cs;

namespace HelloWorld.Scenes;

/// <summary>
/// The boot scene is the first scene that is shown when the game starts.
/// </summary>
class BootScene : Scene
{
    Vector2 textPosition = new(12, 12);
    Texture2D logo;

    public override void LoadContent()
    {
        logo = Raylib.LoadTexture("assets/images/logo.png");
    }

    public override void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.Up))
        {
            textPosition.Y -= 2;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.Down))
        {
            textPosition.Y += 2;
        }

        if (Raylib.IsKeyDown(KeyboardKey.Left))
        {
            textPosition.X -= 2;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.Right))
        {
            textPosition.X += 2;
        }

        if (Raylib.IsKeyReleased(KeyboardKey.Enter))
        {
            ScenesManager.ChangeScene(new MainMenuScene());
        }
    }

    public override void Draw()
    {
        Raylib.ClearBackground(Color.SkyBlue);
        Raylib.DrawTexture(logo, (int)textPosition.X, (int)textPosition.Y, Color.White);
    }
}