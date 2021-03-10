using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spamDelay = 1f;
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        timer += Time.deltaTime;
        if (timer >= spamDelay && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0f;
        }
    }
}
