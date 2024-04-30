using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class InteractableObject : MonoBehaviour
{
    public NavMeshAgent playerAgentObj;
    private bool haveInteracted = false;
    public void OnClick(NavMeshAgent playerAgent)
    {
        this.playerAgentObj = playerAgent;
        playerAgent.stoppingDistance = 2;   // 在物品前停止距离

        playerAgent.SetDestination(transform.position); // 获取到点击的物品

        haveInteracted = false;

    }

    private void Update()
    {
        if (playerAgentObj != null&& haveInteracted == false && playerAgentObj.pathPending == false)
        {
            if (playerAgentObj.remainingDistance <= 2)
            {
                haveInteracted = true;
                Interact();
            }
        }
    }

    protected virtual void Interact()       // 父类给子类重写
    {
        print("Interacting with Interactable Object.");
    }
}
