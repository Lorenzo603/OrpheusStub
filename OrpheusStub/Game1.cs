using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace OrpheusStub
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        KeyboardState previousKeyboardState;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;


        MainCharacter orfeo;
        Character caronte;
            EntityState caronteEntityState;
            State caronteState;
            Dialogue caronteDialogue;
                ChoosePassage firstCP;
                Passage p1;
                Passage p2;



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
          
            orfeo = new MainCharacter();
            caronte = new Character();

            p1 = new Passage(firstCP, caronteEntityState, 2);
                p1.addLine(new Line(orfeo, "Parla orfeo"), 0);
                p1.addLine(new Line(caronte, "parla caronte"), 1);
            p2 = new Passage(null, caronteEntityState, 0);
            firstCP = new ChoosePassage(2);
                firstCP.addPassage(p1,0);
                firstCP.addLine(new Line(orfeo, "parla di qualcosa"), 0);
                firstCP.addPassage(p2, 1);
                firstCP.addLine(new Line(orfeo, "esci dal dialogo"), 1);
            caronteDialogue = new Dialogue(firstCP);

            caronteState = new State();
                caronteState.lineLookAt = new Line(caronte, "caronte -> lookat");
                caronteState.linePickUp = new Line(caronte, "caronte -> pickup");
                caronteState.dialogue = caronteDialogue;
            caronteEntityState = new EntityState(1);
                caronteEntityState.states[0] = caronteState;
                caronteEntityState.currentState = caronteState;
            
            caronte.entityState = caronteEntityState;

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
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.T) && previousKeyboardState.IsKeyUp(Keys.T))
            {
                caronte.talk();
            }

            previousKeyboardState = keyboardState;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
