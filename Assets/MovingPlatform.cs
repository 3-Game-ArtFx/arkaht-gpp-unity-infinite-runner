using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    float speed = 5.0f, minZ = -10.0f, spawnZ = 40.0f;

    void Update()
    {
        if ( transform.position.z <= minZ )
        {
            transform.position += new Vector3( 0.0f, 0.0f, spawnZ );
        }

        transform.position += new Vector3( 0.0f, 0.0f, -speed * Time.deltaTime );
    }
}
