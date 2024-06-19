using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public Transform spawnhewan;

    public GameObject hewan;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawning(){
        while(true){
            //GameObject hewan = Instantiate(hewan,spawnhewan.position,Quaternion.identity);


            yield return new WaitForSeconds(1f);

        }
    }
}
