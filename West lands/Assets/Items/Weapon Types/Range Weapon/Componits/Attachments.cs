using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "New Attachment", menuName = "RangWeapon/Attachment")]
public class Attachments : Item
{
    [Range(0,3)]
    public int mountSize;
    [Range(0,1)]
    public float accuracy;
    [Range(0,1)]
    public float handling;
    [Range(0, 10)]
    public float Zoom;
    [Space]
    public AttachmentPlacement attachmentPlacement;
    [Space]
    public Object Attachment;
}
