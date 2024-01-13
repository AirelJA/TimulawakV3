using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            MainManager.isGameOver = true;
            gameObject.SetActive(false);
        }

        if (collision.transform.tag == "Finish")
        {
            //FinishStageTrigger.StageComplete();

            MainManager.isNextStage = true;
            gameObject.SetActive(false);
        }
    }
}
