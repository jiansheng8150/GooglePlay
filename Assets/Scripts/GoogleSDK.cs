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
        // "com.unity3d.player.UnityPlayer"固定写法
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        // "currentActivity" 固定写法
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        if (jo != null)
        {
            jo.Call("Login");          // 非静态方法 
        }
    }
}
