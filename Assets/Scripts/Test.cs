using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    Button btn;
    bool canClick;
    void Start()
    {
        canClick = true;
        btn = GetComponent<Button>();
        btn.onClick.AddListener(()=>{
            if(canClick)
                StartCoroutine(Capture());
        });
    }

    IEnumerator Capture()
    {
        canClick = false;
        SetBtn(false);//Hide the button
        yield return new WaitForEndOfFrame();
        var img = ScreenCapture.CaptureScreenshotAsTexture();
        StartCoroutine(Post(img.EncodeToJPG()));
        SetBtn(true);//Show the button
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene(0);
        }
    }
    IEnumerator Post(byte[] img)
    {
        WWWForm form = new WWWForm();
        if(!Session.session.isGeust)
            form.AddField("user_id", Session.session.UserId);
        form.AddBinaryData("img", img);
        using (UnityWebRequest www = UnityWebRequest.Post(Env.Api("predict"), form))
        {
            yield return www.SendWebRequest();
            if (www.result == UnityWebRequest.Result.Success)
            {
                ColorJson colorJson=JsonUtility.FromJson<ColorJson>(www.downloadHandler.text);
                Session.session.Predict(colorJson);
                SceneManager.LoadScene(3);
            }
        }
    }
    void SetBtn(bool isShow)
    {
        Text text = btn.transform.GetChild(0).GetComponent<Text>();
        ColorBlock color = btn.colors;
        color.normalColor = new Color(1, 1, 1, isShow ? 1 : 0);
        btn.colors = color;
        text.text = isShow ? "Predicting..." : "";
    }
}
