using Godot;
using System;
using System.Collections.Generic;

public partial class LineRenderer : MeshInstance3D
{
	ImmediateMesh mesh;
	[Export] public Vector3[] points;
	[Export] public float width = 0.1f;
	[Export] public Curve curve;
	[Export] public bool continuous = false;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		mesh = (ImmediateMesh)Mesh;
	}

	public void Draw()
	{
        mesh.ClearSurfaces();
        if (points.Length > 1)
        {
			Transform3D temp = GlobalTransform;
            mesh.SurfaceBegin(Mesh.PrimitiveType.TriangleStrip);
            for (int i = 0; i < points.Length; i++)
            {
				temp.Origin = points[i];
                if (i == 0) temp.LookingAt(points[i + 1]);
                else temp.LookingAt(points[i - 1]);

                float realWidth = width;
                if (curve != null) realWidth = curve.Sample((float)i / (points.Length - 1));

                mesh.SurfaceAddVertex(temp.Origin + (temp.Basis.X * realWidth));
                mesh.SurfaceAddVertex(temp.Origin - (temp.Basis.X * realWidth));
            }

            mesh.SurfaceEnd();
        }
    }

	public override void _Process(double delta)
	{
		if (continuous) Draw();
    }
}
