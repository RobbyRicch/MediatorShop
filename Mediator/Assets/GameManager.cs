using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

  
    public static int moneyInPocket = 0;
    public AudioSource Rick;
    
    public void BuySong()
    {
        if (moneyInPocket == 42069 && Input.GetKey(KeyCode.E))
        {
            Rick.Play();
            GetMoney.molah = 0;
            moneyInPocket = 0;
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        BuySong();
    }
}
