﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatdogEngine.Graphics {
	/// <summary>
	/// 그리기의 기본 단위. Texture2D의 래퍼.
	/// 윈도우 좌표상의 그려질 위치, 스케일, 회전각을 갖고 있다.
	/// 스프라이트의 위치는 텍스쳐의 중앙을 나타낸다.
	/// </summary>
	public class Sprite {
		private Vector2 _position;
		private Vector2 _scale;
		private float _rotation;

		private Texture2D _texture;

		#region Properties
		public Vector2 Position { get { return _position; } set { _position = value; } }
		public Vector2 Scale { get { return _scale; } set { _scale = value; } }
		public float Rotation { get { return _rotation; } set { _rotation = value; } }
		#endregion

		public Sprite(Texture2D texture) {
			Position = new Vector2(0, 0);
			Scale = new Vector2(1, 1);
			Rotation = 0f;
			_texture = texture;
		}

		public void Draw(SpriteBatch spriteBatch) {
			spriteBatch.Draw(texture: _texture,
				position: Position,
				origin: new Vector2(_texture.Width/2, _texture.Height/2),
				rotation: Rotation,
				scale: Scale);
		}

		public void Dispose() {
			_texture.Dispose();
		}
	}
}