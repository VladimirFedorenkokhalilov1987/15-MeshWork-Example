using UnityEngine;
using System.Collections;

public class FlagGenerator : MonoBehaviour 
{

	[SerializeField]
	private Transform[] _vertices;

	[SerializeField]
	private Color _color;

	[SerializeField]
	private MeshFilter _meshFilter;

	void Start () 
	{
		Mesh mesh = new Mesh ();

		Vector3[] vert = new Vector3 [_vertices.Length];

		for (int i = 0; i < vert.Length; i++)
		{
			vert [i] = _vertices[i].position;
		}

		mesh.vertices = vert;

		int[] triangles = new int[]{0,1,2,2,1,3};

		mesh.triangles = triangles;

		Color[] color = new Color[_vertices.Length];

		for (int i = 0; i < color.Length; i++) 
		{
			color [i] = _color;
		}

		mesh.colors = color;

		_meshFilter.mesh = mesh;

	}
}
