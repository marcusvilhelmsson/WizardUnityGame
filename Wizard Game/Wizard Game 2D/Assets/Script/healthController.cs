using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthController : MonoBehaviour
{
    private Animator anim;
    public Player playerScript;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = playerScript.health;
        if (currentHealth != -1)
        {
            anim.SetInteger("heartHealth", currentHealth);
        }
        
    }
}
