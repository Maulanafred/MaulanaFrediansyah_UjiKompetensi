using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SkillManager : MonoBehaviour
{

    public KeyCode skill;

    public GameObject vfxSkill;

    public Transform spawnSkill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(skill) || Input.GetKeyDown(KeyCode.Mouse0)){
            GameObject vfx = Instantiate(vfxSkill,spawnSkill.position,Quaternion.identity);

            AudioManager.instance.PlaySFX(4);

            Destroy(vfx,3f);
        }
        
    }
}
