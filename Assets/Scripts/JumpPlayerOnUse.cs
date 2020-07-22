using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayerOnUse : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float pushForce = 1000f;

    private void Start()
    {
        playerRB = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }


    public void JumpPlayer()
    {
        playerRB.AddForce(Vector2.up * pushForce, ForceMode2D.Impulse);
        Destroy(this.gameObject);
    }
}
