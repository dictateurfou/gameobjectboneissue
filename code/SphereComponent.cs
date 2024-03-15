using System;


class SpehereComponent : Component
{
	[Property] public float Radius { get; set; }

	[Property] public Color Color { get; set; }
	//OnPreRender
	protected override void OnUpdate()
	{
		var draw = Gizmo.Draw;
		draw.Color = Color;
		using ( Gizmo.Scope("spherecom" + GameObject.GetHashCode() ) )
		{
			draw.SolidSphere( GameObject.Transform.Position, Radius );
		}
	}
}
