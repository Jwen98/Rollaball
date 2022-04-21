using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    private float speed = 0.2f;
    private float floatLevel = 0.5f;
    private Vector3 startPos;
    private int dir;

    private void Start()
    {
        startPos = transform.position;
        dir = 1;
    }
    // Before rendering each frame..
    void Update()
	{
		// Rotate the game object that this script is attached to by 15 in the X axis,
		// 30 in the Y axis and 45 in the Z axis, multiplied by deltaTime in order to make it per second
		// rather than per frame.
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        if(transform.position.y >= startPos.y + floatLevel)
        {
            dir = -1;
        }
        else if(transform.position.y <= startPos.y)
        {
            dir = 1;
        }
        transform.position = transform.position + new Vector3(0, speed * dir * Time.deltaTime);
	}
}