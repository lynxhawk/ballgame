using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform playerTransfrom;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
       offset=transform.position - playerTransfrom.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=offset+playerTransfrom.position+new Vector3(playerTransfrom.localScale.x,playerTransfrom.localScale.y*0.3f,-playerTransfrom.localScale.z*1.5f);
    }
}
