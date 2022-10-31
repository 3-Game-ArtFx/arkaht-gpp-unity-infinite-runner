using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    float z = 15.0f;
    [SerializeField]
    Vector2 timeRange = new( 1.0f, 3.0f );
    [SerializeField]
    GameObject[] prefabs;

    float currentTime = 0.0f;

    /*void Start()
    {
        ResetTimer();
    }*/

    void Update()
    {
        if ( ( currentTime -= Time.deltaTime ) <= 0.0f )
        {
            GameObject obj = Instantiate( prefabs[Random.Range( 0, prefabs.Length )] );
            obj.transform.position = transform.position + new Vector3( 0.0f, 0.0f, z );

            ResetTimer();
        } 
    }

    void ResetTimer()
    {
        currentTime = Random.Range( timeRange.x, timeRange.y );
    }
}
