using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField][Tooltip("The object we apply forces to to move.")]
    private Rigidbody playerBody = null;
    [SerializeField][Tooltip("The speed of the ball.")]
    private float movementSpeed;
    [SerializeField][Tooltip("The height the ball jumps.")]
    private float jumpHeight;
	
	/// <summary>
    /// Physics update that controls the player movement.
    /// </summary>
	void FixedUpdate()
    {
		if(playerBody == null) { return; }

        //May include jumping in the future, for now only moves on the plane
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        playerBody.AddForce(movement * movementSpeed);
	}
}
