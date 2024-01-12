using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            GameManager.isGameOver = true;
            gameObject.SetActive(false);
        }

        if (collision.transform.tag == "Finish")
        {
            //FinishStageTrigger.StageComplete();

            GameManager.isNextStage = true;
            gameObject.SetActive(false);
        }
    }
}
