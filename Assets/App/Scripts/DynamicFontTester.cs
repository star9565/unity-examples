using UnityEngine;

using System;
using System.Collections;

public class DynamicFontTester : MonoBehaviour 
{
    enum State
    {
        BUG,
        FIX,
    };

    static readonly string[] TEST_TEXTS = new string[] 
    {
        "가나다라마바사",
        "ABCDEFGHIJKLM",
        "아자차카타파하",
        "OPQRSTUVWXYZ!",
        "간난단란만반산",
        "1234567890@#$",
        "안잔찬칸탄판한",
    };

    public Font font;

    void Update () 
    {
        if (_state == State.BUG)
        {
            var curTime = DateTime.UtcNow;
            if (curTime >= _nextTime)
            {
                _index += 1;
                _index %= TEST_TEXTS.Length;
                _nextTime += new TimeSpan(hours: 0, minutes: 0, seconds: 1);
                font.RequestCharactersInTexture(TEST_TEXTS[_index], size: 64);
            }
        }
    }

    void OnGUI()
    {
        if (GUI.Toggle(new Rect(10, 10, 100, 50), _state == State.BUG, "BUG"))
        {
            _state = State.BUG;
        }
        if (GUI.Toggle(new Rect(110, 10, 100, 50), _state == State.FIX, "FIX"))
        {
            _state = State.FIX;
        }

        if (_state == State.FIX)
        {
            var curTime = DateTime.UtcNow;
            if (curTime >= _nextTime)
            {
                _index += 1;
                _index %= TEST_TEXTS.Length;
                _nextTime += new TimeSpan(hours: 0, minutes: 0, seconds: 1);
                font.RequestCharactersInTexture(TEST_TEXTS[_index], size: 64);
            }
        }
    }

    State _state = State.BUG;

    int _index = 0;

    DateTime _nextTime = DateTime.UtcNow;
}
