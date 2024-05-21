using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;

    private KitchenObject kitchenObject;

    public void Interact()
    {

        if (kitchenObject == null)
        {


            Debug.Log("Interact!");
            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefeb, counterTopPoint);
            kitchenObjectTransform.GetComponent<KitchenObject>().SetCleaerCounter(this);

        }
        else
        {
            Debug.Log(kitchenObject.GetCleaerCounter());
        }


    }
    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }

}
