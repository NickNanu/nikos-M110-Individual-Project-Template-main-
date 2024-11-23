using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class workTime : MonoBehaviour
{
    public GameObject TakeAbreak;

    public FirstPersonController move;

    public GameObject BreakTime;

    public GameObject DartPickup;

    public Animator SunAnimation;

    public GameObject EndSound;

    public GameObject continueWork;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void startWorking()
    {
        StartCoroutine(workFirstPart());
    }

    IEnumerator workFirstPart()
    {
        move.enabled=false;
        yield return new WaitForSeconds(10);
        
        move.enabled=true;
        BreakTime.SetActive(true);
        TakeAbreak.SetActive(true);
        DartPickup.SetActive(true);
    }

    public void PassTimeAnim()
    {
        StartCoroutine(PassTime());
    }
    IEnumerator PassTime()
    {
        continueWork.SetActive(true);
        move.enabled=false;
        SunAnimation.enabled=true;
        yield return new WaitForSeconds(10);

        EndSound.SetActive(true);
        
        
    }
}
