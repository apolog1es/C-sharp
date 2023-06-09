using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5; // Здоровье
    public int level = 1; // Уровень
    public float speed = 1.2f; // Скорость
    // Start is called before the first frame update
    void Start()
    {
        print(health+level + ", " + level + ", " + speed);
    }

    // Update is called once per frame
    void Update()
    {
        //Создаём переменную вида Vector3 и сохраняем в неё позицию NPC
        Vector3 newPosition = transform.position;

        //Меняем позицию NPC по оси z согласно скорости NPC и времени между кадрами
        newPosition.z += speed * Time.deltaTime;

        //Меняем позицию NPC на новое значение, рассчитанное выше
        transform.position = newPosition;
    }
}
