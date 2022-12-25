using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {
    public static PlayerInfo instance;
    [SerializeField] private List<Item> inventory;


    private void Init() {
        if (instance != null) {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Awake() {
        Init();
    }

    public void ItemAdd(Item item) {
        inventory.Add(item);
    }
}