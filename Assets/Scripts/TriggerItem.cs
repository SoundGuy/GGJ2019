using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Events;

public class TriggerItem : MonoBehaviour
{
    [SerializeField]
    private Collider myCollider;
    [SerializeField]
    private string nameToRespondTo;

    [SerializeField] private UnityEvent actions;
    
    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Colliding  with " + other.gameObject.transform.parent.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " trigger with " +other.name );
        string name = other.gameObject.transform.parent.name;
        Debug.Log("Trigger  with " +name );
        if (name == nameToRespondTo)
        {        
            Debug.Log("Responsing to " + name);
                actions.Invoke();
        }
    }
}
