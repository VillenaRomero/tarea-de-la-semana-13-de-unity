using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float speedx;
    public float speedy;
    public GameObject bulleprefab;
    private float horizontal;
    private float vertical;
    private Rigidbody2D _compRigidbody;
    // Start is called before the first frame update
    void Awake() {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        horizontal = Imput.GetAxis("Horizontal");
        vertical = Imput.GetAxis("vertical");
        if (Imput.GetKeyDown(KeyCode.Space) == true) {
            Instantiate(bulletPrefab,transform.position, transform.rotatiion);
        }
    }
    void FixedYpdate() {
        _compRigidbody.velocity = new Vector2(horizontal*speedx,vertical*speedy);
        
    }
}
