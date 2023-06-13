using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 2D的顏色選取
public class ColorPicker : MonoBehaviour
{
    [SerializeField]
    Camera cam;
    [SerializeField]
    RectTransform texture;
    [SerializeField]
    RectTransform textureRightUp;
    [SerializeField]
    GameObject showColor;

    [SerializeField]
    Texture2D refSprite;

    public void OnClickPickerColor()
    {
        SetColor();
    }
    private void SetColor()
    {
        Vector3 imagePos = cam.WorldToScreenPoint(texture.position);
        Vector3 imagePos_RightUp = cam.WorldToScreenPoint(textureRightUp.position);
        float globalPosX = Input.mousePosition.x - imagePos.x;
        float globalPosY = Input.mousePosition.y - imagePos.y;

        int localPosX = (int)(globalPosX * (refSprite.width / (imagePos_RightUp.x - imagePos.x)));
        int localPosY = (int)(globalPosY * (refSprite.height / (imagePos_RightUp.y - imagePos.y)));

        Color c = refSprite.GetPixel(localPosX, localPosY);
        SetActualColor(c);

        Debug.Log("globalPos:" + globalPosX + "," + globalPosY);
        Debug.Log("localPos:" + localPosX + "," + localPosY);
        Debug.Log("imagePos:" + imagePos);
        Debug.Log("imagePos_RightUp:" + imagePos_RightUp);
    }

    void SetActualColor(Color c)
    {
        showColor.GetComponent<Image>().color = c;
    }
}
