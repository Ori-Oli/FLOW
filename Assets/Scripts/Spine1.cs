using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spine1 : MonoBehaviour
{
    [SerializeField]
    private GameObject wall;

    public float rotationSpeed = 100f; // 초당 회전 속도 (도 단위)
    float radius = 2f; // 원의 반지름
    float angle = 90f; // 현재 각도 (도 단위)

    public int wallCount = 0;

    void Update()
    {
        // 각도를 회전 속도와 시간을 기반으로 증가시킴
        angle += rotationSpeed * Time.deltaTime;

        // 각도를 라디안으로 변환
        float rad = angle * Mathf.Deg2Rad;

        // 새로운 위치 계산
        Vector2 target = new Vector2(Mathf.Cos(rad) * radius, Mathf.Sin(rad) * radius);
        transform.position = target;

        // 벽을 한 번만 생성
        if (wallCount == 0) {
            int randomAngle = Random.Range(0, 360);
            Vector2 spawnPos = new Vector2(Mathf.Cos(randomAngle * Mathf.Deg2Rad) * radius, Mathf.Sin(randomAngle * Mathf.Deg2Rad) * radius);
            Instantiate(wall, spawnPos, Quaternion.Euler(0, 0, randomAngle - 90));
            wallCount = 1;
        }
    }
}
