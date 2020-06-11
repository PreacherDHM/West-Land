using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTownPeople : NpcBace
{
    SpeachBubbel speachBubbel;



    public override void Angery()
    {
        
    }

    public override void Attaced()
    {
        throw new System.NotImplementedException();
    }

    public override void Dead()
    {
        throw new System.NotImplementedException();
    }

    public override void Happy()
    {
        throw new System.NotImplementedException();
    }

    public override void Interacting()
    {
        throw new System.NotImplementedException();
    }

    public override void Roming()
    {
        throw new System.NotImplementedException();
    }

    public override void Sad()
    {
        throw new System.NotImplementedException();
    }

    public override void Scared()
    {
        throw new System.NotImplementedException();
    }

    public override NPCState SetStartingState()
    {
        speachBubbel = GetComponent<SpeachBubbel>();
        return NPCState.stayingPut;
    }

    public override void StayingPut()
    {
        interactible = true;
    }
}
