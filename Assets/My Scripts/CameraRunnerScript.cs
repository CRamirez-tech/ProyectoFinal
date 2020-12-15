using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRunnerScript : MonoBehaviour
{
	public Transform player;

    void Update()
    {
        transform.position = new Vector3(player.position.x + 6f,0f,-10f);
    }
}
