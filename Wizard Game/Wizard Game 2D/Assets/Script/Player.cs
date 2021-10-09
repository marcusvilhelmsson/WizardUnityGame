using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    private Animator anim;
    public float checkRadius;
    public float jumpForce;
    public bool isGrounded;
    public bool attack;
    public bool jump;
    public int extraJumps;
    public double time;
    public double timer;
    public int health = 3;
    public float FlashingTime = .1f;
    public float TimeInterval = .1f;
    public bool shouldJump;
    void Start()
    {
        extraJumps = 1;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    public void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);    
    }
    void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = 1;
        }
    }
    public void DoJump()
    {
        if (extraJumps > 0)
        {
            rb.velocity = new Vector2(0, jumpForce);
            extraJumps--;
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
    public void TakeDamagePlayer(int damagePlayer)
    {
        health -= damagePlayer;
        StartCoroutine(Flash(FlashingTime, TimeInterval));
        if (health <= 0)
        {
            Die();
        }
    }
    IEnumerator Flash(float time, float intervalTime)
    {
        //this counts up time until the float set in FlashingTime
        float elapsedTime = 0f;
        //This repeats our coroutine until the FlashingTime is elapsed
        while (elapsedTime < time)
        {
            Renderer[] RendererArray = GetComponentsInChildren<Renderer>();
            foreach (Renderer r in RendererArray)
                r.enabled = false;
            elapsedTime += Time.deltaTime;
            yield return new WaitForSeconds(intervalTime);
            foreach (Renderer r in RendererArray)
                r.enabled = true;
            elapsedTime += Time.deltaTime;
            yield return new WaitForSeconds(intervalTime);
        }
    }
}
