using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField][Tooltip("The object the camera should follow.")]
    private GameObject playerObject = null;

    private Vector3 offsetFromPlayer;

	// Use this for initialization
	void Start()
    {
        offsetFromPlayer = transform.position - playerObject.transform.position;
	}
	
	/// <summary>
    /// Update that controls the camera position, called after all physics have been done
    /// </summary>
	void LateUpdate()
    {
        transform.position = playerObject.transform.position + offsetFromPlayer;
    }
}
