using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SkillHandler : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start() {


        // Start the chef 2 units in front of the stove.
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = this.transform.position + Vector3.forward * speed * Time.deltaTime;
        
    }
}
