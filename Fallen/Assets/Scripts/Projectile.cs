using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;

    public GameObject enemy;

    private Vector2 target;

    void Start() {

        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    void Update() {

        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, target) < 0.2f) {

            // Make Enemy if Projectile Misses
            // Instantiate(enemy, transform.position, Quaternion.identity);

            Destroy(gameObject);

        }

    }
}
