using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;

namespace YourFirstMonogameGame
{

    enum GameState
    {
        Menu,
        Game,
        GameOver
    }
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D playerSprite;
        private Texture2D collectableSprite;
        private Texture2D platformSprite;
        private Player playerMain;
        private int level = 0;
        private int timer;
        List<Collectable> shinies = new List<Collectable>();

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

            graphics.PreferredBackBufferWidth = GraphicsDevice.DisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
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

            // TODO: use this.Content to load your game content here
            playerSprite = Content.Load<Texture2D>("luigi");
            playerMain = new Player(10, 10, 100, 100, playerSprite);
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

            // TODO: Add your update logic here
            ProcessInput();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            GraphicsDevice.Clear(Color.Navy);

            // TODO: Add your drawing code here

            playerMain.Draw(spriteBatch);

            base.Draw(gameTime);
            spriteBatch.End();
        }

        protected void ProcessInput()
        {
            KeyboardState kb = Keyboard.GetState();

            //chee controls
            if (kb.IsKeyDown(Keys.W))
            {
                playerMain.ObjectPosY -= 3;
            }
            if (kb.IsKeyDown(Keys.A))
            {
                playerMain.ObjectPosX -= 3;
            }
            if (kb.IsKeyDown(Keys.S))
            {
                playerMain.ObjectPosY += 3;
            }
            if (kb.IsKeyDown(Keys.D))
            {
                playerMain.ObjectPosX += 3;
            }
        }

        public void NextLevel()
        {
            level++;
            timer = 10;
            shinies.Clear();
            shinies = GenerateCollectables(level);
        }

        public List<Collectable> GenerateCollectables(int level)
        {
            List<Collectable> genList = new List<Collectable>();
            return genList;
        }
    }
}
