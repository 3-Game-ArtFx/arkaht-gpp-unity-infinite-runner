using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	[SerializeField]
	Transform[] eventualPositions;
	[SerializeField]
	int positionID = 0;
	
	Vector3 targetPosition;

	Animator animator;

	void Awake()
	{
		MoveToPosition( positionID );
		animator = GetComponentInChildren<Animator>();
	}

	void MoveToPosition( int id )
	{
		if ( id < 0 || id > eventualPositions.Length - 1 ) return;

		targetPosition = eventualPositions[id].position;
        positionID = id;
	}

	void Update()
	{
		if ( Input.GetKeyDown( KeyCode.Q ) )
		{
			MoveToPosition( positionID - 1 );
		}
		else if ( Input.GetKeyDown( KeyCode.D ) )
		{
			MoveToPosition( positionID + 1 );
		}

		if ( Input.GetKeyDown( KeyCode.Z ) || Input.GetKeyDown( KeyCode.Space ) )
		{
			animator.SetTrigger( "Jump" );
		}
		else if ( Input.GetKeyDown( KeyCode.S ) || Input.GetKeyDown( KeyCode.LeftControl ) )
		{
			animator.SetTrigger( "Slide" );
		}
	}

	void FixedUpdate()
	{
		transform.position = Vector3.Lerp( transform.position, targetPosition, Time.deltaTime * 5.0f );
	}

	void OnCollisionEnter( Collision collision )
	{
		SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
	}
}
