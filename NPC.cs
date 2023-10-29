using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int lvl = 1; // Создаем переменную хранящую уровень NPC
        int health = 2; // Создаем переменную хранящую здоровье NPC
        health+= lvl; // Присваваем уровень к здоровью
        print(health); // Выводим в консоль полученный результат



    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1.2f;
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
