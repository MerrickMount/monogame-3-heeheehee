using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_3_heeheehee
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D tribbleGreyTexture, tribbleOrangeTexture, tribbleCreamTexture, tribbleBrownTexture;
        Rectangle tribbleRect;

        Vector2 tribblespeed1;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "HeeHeeHeeHaw";
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.PreferredBackBufferWidth = 800;
            tribbleRect = new Rectangle(500, 10, 100, 100);
            tribblespeed1 = new Vector2(-2, -2);
            base.Initialize();
        }

        protected override void LoadContent()
        {

            _spriteBatch = new SpriteBatch(GraphicsDevice);
            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            tribbleRect.X += (int)tribblespeed1.X;
            if (tribbleRect.Right > _graphics.PreferredBackBufferWidth || tribbleRect.X < 0)
                tribblespeed1.X *= -1;

            tribbleRect.Y += (int)tribblespeed1.Y;
            if (tribbleRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleRect.Y < 0)
                tribblespeed1.Y *= -1;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightCoral);
            _spriteBatch.Begin();
            _spriteBatch.Draw(tribbleGreyTexture,tribbleRect, Color.White);



            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
