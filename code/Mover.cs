using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mover : Component
{
	[Property] public float Speed { get; set; }
	
	protected override void OnFixedUpdate()
	{
		var transform = GameObject.Transform;
		transform.Position += Transform.Rotation.Forward * Speed;
	}
}
