using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballons : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Score score;
    [SerializeField] SpriteRenderer spriteRendererBallon;
    [SerializeField] Animator animatorPop;
    [SerializeField] CircleCollider2D circleCollider;

    public float ballonSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
        score = FindObjectOfType<Canvas>().GetComponent<Score>();
        spriteRendererBallon = GetComponent<SpriteRenderer>();
        Color randomColour = new Color(Random.Range(0f , 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        spriteRendererBallon.color = randomColour;

    }

    void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x, ballonSpeed *  100) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DeadEnd")
        {
            score.escape++;
            Destroy(gameObject);
        }
    }

    public void DestroyBalloon()
    {
        circleCollider.enabled = false;

        Score.pop++;

        animatorPop.SetTrigger("pop");

        ballonSpeed = 0;

        Destroy(gameObject, 0.5f);
    }

}
