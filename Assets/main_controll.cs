using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_controll : MonoBehaviour
{
    public Material newMaterialRef;
    public float _animation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newMaterialRef.SetFloat(name: "animation", _animation);
    }
}
