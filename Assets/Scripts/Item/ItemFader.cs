using DG.Tweening;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
public class ItemFader : MonoBehaviour
{
    private SpriteRenderer sprite;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void FadeIn()
    {
        Color targetColor = new Color(1, 1, 1, 1);
        sprite.DOColor(targetColor, Settings.fadeDuration);
    }

    public void FadeOut()
    {
        Color targetColor = new Color(1, 1, 1, Settings.targetAlpha);
        sprite.DOColor(targetColor, Settings.fadeDuration);
    }

}
