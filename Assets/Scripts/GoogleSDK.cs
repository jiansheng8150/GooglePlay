using UnityEngine;

public class GoogleSDK : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Login()
    {
        Debug.Log("Loginsdfdf");
        // "com.unity3d.player.UnityPlayer"�̶�д��
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        // "currentActivity" �̶�д��
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        if (jo != null)
        {
            jo.Call("Login");          // �Ǿ�̬���� 
        }
    }
}
