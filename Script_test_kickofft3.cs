using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_test_kickofft3 : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    public int kickoff;
   public void SpeedRun()
    {
        if(speed == 0)
        {
            for(int i = 0; i < 10; i++)
            {
                speed = speed + 1;
            }
        }
    }
    

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
