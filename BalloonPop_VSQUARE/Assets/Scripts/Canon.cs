//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] GameObject ballonPrefab;
    [SerializeField] Transform canonWholeTranform;
    [SerializeField] Animator animatorFire;

    public float ballonSpwanSpeed = 1.0f;
    public int ballonSpawnRate = 1;

    private void Start()
    {
        StartCoroutine(BalloonSpawn());
    }

    IEnumerator BalloonSpawn()
    {
        while (true)
        {
            for (int i = 0; i < ballonSpawnRate; i++)
            {
                Vector3 canonface = canonWholeTranform.transform.position;

                animatorFire.SetTrigger("fire");

                var temp = Instantiate(
                    ballonPrefab, 
                    canonface, 
                    Quaternion.identity)
                    .GetComponent<Rigidbody2D>();

                temp.transform.position = new Vector2(
                    temp.transform.position.x + Random.Range(-2, 2f),
                    temp.transform.position.y + Random.Range(-1, 1.5f));

                temp.AddForce(canonWholeTranform.up * 5.0f * 1000);
            }
            yield return new WaitForSeconds(ballonSpwanSpeed);
        }


    }
}
