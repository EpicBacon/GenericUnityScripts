using UnityEngine;
using System.Collections;

public static class ConsitentSize
{

    private static float _scaledHeigh;
    private static float _scaledWidth;

    public static Vector2 Getscaled(Texture2D Tex_Current)
    {
        float textureWidth = Tex_Current.width;
        float textureHeight = Tex_Current.height;

        float screenWidth = (float)Screen.width;
        float screenHeight = (float)Screen.height;

        float screenAspectRatio = (screenWidth / screenHeight);
        float textureAspectRatio = (textureWidth / textureHeight);

        if (textureAspectRatio <= screenAspectRatio)
        {
            // The scaled size is based on the height
            _scaledHeigh = screenHeight;
            _scaledWidth = (screenHeight * textureAspectRatio);
        }
        else
        {
            // The scaled size is based on the width
            _scaledWidth = screenWidth;
            _scaledHeigh = (_scaledWidth / textureAspectRatio);
        }
        return new Vector2(_scaledWidth, _scaledHeigh);
    }
}
