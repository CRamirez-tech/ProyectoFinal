using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerLess : MonoBehaviour
{
	public Transform player;

    void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x + 6f,0f,-10f);
    }
}
