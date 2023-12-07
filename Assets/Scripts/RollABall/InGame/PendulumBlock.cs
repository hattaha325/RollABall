using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PendulumBlock : MonoBehaviour
{
    public float Amplitude = 5f;
    public float Frequency = 1f;
    private Vector3 startPos = Vector3.zero;

    /// <summary>
    /// Unity��Ń|���S����\������N���X
    /// </summary>
    private MeshRenderer boxMesh;
    float time = 1.0f;

    private void Start()
    {
        startPos = transform.position;
        // Start���_�ő������
        boxMesh = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        transform.position = startPos + Vector3.forward * Amplitude * Mathf.Sin(Time.time * Frequency);
        // 1�b����f���^�^�C�������炵�Ă���
        time -= Time.deltaTime;
        if (time < 0f)
        {
            // BoxMesh�̕\�����A���݂̕\���̔��΂ɑ������
            boxMesh.enabled = !boxMesh.enabled;
            time = 1f;
        }
    }
}
