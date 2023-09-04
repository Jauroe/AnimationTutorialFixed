using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float hareketHizi = 4f;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * -1;
        float z = Input.GetAxis("Vertical") * -1;
        Vector3 hareket = new Vector3(x, 0, z);
        transform.Translate(hareket * (hareketHizi * Time.deltaTime));
    }
}
