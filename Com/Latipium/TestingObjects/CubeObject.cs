// CubeObject.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.Collections.Generic;
using System.Drawing;
using Com.Latipium.Core;

namespace Com.Latipium.TestingObjects {
	/// <summary>
	/// An object in the game that is just a cube.
	/// </summary>
	public class CubeObject : AbstractLatipiumObject {
		/// <summary>
		/// Occurs when updated.
		/// </summary>
		public event Action<IEnumerable<LatipiumObject>> Updated;

		/// <summary>
		/// Gets the render data.
		/// </summary>
		/// <returns>The render data.</returns>
		/// <param name="instance">The instance of the object</param>
		[LatipiumMethod("GetRenderData")]
        public Com.Latipium.Core.Tuple<object, object> GetRenderData(LatipiumObject instance) {
            return new Com.Latipium.Core.Tuple<object, object>(new float[] {
				-1.0f, -1.0f, -1.0f,    -1.0f, -1.0f,  1.0f,    -1.0f,  1.0f,  1.0f,
				 1.0f,  1.0f, -1.0f,    -1.0f, -1.0f, -1.0f,    -1.0f,  1.0f, -1.0f,
				 1.0f, -1.0f,  1.0f,    -1.0f, -1.0f, -1.0f,     1.0f, -1.0f, -1.0f,
				 1.0f,  1.0f, -1.0f,     1.0f, -1.0f, -1.0f,    -1.0f, -1.0f, -1.0f,
				-1.0f, -1.0f, -1.0f,    -1.0f,  1.0f,  1.0f,    -1.0f,  1.0f, -1.0f,
				 1.0f, -1.0f,  1.0f,    -1.0f, -1.0f,  1.0f,    -1.0f, -1.0f, -1.0f,
				-1.0f,  1.0f,  1.0f,    -1.0f, -1.0f,  1.0f,     1.0f, -1.0f,  1.0f,
				 1.0f,  1.0f,  1.0f,     1.0f, -1.0f, -1.0f,     1.0f,  1.0f, -1.0f,
				 1.0f, -1.0f, -1.0f,     1.0f,  1.0f,  1.0f,     1.0f, -1.0f,  1.0f,
				 1.0f,  1.0f,  1.0f,     1.0f,  1.0f, -1.0f,    -1.0f,  1.0f, -1.0f,
				 1.0f,  1.0f,  1.0f,    -1.0f,  1.0f, -1.0f,    -1.0f,  1.0f,  1.0f,
				 1.0f,  1.0f,  1.0f,    -1.0f,  1.0f,  1.0f,     1.0f, -1.0f,  1.0f
			}, new Color[] {
				Color.FromArgb(255,   0,   0),
				Color.FromArgb(255,   0,   0),
				Color.FromArgb(255,   0,   0),
				Color.FromArgb(190,  63,   0),
				Color.FromArgb(190,  63,   0),
				Color.FromArgb(190,  63,   0),
				Color.FromArgb(127, 127,   0),
				Color.FromArgb(127, 127,   0),
				Color.FromArgb(127, 127,   0),
				Color.FromArgb( 63, 190,   0),
				Color.FromArgb( 63, 190,   0),
				Color.FromArgb( 63, 190,   0),
				Color.FromArgb(  0, 255,   0),
				Color.FromArgb(  0, 255,   0),
				Color.FromArgb(  0, 255,   0),
				Color.FromArgb(  0, 190,  63),
				Color.FromArgb(  0, 190,  63),
				Color.FromArgb(  0, 190,  63),
				Color.FromArgb(  0, 127, 127),
				Color.FromArgb(  0, 127, 127),
				Color.FromArgb(  0, 127, 127),
				Color.FromArgb( 63, 190,   0),
				Color.FromArgb( 63, 190,   0),
				Color.FromArgb( 63, 190,   0),
				Color.FromArgb(  0,   0, 255),
				Color.FromArgb(  0,   0, 255),
				Color.FromArgb(  0,   0, 255),
				Color.FromArgb( 63,   0, 190),
				Color.FromArgb( 63,   0, 190),
				Color.FromArgb( 63,   0, 190),
				Color.FromArgb(127,   0, 127),
				Color.FromArgb(127,   0, 127),
				Color.FromArgb(127,   0, 127),
				Color.FromArgb(190,   0,  63),
				Color.FromArgb(190,   0,  63),
				Color.FromArgb(190,   0,  63)
			});
		}

		/// <summary>
		/// Update the specified objects.
		/// </summary>
		/// <param name="objs">The objects.</param>
		[LatipiumMethod("PhysicsUpdate")]
        public Com.Latipium.Core.Tuple<IEnumerable<LatipiumObject>, IEnumerable<LatipiumObject>> Update(IEnumerable<LatipiumObject> objs) {
			foreach ( LatipiumObject obj in objs ) {
				obj.InvokeProcedure<float, float, float, float>("Rotate", (float) Math.PI / 65536f, 0.3f, 1f, 0.09f);
			}
			return null;
		}

		/// <summary>
		/// Initializes the cube object.
		/// </summary>
		/// <param name="update">The update callback.</param>
		[LatipiumMethod("Initialize")]
		public void Init(Action<IEnumerable<LatipiumObject>> update) {
			if ( update != null ) {
				Updated += update;
			}
		}
	}
}

