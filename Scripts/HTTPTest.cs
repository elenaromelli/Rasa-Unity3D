using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using System;
using Newtonsoft.Json;


[Serializable]
public class MessageSender
{
    public string sender, message;
}
public class Message
{
    public string recipient_id, text, image;
}
public class HTTPTest : MonoBehaviour
{
    public string text;
    public TextMeshProUGUI displayIncomingText;
    public TextMeshProUGUI inputField;
    public TextMeshProUGUI displayOutgoingText;

    

    public void CallPostRequest(string txt)
    {
        MessageSender thisMSG = new MessageSender();
        thisMSG.sender = "Rasa";
        // read from the input field here.
        thisMSG.message = inputField.text;
        displayOutgoingText.text = inputField.text; 
        string json = JsonUtility.ToJson(thisMSG);
        string a = "http://localhost:5005/webhooks/rest/webhook";
        StartCoroutine(PostRequest(a, json));
    }

    IEnumerator PostRequest(string uri, string json)
    {
        var uwr = new UnityWebRequest(uri, "POST");
        byte[] jsonTOSend = new System.Text.UTF8Encoding().GetBytes(json);
        uwr.uploadHandler = (UploadHandler)new UploadHandlerRaw(jsonTOSend);
        uwr.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        uwr.SetRequestHeader("Content-Type", "application/json");
        Debug.Log(displayIncomingText.text);

        yield return uwr.SendWebRequest();
        
        {
            text = uwr.downloadHandler.text;
            Debug.Log(text);

            string ntext = "";
            string prev = "}";
            string now = ",";
            int prevInd = 1;
            int ind = 1;
            string empty = "" +
                "";
            foreach (char s in text)
            {
                if (prev == s.ToString())
                {
                    string m = text.Substring(prevInd, ind - prevInd);
                    ntext = ntext + JsonConvert.DeserializeObject<Message>(m).text;
                    Debug.Log(m);
                    prevInd = ind + 1;
                    ntext = ntext + empty;
                }
                ind = ind + 1;
            }
            int startInd = text.IndexOf("text") + 6;
            int length = text.Length - 3 - startInd;
            text = ntext;
        }
        displayIncomingText.text = text;

    }
}
