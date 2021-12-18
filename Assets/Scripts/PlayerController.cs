using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private AudioSource au;
    private GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        au = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < -7)
        {
            transform.position = new Vector3(-7, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 7)
        {
            transform.position = new Vector3(7, transform.position.y, transform.position.z);
        }
    }

    IEnumerator MusicCrazy()
    {
        yield return new WaitForSeconds(1);
        if (GM.isGameActive)
        {
            au.pitch += 0.1f;
        }
        StartCoroutine(MusicCrazy());
    }

}
