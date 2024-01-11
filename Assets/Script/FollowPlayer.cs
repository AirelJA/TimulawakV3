using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        offset = new Vector3(3, 1.5f, 1);
        transform.position = Player.transform.position + offset;
    }
}
