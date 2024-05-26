using System;
using System.Collections.Concurrent;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void hide()
    {
        _text = new string('_', _text.Length);
        _isHidden = true;
    }

    public void show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }








}