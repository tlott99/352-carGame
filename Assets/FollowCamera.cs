using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-6);
    }
}
