using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    public enum ItemType
    {
        Weapon,
        RedPotion,
        Coin,
        Medkit,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Coin:      return ItemAssets.Instance.CoinSprite;
            case ItemType.Medkit:    return ItemAssets.Instance.MedkitSprite;
            case ItemType.Weapon:    return ItemAssets.Instance.WeaponSprite;
            case ItemType.RedPotion: return ItemAssets.Instance.PotionSprite;
        }
    }
}
