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

namespace XBot
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw tExtures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            GamePadState gamePadState = GamePad.GetState(PlayerIndex.One);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "cmd.Exe";

            if (gamePadState.IsConnected)
            {
                if (gamePadState.Buttons.Back == ButtonState.Pressed)
                {
                    this.Exit();
                }
                if (gamePadState.DPad.Up == ButtonState.Pressed)
                {
                    startInfo.Arguments = "/C spim Move_Up.s";
                    process.StartInfo = startInfo;
                    process.Start();
                    startInfo.Arguments = "/C spim Execute_Move.s";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                if (gamePadState.DPad.Left == ButtonState.Pressed)
                {
                    startInfo.Arguments = "/C spim Move_Left.s";
                    process.StartInfo = startInfo;
                    process.Start();
                    startInfo.Arguments = "/C spim Execute_Move.s";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                if (gamePadState.DPad.Right == ButtonState.Pressed)
                {
                    startInfo.Arguments = "/C spim Move_Right.s";
                    process.StartInfo = startInfo;
                    process.Start();
                    startInfo.Arguments = "/C spim Execute_Move.s";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                if (gamePadState.DPad.Down == ButtonState.Pressed)
                {
                    startInfo.Arguments = "/C spim Move_Down.s";
                    process.StartInfo = startInfo;
                    process.Start();
                    startInfo.Arguments = "/C spim Execute_Move.s";
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
