using UnityEngine;

public class Obstacle : MonoBehaviour
{
	[SerializeField]
	float speed = 5.0f, minZ = -1.0f;

	void Update()
	{
		transform.position += new Vector3( 0.0f, 0.0f, -speed * Time.deltaTime );
		if ( transform.position.z < minZ )
		{
			Destroy( gameObject );
		}
	}
}
