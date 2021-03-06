﻿using Microsoft.Xna.Framework.Content;
using XBuilder.ContentPreview.Rendering;

namespace XBuilder.Xna
{
	public abstract class AssetHandler
	{
		protected ContentManager ContentManager {get; private set;}
		protected GraphicsDeviceControl GraphicsDeviceControl {get; private set;}

		public abstract AssetRenderer Renderer { get; }
		public abstract string ProcessorName { get; }

		protected AssetHandler(ContentManager contentManager, GraphicsDeviceControl graphicsDeviceControl)
		{
			ContentManager = contentManager;
			GraphicsDeviceControl = graphicsDeviceControl;
		}

		public abstract void ResetRenderer();
		public abstract void LoadContent(string assetName);
	}
}