using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birb : MonoBehaviour
{
    public Rigidbody2D birbRigidBody;
    public float strength = 10f;
    public ScoreManager scoreManager;
    public bool isDead = false;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {
            birbRigidBody.velocity = Vector2.up * strength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        scoreManager.gameOver();
    }
}
