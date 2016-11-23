// ObjectLoader.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using Com.Latipium.Core;

namespace Com.Latipium.TestingObjects {
	/// <summary>
	/// Loads the testing objects into Latipium.
	/// </summary>
	public class ObjectLoader : AbstractLatipiumLoader {
		public override void Load() {
			LatipiumModule worldObjects = ModuleFactory.FindModule("Com.Latipium.Modules.World.Objects");
			Action<LatipiumObject> load = worldObjects.GetProcedure<LatipiumObject>("LoadObject");
			load(new CubeObject());
		}
	}
}

