using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRobotAnimationScript : MonoBehaviour
{

    private Animator enemyRobotAnimator;

    // Start is called before the first frame update
    void Start()
    {
        enemyRobotAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") == true){
            enemyRobotAnimator.SetTrigger("startShooting-Still");
        } else if(Input.GetKeyUp("space") == true){
            enemyRobotAnimator.SetTrigger("endShooting-Still");
        }
    }
}
