using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;


public class NetworkPlayer : NetworkBehaviour
{
    public Transform root;
    public Transform head;
    public Transform leftHand;
    public Transform rightHand;

    public Transform body;

    public Renderer[] meshToDisable;

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        if(IsOwner)
        {
            foreach (var item in meshToDisable)
            {
                item.enabled = false;
            }
        }
    }

    void Update()
    {
        if(IsOwner)
        {
            root.position = VRRigReference.Singleton.root.position;
            root.rotation = VRRigReference.Singleton.root.rotation;

            head.position = VRRigReference.Singleton.head.position;
            head.rotation = VRRigReference.Singleton.head.rotation;

            rightHand.position = VRRigReference.Singleton.rightHand.position;
            rightHand.rotation = VRRigReference.Singleton.rightHand.rotation;

            leftHand.position = VRRigReference.Singleton.leftHand.position;
            leftHand.rotation = VRRigReference.Singleton.leftHand.rotation;

            body.position = VRRigReference.Singleton.body.position;
            
        }
    }
}
