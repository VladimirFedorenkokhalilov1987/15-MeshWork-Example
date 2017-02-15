using UnityEngine;
using System.Collections;

public class MeshGenerator : MonoBehaviour 
{

	[SerializeField]
	private MeshFilter _meshFilter;

	[SerializeField]
	private Transform[] _verts;

	private Mesh mesh;

	void Start () 
	{
		mesh = new Mesh ();

		Vector3[] vertices = new Vector3 [_verts.Length];

		for (int i = 0; i < _verts.Length; i++) 
		{
			vertices [i] = _verts [i].position;
		}
			
		mesh.vertices = vertices;

		int[] triangles = new int[]{0,1,2,2,1,3};

		mesh.triangles = triangles;

		Vector2[] uvs = new Vector2[]{
			new Vector2{x=0,y=0},
			new Vector2{x=0,y=1},
			new Vector2{x=1,y=0},
			new Vector2{x=1,y=1}
		};
		mesh.uv = uvs;

		if (_meshFilter)
			_meshFilter.mesh = mesh;
	}

	private Color GetRandomColor()
	{
		return new Color{
			a = 1f,
			r = Random.Range (0f, 1f),
			g = Random.Range (0f, 1f),
			b = Random.Range (0f, 1f)
		};
	}

	private void  FixedUpdate ()
	{
		UpdateMesh ();
	}

	private void UpdateMesh () 
	{
		Vector3[] vertices = new Vector3 [_verts.Length];

		for (int i = 0; i < _verts.Length; i++)
		{
			vertices [i] = _verts [i].position;
		}
		mesh.vertices = vertices;
	}

	private void OnGUI()
	{
		if(GUI.Button(new Rect(10,10,150,25), "Set random color"))
		{
			Color[] colors = new Color[ mesh.vertices.Length];
			for (int i = 0; i < mesh.vertices.Length; i++) 
			{
				colors[i]=GetRandomColor();
			}
			mesh.colors=colors;
		}

		if(GUI.Button(new Rect(170,10,150,25), "Set standart color"))
		{
				Color[] colors = new Color[]{Color.white, Color.white, Color.white, Color.white};
				mesh.colors=colors;
		}

		if(GUI.Button(new Rect(330,10,150,25), "Set rgb color"))
		{
			Color[] colors = new Color[]{Color.red, Color.blue, Color.green, Color.yellow};
			mesh.colors=colors;
		}

		if (GUI.Button (new Rect (80, 80, 80, 25), "Set 1 UV")) {
			{
				Vector2[] uvs = new Vector2[]
				{
					new Vector2{x=0,y=0},
					new Vector2{x=0,y=1},
					new Vector2{x=1,y=0},
					new Vector2{x=1,y=1}
				};
				mesh.uv = uvs;
			}
		}

		if (GUI.Button (new Rect (170, 80, 80, 25), "Set 2 UV"))
		{
			{
				Vector2[] uvs = new Vector2[]
				{
						new Vector2{x=1,y=0},
						new Vector2{x=1,y=1},
						new Vector2{x=0,y=0},
						new Vector2{x=0,y=1}
				};
				mesh.uv = uvs;
			}
		}

		if (GUI.Button (new Rect (260, 80, 80, 25), "Set 3 UV")) 
		{
			{
				Vector2[] uvs = new Vector2[]
				{
					new Vector2{x=1,y=1},
					new Vector2{x=1,y=0},
					new Vector2{x=0,y=1},
					new Vector2{x=0,y=0}
				};
				mesh.uv = uvs;
			}
		}

		if (GUI.Button (new Rect (350, 80, 80, 25), "Set 4 UV"))
		{
			{
				Vector2[] uvs = new Vector2[]
				{
					new Vector2{x=0,y=1},
					new Vector2{x=0,y=0},
					new Vector2{x=1,y=1},
					new Vector2{x=1,y=0}
				};
				mesh.uv = uvs;
			}
		}

		if (GUI.Button (new Rect (440, 80, 80, 25), "Set 4 UV")) 
		{
			{
				Vector2[] uvs = new Vector2[]
				{
					new Vector2{x=Random.Range(0,1f),y=Random.Range(0,1f)},
					new Vector2{x=Random.Range(0,1f),y=Random.Range(0,1f)},
					new Vector2{x=Random.Range(0,1f),y=Random.Range(0,1f)},
					new Vector2{x=Random.Range(0,1f),y=Random.Range(0,1f)}
				};
				mesh.uv = uvs;
			}
		}
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.Space))
		{

			Color[] colors = new Color[ mesh.vertices.Length];
			for (int i = 0; i < mesh.vertices.Length; i++) 
			{
				colors[i]=GetRandomColor();
			}
			mesh.colors=colors;

			Vector2[] uvs = new Vector2[]
			{
				new Vector2{x=Random.Range(0,1f),y=Random.Range(0,1f)},
				new Vector2{x=Random.Range(0,1f),y=Random.Range(0,1f)},
				new Vector2{x=Random.Range(0,1f),y=Random.Range(0,1f)},
				new Vector2{x=Random.Range(0,1f),y=Random.Range(0,1f)}
			};
			mesh.uv = uvs;
		}
	}
}
