using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;
    private bool hasSafeArea = false;

    private float livesLabelHalfWidth;
    private float livesLabelHalfHeight;

    private float scoreLabelHalfWidth;
    private float scoreLabelHalfHeight;

    void Start()
    {
        livesLabelHalfWidth = LivesLabel.rectTransform.rect.width * 0.5f;
        livesLabelHalfHeight = LivesLabel.rectTransform.rect.height * 0.5f;

        scoreLabelHalfWidth = ScoreLabel.rectTransform.rect.width * 0.5f;
        scoreLabelHalfHeight = ScoreLabel.rectTransform.rect.height * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        hasSafeArea = (Screen.width == Screen.safeArea.width && Screen.height == Screen.safeArea.height) ? false : true;
        Debug.Log(Screen.safeArea.height);

        Vector2 safeAreaBounds = new Vector2(Screen.safeArea.width, Screen.safeArea.height);
        Vector2 bounds = new Vector2(Screen.width, Screen.height);

        Debug.Log(bounds.y - safeAreaBounds.y);


        var positionOffset = Screen.safeArea.position * 0.5f;

        var widthDiff = Screen.width - Screen.safeArea.width;
        var heightDiff = Screen.height - Screen.safeArea.height;

        LivesLabel.rectTransform.position = new Vector2(Screen.safeArea.xMin + livesLabelHalfWidth, Screen.safeArea.yMax - livesLabelHalfHeight);
        ScoreLabel.rectTransform.position = new Vector2(Screen.safeArea.xMax - scoreLabelHalfWidth, Screen.safeArea.yMax - scoreLabelHalfHeight);
        

        /*
        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                LivesLabel.rectTransform.anchoredPosition = new Vector2((bounds.x - safeAreaBounds.x) + (360.0f), (bounds.y - safeAreaBounds.y) + (80.0f));
                ScoreLabel.rectTransform.anchoredPosition = new Vector2((bounds.x - safeAreaBounds.x) + (360.0f), (bounds.y - safeAreaBounds.y) + (80.0f));   //  -200 y for samsung galaxy S10
                SceneLabel.text = "Portrait";

                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(543.0f, -200.0f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-597.0f, -200.0f);   //  -200 y for samsung galaxy S10
                    SceneLabel.text = "Portrait";
                }
                else 
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(543.0f, -83.0f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-597.0f, -83.0f);   //  -200 y for samsung galaxy S10
                    SceneLabel.text = "Portrait";
                }
                break;
            case ScreenOrientation.LandscapeLeft:
                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(517.0f, -86.0f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-443.0f, -86.0f);
                    SceneLabel.text = "LandscapeLeft";
                }
                else
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(517.0f, -86.0f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-443.0f, -86.0f);
                    SceneLabel.text = "LandscapeLeft";
                }
               
                break;
            case ScreenOrientation.LandscapeRight:
                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(394.0f, -86.0f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-533.0f, -86.0f);
                    SceneLabel.text = "LandscapeRight";
                }
                else
                {

                }
               
                break;
            case ScreenOrientation.Unknown:
                SceneLabel.text = "Unknown";
                break;
            default:
                SceneLabel.text = "Something Else";
                break;
        }
        /*
        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(543.0f, -83.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-597.0f, -83.0f);   //  -200 y for samsung galaxy S10
                SceneLabel.text = "Portrait";
                break;
            case ScreenOrientation.LandscapeLeft:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(517.0f, -86.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-443.0f, -86.0f);
                SceneLabel.text = "LandscapeLeft";
                break;
            case ScreenOrientation.LandscapeRight:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(394.0f, -86.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-533.0f, -86.0f);
                SceneLabel.text = "LandscapeRight";
                break;
            case ScreenOrientation.Unknown:
                SceneLabel.text = "Unknown";
                break;
            default:
                SceneLabel.text = "Something Else";
                break;
        } 
        */
        //*/

    }
}
