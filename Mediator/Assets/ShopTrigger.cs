using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.moneyInPocket == 42069)
        {
            Debug.Log("You have the required amount for this purchase");
            

        }
        else
        {
            Debug.Log("Bro you ain't got enough caaaaaaaaash");

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
