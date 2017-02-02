using System.Collections.Generic;
using UnityEngine;

public enum TextureType {
	air, grass, rock
}


public class Chunk : MonoBehaviour {
	private List<Vector3> newVertices = new List<Vector3>();
	private List<int> newTriangles = new List<int> ();
	private List<Vector2> newUV = new List<Vector2> ();

	private Mesh mesh;
	private MeshCollider chunkCollider;

	private float textureWidth = 0.083f;

	private int faceCount;

	private Vector2 grassTop = new Vector2(1, 11);
	private Vector2 grassSide = new Vector2(0, 10);
	private Vector2 rockTop = new Vector2(7, 8);
	private Vector2 rockSide = new Vector2(0, 10);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void CubeTop(int x, int y, int z, byte block) {
		newVertices.Add (new Vector3 (x, y, z + 1));
		newVertices.Add (new Vector3 (x+1, y, z + 1));
		newVertices.Add (new Vector3 (x+ 1, y, z));
		newVertices.Add (new Vector3 (x, y, z));
	}

	void UpdateMesh() {

	}
}
