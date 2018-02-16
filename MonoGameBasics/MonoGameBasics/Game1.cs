using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameBasics
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D cheetah;
        private Vector2 cheeLocation;
        private SpriteFont papyrus12;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            cheeLocation = new Vector2(10, 10);
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            cheetah = Content.Load<Texture2D>("cheetah");

            papyrus12 = Content.Load<SpriteFont>("papyrus12");


            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

           
            ProcessInput();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkViolet);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            spriteBatch.DrawString(papyrus12, "Bobby McKenna", new Vector2(0, 0), Color.Black);
            spriteBatch.DrawString(papyrus12, cheeLocation.ToString(), new Vector2(0, 20), Color.Black);

            spriteBatch.Draw(cheetah, cheeLocation, Color.White);

            spriteBatch.End();
            base.Draw(gameTime);
        }

        protected void ProcessInput()
        {

            KeyboardState kb = Keyboard.GetState();


            if (kb.IsKeyDown(Keys.W))
            {
                cheeLocation.Y -= 3f;
            }
            if (kb.IsKeyDown(Keys.A))
            {
                cheeLocation.X -= 3f;
            }
            if (kb.IsKeyDown(Keys.S))
            {
                cheeLocation.Y += 3f;
            }
            if (kb.IsKeyDown(Keys.D))
            {
                cheeLocation.X += 3f;
            }
        }
    }
}
