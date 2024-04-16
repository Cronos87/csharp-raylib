namespace HelloWorld.Scenes;

/// <summary>
/// Base class for all scenes in the game.
/// </summary>
abstract class Scene
{
    /// <summary>
    /// Called once the scene is initialized.
    /// Contents are already loaded.
    /// </summary>
    public virtual void Init() { }

    /// <summary>
    /// Load the contents of the scene required to be used.
    /// Called when a scene is initialized.
    /// </summary>
    public virtual void LoadContent() { }

    /// <summary>
    /// Unload the contents of the scene.
    /// </summary>
    public virtual void UnloadContent() { }

    /// <summary>
    /// Called every frame to update the scene.
    /// </summary>
    public virtual void Update(float deltaTime) { }

    /// <summary>
    /// Called every frame to draw the scene.
    /// </summary>
    public virtual void Draw() { }
}
