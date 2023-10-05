using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensePosition : MonoBehaviour
{
    // Start is called before the first frame update
    private string name = "";
    void Start()
    {
        name = this.gameObject.name;
        Debug.Log(name);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        //sDebug.Log(pos.y);
        if (name == "Character1_LeftHand") 
        { 
            if (pos.y > -3.5f && pos.y < -3f)
            {
                Debug.Log("Animation 01");
            }
        }
        else if (name == "Character1_RightHand")
        {
            if (pos.y > -3.5f && pos.y < -3f)
            {
                Debug.Log("Animation 02");
            }
        }


    }
}
