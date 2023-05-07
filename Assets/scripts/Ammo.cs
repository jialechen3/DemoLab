using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] public Transform AmmoPosition;
    [SerializeField] public GameObject ammo;
    
    
    private void Awake() {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ammo, AmmoPosition.position, transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
