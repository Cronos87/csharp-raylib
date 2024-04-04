using HelloWorld.Scenes;

namespace HelloWorld.Managers;

/// <summary>
/// Manages the scenes of the game.
/// </summary>
static class ScenesManager
{
    static Scene? _currentScene;

    /// <summary>
    /// Updates the current scene.
    /// </summary>
    static public void Update()
    {
        _currentScene?.Update();
    }

    /// <summary>
    /// Draws the current scene.
    /// </summary>
    static public void Draw()
    {
        _currentScene?.Draw();
    }

    /// <summary>
    /// Changes the current scene with the given scene.
    /// </summary>
    /// <param name="newScene"></param>
    static public void ChangeScene(Scene newScene)
    {
        _currentScene?.UnloadContent();

        newScene.LoadContent();
        newScene.Init();

        _currentScene = newScene;
    }
}