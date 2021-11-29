using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetMoney : MonoBehaviour
{
    public static int molah = 0;
    [SerializeField]TextMeshProUGUI moneyAmount;
    private void Start()
    {
        molah = int.Parse(moneyAmount.text);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (molah == 0 )
        {
            Debug.Log("You got some cash bro");
            molah += 42069;
            GameManager.moneyInPocket = molah;
           
        }
        else
        {
            Debug.Log("Yn3n rabak you don't need more");
        }
        
    }

    private void Update()
    {
        moneyAmount.text = molah.ToString();
    }

}
