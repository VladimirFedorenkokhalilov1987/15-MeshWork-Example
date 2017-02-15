using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class FlagsSelector : MonoBehaviour
{

	[SerializeField]
	private Dropdown _dropFlag;

	[SerializeField]
	private Transform[] _vertices;

	[SerializeField]
	private Color[] _color;

	[SerializeField]
	private MeshFilter _meshFilter;

	public Text _selectedContry;

	List<string> flags = new List<string> (){
		"Please, select flag",
		"Armenia",
		"Belgium",
		"Malta",
		"Ukraine"
	};

	public void DropdownIndexChanged(int index)
	{
		_selectedContry.text = flags [index];	
		if (index == 0) 
		{
			_selectedContry.color = Color.red;
			_meshFilter.mesh = null;
		}
		else if (index == 1)
		{
			_selectedContry.color = Color.white;
		
			Mesh mesh = new Mesh ();

			Vector3[] vert = new Vector3 [_vertices.Length];

			for (int i = 0; i < vert.Length; i++)
			{
				vert [i] = _vertices [i].position;
			}

			mesh.vertices = vert;

			int[] triangles = new int[]{ 0, 1, 2, 2, 1, 3, 4, 5, 6, 6, 5, 7, 8, 9, 10, 10, 9, 11 };

			mesh.triangles = triangles;

			Color[] color = new Color[_vertices.Length];

			for (int i = 0; i < color.Length / 10; i++)
			{
				color [i] = _color [0];
			}

			for (int i = color.Length / 10; i < (color.Length / 10) * 2; i++) 
			{
				color [i] = _color [1];
			}

			for (int i = (color.Length / 10) * 2; i < (color.Length / 10) * 3; i++) 
			{
				color [i] = _color [2];
			}

			mesh.colors = color;

			_meshFilter.mesh = mesh;
		} 
		else if (index == 2)
		{
			_selectedContry.color = Color.white;

			Mesh mesh = new Mesh ();

			Vector3[] vert = new Vector3 [_vertices.Length];

			for (int i = 0; i < vert.Length; i++) 
			{
				vert [i] = _vertices [i].position;
			}

			mesh.vertices = vert;

			int[] triangles = new int[]{ 12, 13, 14, 14, 13, 15, 16, 17, 18, 18, 17, 19, 20, 21, 22, 22, 21, 23 };

			mesh.triangles = triangles;

			Color[] color = new Color[_vertices.Length];

			for (int i = (color.Length / 10) * 3; i < (color.Length / 10) * 4; i++) 
			{
				color [i] = _color [3];
			}

			for (int i = (color.Length / 10) * 4; i < (color.Length / 10) * 5; i++) 
			{
				color [i] = _color [4];
			}

			for (int i = (color.Length / 10)*5; i < (color.Length / 10) * 6; i++) 
			{
				color [i] = _color [2];
			}

			mesh.colors = color;

			_meshFilter.mesh = mesh;
		}
		else if (index == 3)
		{
			_selectedContry.color = Color.white;

			Mesh mesh = new Mesh ();

			Vector3[] vert = new Vector3 [_vertices.Length];

			for (int i = 0; i < vert.Length; i++) 
			{
				vert [i] = _vertices [i].position;
			}

			mesh.vertices = vert;

			int[] triangles = new int[]{ 24, 25, 26, 26, 25, 27, 28, 29, 30, 30, 29, 31 };

			mesh.triangles = triangles;

			Color[] color = new Color[_vertices.Length];

			for (int i = (color.Length / 10) * 6; i < (color.Length / 10) * 7; i++) 
			{
				color [i] = _color [5];
			}

			for (int i = (color.Length / 10) * 7; i < (color.Length / 10) * 8; i++) 
			{
				color [i] = _color [6];
			}
				
			mesh.colors = color;

			_meshFilter.mesh = mesh;
		} 
		else if (index == 4)
		{
			_selectedContry.color = Color.white;

			Mesh mesh = new Mesh ();

			Vector3[] vert = new Vector3 [_vertices.Length];

			for (int i = 0; i < vert.Length; i++) 
			{
				vert [i] = _vertices [i].position;
			}

			mesh.vertices = vert;

			int[] triangles = new int[]{ 32,33,34, 34,32,35, 36,37,38, 38,36,39 };

			mesh.triangles = triangles;

			Color[] color = new Color[_vertices.Length];

			for (int i = (color.Length / 10)*8; i < (color.Length / 10)*9; i++)
			{
				color [i] = _color [4];
			}

			for (int i = (color.Length / 10) * 9; i < color.Length; i++)
			{
				color [i] = _color [1];
			}

			mesh.colors = color;

			_meshFilter.mesh = mesh;
		}	
	}
 
	void Awake()
	{
 		PopulateList ();
	}

	void PopulateList()
	{
		_dropFlag.AddOptions (flags);
	}
}
