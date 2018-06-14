namespace Mapbox.Unity.MeshGeneration.Interfaces
{
	using Mapbox.VectorTile;
	using UnityEngine;
	using Mapbox.Unity.MeshGeneration.Data;
	using System;
	using System.Collections.Generic;
	using KDTree;

	/// <summary>
	/// Layer visualizers contains sytling logic and processes features
	/// </summary>
	public abstract class LayerVisualizerBase : ScriptableObject
	{
		public bool Active = true;
		public abstract string Key { get; set; }
		//public event Action FeaturePreProcessEvent;
		//public event Action FeaturePostProcessEvent;
		public abstract void Create(VectorTileLayer layer, UnityTile tile, Action callback = null, KDTree<VectorFeatureUnity> replacementFeatures = null);

		public virtual void Initialize()
		{

		}

		public void UnregisterTile(UnityTile tile)
		{
			OnUnregisterTile(tile);
		}

		public virtual void OnUnregisterTile(UnityTile tile)
		{

		}
			
	}
}
