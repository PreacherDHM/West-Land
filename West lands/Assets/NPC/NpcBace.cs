using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NPCState
{
    interacting,
    attacted,
    angery,
    sad,
    happy,
    scared,
    roming,
    stayingPut,
    Dead
};

public abstract class NpcBace : MonoBehaviour
{
    public NPCState _npcState;
    public bool interactible;

    public abstract NPCState SetStartingState();
    public abstract void Interacting();
    public abstract void Attaced();
    public abstract void Angery();
    public abstract void Sad();
    public abstract void Happy();
    public abstract void Scared();
    public abstract void Roming();
    public abstract void StayingPut();
    public abstract void Dead();

    public void SetState()
    {
        CurentState();
    }

    private void Start()
    {
       _npcState = SetStartingState();
    }

    private void Update()
    {
        CurentState();
    }

    public void CurentState()
    {
        switch (_npcState)
        {
            case NPCState.interacting:
                if(interactible)
                    Interacting();
                break;
            case NPCState.attacted:
                Attaced();
                break;
            case NPCState.angery:
                Angery();
                break;
            case NPCState.sad:
                Sad();
                break;
            case NPCState.happy:
                Happy();
                break;
            case NPCState.scared:
                Scared();
                break;
            case NPCState.roming:
                Roming();
                break;
            case NPCState.stayingPut:
                StayingPut();
                break;
            case NPCState.Dead:
                Dead();
                break;
            default:
                break;
        }
    }



}
