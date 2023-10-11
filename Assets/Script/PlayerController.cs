using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private int count;
    public Text countText;
    public Text menang;
    void Start (){
            rb = GetComponent<Rigidbody>();
            count = 0;
            SetCountText();
    }
    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);
        if(count == 19)
        {
            Win();
        }
    }
    void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        if(other.gameObject.CompareTag("Coin"));{
            other.gameObject.SetActive  (false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText(){
        countText.text = "Count: " + count.ToString();
    }
    void Win()
    {
        menang.text = "YOU WON";
    }
}