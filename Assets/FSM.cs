using UnityEngine;
using System.Collections;

public class FSM : MonoBehaviour
{
    //Player 트랜스폼
    protected Transform playerTransform;
    //NPC의 다음목적지
    protected Vector3 Nextpos;
    //WandarPoint리스트
    protected GameObject[] PointList;
    //업데이트
    protected virtual void FSMUpdate() { }
    //초기화
    protected virtual void Initialize() { }
    
    void Awake()
    {
        Initialize();
    }
    void Update()
    {
        FSMUpdate();
    }
}
