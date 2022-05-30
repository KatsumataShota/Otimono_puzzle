using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PuyoType
{
    Black = 0,

    Green = 1,
    Red = 2,
    Yellow = 3,
    Blue = 4,
    Purple = 5,
    Cyan = 6,

    Invalid = 7,
};

public class PuyoController : MonoBehaviour
{
    static readonly Color[] color_table = new Color[]
    {
        Color.black,

        Color.green,
        Color.red,
        Color.blue,
        Color.yellow,
        Color.magenta,
        Color.cyan,

        Color.gray,
    };

    [SerializeField] Renderer my_renderer = default!;//自分自身のmaterialを登録
    PuyoType _type = PuyoType.Invalid;

    public void SetPuyoType(PuyoType type)
    {
        _type = type;

        my_renderer.material.color = color_table[(int)_type];
    }
    public PuyoType GetPuyoType()
    {
        return _type;
    }
    public void SetPos(Vector3 pos)
    {
        this.transform.localPosition = pos;
    }
}
