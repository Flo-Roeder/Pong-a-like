using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private int speed;
    private Rigidbody2D ballRb;

    // Start is called before the first frame update
    void Awake()
    {
        ballRb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LaunchBall()
    {
        this.transform.position = new Vector2(0, 0);

        int _randVeloX = Random.Range(0, 2) == 0 ? -1 : 1;
        int _randVeloY = Random.Range(0, 2) == 0 ? -1 : 1;
        ballRb.velocity=new Vector2(_randVeloX*speed,_randVeloY*speed);
    }
}
