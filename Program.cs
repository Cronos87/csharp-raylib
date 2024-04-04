using Raylib_cs;
using HelloWorld.Managers;
using HelloWorld.Scenes;

namespace HelloWorld;

class Program
{
    public static void Main()
    {
        Raylib.InitWindow(1280, 720, "Hello World");
        Raylib.SetTargetFPS(60);

        // Init the main scene of the game.
        ScenesManager.ChangeScene(new BootScene());

        // Main loop of the game.
        while (!Raylib.WindowShouldClose())
        {
            ScenesManager.Update();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);
            ScenesManager.Draw();
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}