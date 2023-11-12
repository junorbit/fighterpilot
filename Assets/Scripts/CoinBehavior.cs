using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, -2, 0) * Time.deltaTime * 1);
        if (transform.position.y < -8f)
        {
          Destroy(this.gameObject);
        }
        if (transform.position.x < -9.5f)
        {
          Destroy (this.gameObject);
        }
    }
     void OnTriggerEnter2D(Collider2D whatIHit)
    {
       if(whatIHit.tag == "Player")
       {
         GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(2);
         Destroy(this.gameObject);
       }
    }
}