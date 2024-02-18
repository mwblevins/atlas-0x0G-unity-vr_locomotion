using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public GameObject Target;
    public float speed = 1.5f;

    void Update()
    {
        transform.LookAt(Target.gameObject.transform);
        GetComponent<Animator>().SetTrigger("Move");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
