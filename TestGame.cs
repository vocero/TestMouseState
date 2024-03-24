using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using var game = new TestGame();
game.Run();

public class TestGame : Game
{
    private readonly GraphicsDeviceManager _graphics;
    private readonly Random _rnd = new();
    private Color _backColor = Color.CornflowerBlue;
    private bool _leftMouse;

    public TestGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        IsMouseVisible = true;
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(_backColor);
        base.Draw(gameTime);
    }

    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
        
        var leftMouse = Mouse.GetState().LeftButton == ButtonState.Pressed;

        if (_leftMouse != leftMouse)
        {
            _backColor = new Color(_rnd.NextSingle(), _rnd.NextSingle(), _rnd.NextSingle());
            _leftMouse = leftMouse;
        }
    }
}
