using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlappyBird : MonoBehaviour
{
    public static FlappyBird Instance { get; private set; }
    public event EventHandler onpipetrigger;
    private Rigidbody2D rb;

    private bool jumpRequest;

    public float jumpForce = 3.7f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Instance = this;
    }

    private void Update()
    {
        if(Keyboard.current.wKey.wasPressedThisFrame)
        {
           jumpRequest = true;
        }
    }
    private void FixedUpdate()
    {
        if(jumpRequest==true)
        {
            rb.linearVelocity = Vector2.zero;
            rb.AddForce(jumpForce * Vector2.up, ForceMode2D.Impulse );
            jumpRequest = false;
        }
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PipeMovement pipeMovement))
        {
            onpipetrigger?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            return;
        }
    }
}
//potty_sigh_was_here_pind_zebra
//dagger here