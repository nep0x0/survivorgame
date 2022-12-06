using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    Rigidbody2D rb;
    Vector2 playerDirection, ukuranAwal;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ukuranAwal = transform.localScale;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionX = SimpleInput.GetAxisRaw("Horizontal") * playerSpeed;
        float directionY = SimpleInput.GetAxisRaw("Vertical") * playerSpeed;

        playerDirection = new Vector2(directionX, directionY).normalized;

        //Animasi Player
        if(directionX !=0 || directionY !=0) {
            anim.Play("playerRun");
        } else {
            anim.Play("playerIdle");
        }

        //flip player with change the x
        if (directionX < 0) {
            transform.localScale = new Vector2(-ukuranAwal.x, ukuranAwal.y);
        } else if (directionX > 0) {
            transform.localScale = new Vector2(ukuranAwal.x, ukuranAwal.y);
        }
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(playerDirection.x * playerSpeed, playerDirection.y * playerSpeed);
    }
}
