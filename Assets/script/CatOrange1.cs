using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatOrange1 : MonoBehaviour
{
    public float speed;
    public Transform target;
    Vector2 ukuranAwal;

    // Start is called before the first frame update
    void Start() {
        ukuranAwal = transform.localScale;
    }

    // Update is called once per frame
    void Update() {
        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        //Animasi 

        //flip code
        if (transform.position.x < target.position.x) {
            transform.localScale = new Vector2(ukuranAwal.x, ukuranAwal.y);
        } else if (transform.position.x > target.position.x) {
            transform.localScale = new Vector2(-ukuranAwal.x, ukuranAwal.y);
        }
    }
}
