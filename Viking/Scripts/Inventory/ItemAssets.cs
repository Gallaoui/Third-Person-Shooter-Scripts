using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite WeaponSprite;
    public Sprite PotionSprite;
    public Sprite CoinSprite;
    public Sprite MedkitSprite;
}
