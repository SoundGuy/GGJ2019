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

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == nameToRespondTo)
        {
            Debug.Log("Responsing to " + other.gameObject.transform.parent.name);
                actions.Invoke();
        }
    }
}
