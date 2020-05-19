using UnityEngine;
using UnityEngine.Networking;

public class RequestHelper
{
    public UnityWebRequest Post(string url, object obj)
    {
        UnityWebRequest request = UnityWebRequest.Put(
            url,
            JsonUtility.ToJson(obj)
        );
        request.method = "POST";
        request.SetRequestHeader("Content-Type", "application/json");
        request.SendWebRequest();
        return request;
    }
}