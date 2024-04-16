namespace HelloWorld.Managers;

static class GameManager
{
    /// <summary>
    /// A flag that determines whether the game can be closed.
    /// </summary>
    public static bool CanClose { get; private set; }

    /// <summary>
    /// Close the game at the next frame.
    /// </summary>
    public static void CloseGame()
    {
        CanClose = true;
    }
}
