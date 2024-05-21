using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;


    private ClearCounter clearCounter;

    public KitchenObjectSO GetKitchenObjectSo()
    {
        return kitchenObjectSO;
    }
    


    public void SetCleaerCounter(ClearCounter clearCounter)
    {
        //clear de ClearCounter
        if (this.clearCounter != null)
        {
            this.clearCounter.ClearKitchenObject();
        }

        //set the new ClearCounter
        this.clearCounter = clearCounter;

        if(clearCounter.HasKitchenObject())
        {
            Debug.LogError("Counter alredy has a KitchenObject!");
        }

        clearCounter.SetKitchenObject(this);

        transform.parent = clearCounter.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }

    public ClearCounter GetCleaerCounter()
    {
        return this.clearCounter;
    }


}
