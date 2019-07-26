﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator model;
    public Animator player;
    
    void Update()
    {
    }

    public void Stop()
    {
        if (!StageCobtroller.Shooting)
        {
            player.SetFloat("Spead", 0);
            if (StageCobtroller.stageNum != 3)
            {
                model.SetFloat("Spead", 0);

            }
        }
    }
    public void ReState()
    {
        if (!StageCobtroller.Shooting)
        {
            player.SetFloat("Spead", 1);
            if (StageCobtroller.stageNum != 3)
            {
                model.SetFloat("Spead", 1);

            }
        }
    }

    public void ModelSet(GameObject gameObject2,GameObject gameObject )
    {
        if (!StageCobtroller.Shooting)
        {
            player = gameObject.GetComponent<Animator>();
            if (StageCobtroller.stageNum != 3)
            {
                model = gameObject2.GetComponent<Animator>();

            }
        }
    }

    public void AnimationStart(float rimit, int num,string aTrigger)
    {
        if (!StageCobtroller.Shooting)
        {
            StartCoroutine(Animation(rimit, num, aTrigger));
        }
    }

    IEnumerator Animation(float rimit, int num, string aTrigger)
    {
        yield return new WaitForSeconds(rimit);
        if (num == 1)
        {
            player.SetTrigger(aTrigger);
        }
        else
        {
            if (StageCobtroller.stageNum != 3)
            {
                model.SetTrigger(aTrigger);
            }
        }
    }
}
