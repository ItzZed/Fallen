using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;

    public GameObject effect;

    private Player player;
    private Transform playerPos;
    private HealthSystem playerHealthSystem;

    void Start() {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealthSystem = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();

    }

    void Update() {

        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

    }

    void OnTriggerEnter2D(Collider2D other) {
        
        if(other.CompareTag("Player")) {
            Instantiate(effect, transform.position, Quaternion.identity);
            player.health--;
            playerHealthSystem.TakeDamage(-1);
            Debug.Log(player.health);
            Destroy(gameObject);

        }

        if(other.CompareTag("Projectile")) {

            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(gameObject);

        }

    }

}
