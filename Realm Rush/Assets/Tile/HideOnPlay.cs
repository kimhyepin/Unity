using UnityEngine;

public class HideOnPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 게임 실행 시 오브젝트를 비활성화합니다.
        gameObject.SetActive(false);
    }
}
