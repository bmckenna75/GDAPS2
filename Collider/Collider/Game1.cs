using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;

namespace Collider
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Texture2D battery;
        private Rectangle batteryLocation;
        private Texture2D cheetah;
        private Rectangle cheeLocation;
        List<Rectangle> rectangles;
        Color[] colors = new Color[5];


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

            rectangles = new List<Rectangle>();

            rectangles.Add(new Rectangle(900, 345, 14, 16));
            rectangles.Add(new Rectangle(1000, 123, 50, 50));
            rectangles.Add(new Rectangle(655, 876, 30, 67));
            rectangles.Add(new Rectangle(200, 546, 60, 122));
            rectangles.Add(new Rectangle(559, 320, 99, 90));
            for (int i = 0; i < 5; i++)
            {
                colors[i] = Color.White;
            }


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
            battery = Content.Load<Texture2D>("battery");
            cheetah = Content.Load<Texture2D>("cheetah");
            cheeLocation = new Rectangle(10, 10, cheetah.Width, cheetah.Height);
            batteryLocation = new Rectangle(1000, 500, battery.Width, battery.Height);

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

            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].Intersects(cheeLocation))
                {
                    colors[i] = Color.Red;
                }
                else
                {
                    colors[i] = Color.White;
                }
            }
          

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
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            spriteBatch.Draw(cheetah, cheeLocation, Color.White);

            for (int i = 0; i < 5; i++)
            {
                spriteBatch.Draw(battery, rectangles[i], colors[i]);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

        protected void ProcessInput()
        {
            Random rng = new Random();
            KeyboardState kb = Keyboard.GetState();

            //chee controls
            if (kb.IsKeyDown(Keys.W))
            {
                cheeLocation.Y -= 3;
            }
            if (kb.IsKeyDown(Keys.A))
            {
                cheeLocation.X -= 3;
            }
            if (kb.IsKeyDown(Keys.S))
            {
                cheeLocation.Y += 3;
            }
            if (kb.IsKeyDown(Keys.D))
            {
                cheeLocation.X += 3;
            }
            //battery controls
            /*
            if (kb.IsKeyDown(Keys.Up))
            {
                batteryLocation.Y -= 3;
            }
            if (kb.IsKeyDown(Keys.Left))
            {
                batteryLocation.X -= 3;
            }
            if (kb.IsKeyDown(Keys.Down))
            {
                batteryLocation.Y += 3;
            }
            if (kb.IsKeyDown(Keys.Right))
            {
                batteryLocation.X += 3;
            }
            */

            for (int i = 0; i < 5; i++)
            {
                Rectangle tempRect = rectangles[i];
                tempRect.X += 10;
                if (tempRect.X > GraphicsDevice.DisplayMode.Width)
                {
                    tempRect.X = 0;
                }
                rectangles[i] = tempRect;
            }



        }
    }
}
