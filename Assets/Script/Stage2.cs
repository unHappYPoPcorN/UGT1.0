using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Stage2 : MonoBehaviour
{

    System.Random rand = new System.Random();

    public Image[] keyImg = new Image[12];
    int keyIdx;
    struct Keyin
    {
        public char k;
        public Boolean needPress;
    };

    Dictionary<KeyCode, Action> keyDictionary;

    char[] keys = new char[12];

    char needKey;
    Boolean needKeydown;

    // Start is called before the first frame update
    void Start()
    {

        {
            keys[0] = 'Q';
            keys[1] = 'W';
            keys[2] = 'E';
            keys[3] = 'A';
            keys[4] = 'S';
            keys[5] = 'D';
            keys[6] = 'I';
            keys[7] = 'O';
            keys[8] = 'P';
            keys[9] = 'J';
            keys[10] = 'K';
            keys[11] = 'L';
        }

        for (int i = 0; i < keyImg.Length; i++)
        {
            keyImg[i].gameObject.SetActive(false);
        }

        keyDictionary = new Dictionary<KeyCode, Action>
        {
            { KeyCode.Q, KeyDown_Q },
            { KeyCode.W, KeyDown_W },
            { KeyCode.E, KeyDown_E },
            { KeyCode.A, KeyDown_A },
            { KeyCode.S, KeyDown_S },
            { KeyCode.D, KeyDown_D },
            { KeyCode.I, KeyDown_I },
            { KeyCode.O, KeyDown_O },
            { KeyCode.P, KeyDown_P },
            { KeyCode.J, KeyDown_J },
            { KeyCode.K, KeyDown_K },
            { KeyCode.L, KeyDown_L }
        };

        keyChange();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (var dic in keyDictionary)
            {
                if (Input.GetKeyDown(dic.Key))
                {
                    dic.Value();
                }
            }
        }
    }

    private void keyChange()
    {
        needKeydown = true;
        keyIdx = rand.Next(0, 12);
        needKey = keys[keyIdx];
        keyImg[keyIdx].gameObject.SetActive(true);
        Debug.Log(needKey + " " + keyIdx);
    }

    private void wrongKey()
    {
        Debug.Log("wrong key!");
    }

    private void KeyDown_Q()
    {
        if (needKey == 'Q')
        {
            keyImg[0].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }
    private void KeyDown_W()
    {
        if (needKey == 'W')
        {
            keyImg[1].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }
    private void KeyDown_E()
    {
        if (needKey == 'E')
        {
            keyImg[2].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }
    private void KeyDown_A()
    {
        if (needKey == 'A')
        {
            keyImg[3].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }
    private void KeyDown_S()
    {
        if (needKey == 'S')
        {
            keyImg[4].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }
    private void KeyDown_D()
    {
        if (needKey == 'D')
        {
            keyImg[5].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }
    private void KeyDown_I()
    {
        if (needKey == 'I')
        {
            keyImg[6].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }
    private void KeyDown_O()
    {
        if (needKey == 'O')
        {
            keyImg[7].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }
    private void KeyDown_P()
    {
        if (needKey == 'P')
        {
            keyImg[8].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }
    private void KeyDown_J()
    {
        if (needKey == 'J')
        {
            keyImg[9].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }
    private void KeyDown_K()
    {
        if (needKey == 'K')
        {
            keyImg[10].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }
    private void KeyDown_L()
    {
        if (needKey == 'L')
        {
            keyImg[11].gameObject.SetActive(false);
            keyChange();
        }
        else wrongKey();
    }

}
