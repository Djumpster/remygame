using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private Transform player;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 newPosition = player.position;

        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
	}
}
