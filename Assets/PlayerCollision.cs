using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = originalPosition;
        originalPosition = new Vector3(0, 1, 0);
    }
    void OnCollisionEnter (Collision col)
    {
        if ( col.gameObject.name == "DeathWall")
        {
            gameObject.transform.position = originalPosition;
        }
    }
    void OnCollisionExit (Collision col)
    {
        if (col.gameObject.name == "Plane")
        {
            gameObject.transform.position = originalPosition;
        }
    }
}
