using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class muzzleFlashTriggerScript : MonoBehaviour
{

    [SerializeField] VisualEffect _muzzleFlash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") == true){
            VisualEffect muzzleFlashGo = Instantiate(_muzzleFlash, transform.position, transform.rotation);
            muzzleFlashGo.Play();
            Destroy(muzzleFlashGo.gameObject, .15f);
        }
    }
}
