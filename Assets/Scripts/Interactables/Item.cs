using UnityEngine;

public enum ItemName
{
    FLARE,
    KEY_GENERAL,
    KEY_LAB,
    KEY_UNDERGROUND
}

public class Item : Interactable
{
    [field: SerializeField] public ItemName ItemName { get; private set; }

    protected virtual bool AddToPlayerInventory()
    {
        return GameManager.Instance.PlayerInventory.AddToInventory(this);
    }

    public virtual void Consume()
    {

    }
}
