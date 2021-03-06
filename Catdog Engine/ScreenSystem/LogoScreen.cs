﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using CatdogEngine.Graphics;
using CatdogEngine.UI;
using CatdogEngine.UI.StencilComponent;
using System;
using System.Diagnostics;
using Microsoft.Xna.Framework.Input;

namespace CatdogEngine.ScreenSystem
{
    public class LogoScreen : GameScreen
	{

        Sprite logo;
		GameScreen startScreen;

		#region Properties
		public GameScreen StartScreen { set { startScreen = value; } }
		#endregion

		public override void LoadContent()
		{
			// It is Important!
			base.LoadContent();

			// 화면 전환 효과 시간 2초
			TransitionTime = new System.TimeSpan(0, 0, 2);

			// Load Textures.
            logo = new Sprite(Content.Load<Texture2D>("catdog/Catdog"));
			logo.Position = new Vector2(0, 0);

			// We don't need override UnloadContent logic because 'Content' member does it for us in UnloadContent logic of base class.
		}

        public override void Update(GameTime gameTime)
		{
            base.Update(gameTime);
			if(gameTime.TotalGameTime.TotalSeconds > 5)
			{
				if (startScreen != null) ScreenManager.SetScreen(startScreen);
				else Debug.WriteLine("### Causion : There is no Start Screen. ###");
			}
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
		{
			// Draw Textures.
			logo.Draw(spriteBatch);
        }

		public override void OnKeyDown(Keys key)
		{
			base.OnKeyDown(key);

			if(key == Keys.Enter || key == Keys.Space || key == Keys.Escape)
			{
				if (startScreen != null) ScreenManager.SetScreen(startScreen);
				else Debug.WriteLine("### Causion : There is no Start Screen. ###");
			}
		}
	}
}
