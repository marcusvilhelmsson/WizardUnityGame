using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectionController : MonoBehaviour
{
   public Animator anim;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void leftSwipe()
    {
        anim.SetTrigger("leftTrig");
    }
    public void rightSwipe()
    {
        anim.SetTrigger("rightTrig");
    }
}
