﻿using UnityEngine;

public class Endir : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter() {
        gameManager.LoadNextLevel(); // Loader næsta level við 
    }
}
