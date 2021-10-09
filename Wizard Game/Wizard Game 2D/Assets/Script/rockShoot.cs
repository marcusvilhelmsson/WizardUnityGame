using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class rockShoot : MonoBehaviour
{
    Rigidbody2D rb;
    
    public float speed = 3f;

    Vector2 moveDirection;
    Player target;
    void Update()
    {
        if(rb.position.x == -13 || rb.position.y > 3.5 || rb.position.y < -7.5)
        {
            Die();
        }
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
       
        RockShoot();

    }
    public void RockShoot(){
        if (rb.position.x < -6)
        {
            rb.MoveRotation(100 * Time.deltaTime);
            if (target != null)
            {
                moveDirection = (target.transform.position - transform.position).normalized * speed;
                rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
            }
        }
        else
        {
            Die();
        }
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamagePlayer(1);
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
