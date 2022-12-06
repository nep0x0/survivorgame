using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDemon1 : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float minimunDistance;
    Vector2 ukuranAwal;

    // Start is called before the first frame update
    void Start()
    {
        ukuranAwal = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > minimunDistance) {
            //follow code
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        } else {
            // Attack code
        }


        //flip code
        if (transform.position.x < target.position.x) {
            transform.localScale = new Vector2(ukuranAwal.x, ukuranAwal.y);
        } else if (transform.position.x > target.position.x) {
            transform.localScale = new Vector2(-ukuranAwal.x, ukuranAwal.y);
        }
    }
}
