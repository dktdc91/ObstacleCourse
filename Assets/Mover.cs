using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float xValue = 0.001f ;
    [SerializeField] private float yValue = 0.001f ;
    [SerializeField] private float zValue = 0.001f ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(xValue,yValue,zValue);  
    }
}
