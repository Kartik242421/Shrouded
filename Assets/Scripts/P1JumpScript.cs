using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1JumpScript : MonoBehaviour
{
    public GameObject Player1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("P2SpaceDetector"))
        {
            if (Player1Move_New.FacingRightP1 == true)
            {
                Player1.transform.Translate(-0.8f, 0, 0);

            }
            if (Player1Move_New.FacingLeftP1 == true)
            {
                Player1.transform.Translate(0.8f, 0, 0);

            }
        }
    }
}


