using System;
using System.Collections.Concurrent;

public class Scripture 
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] entireThing = text.Split(' ');
        foreach(var aWord in entireThing)
        {
            Word wordObject = new Word(aWord);
            _words.Add(wordObject);
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        List<Word> randomWords = _words.Where(x => !x.IsHidden()).OrderBy(x => random.Next()).Take(2).ToList();
    
        foreach (Word word in randomWords)
        {
        word.hide();
        }
    
    }

    public string GetDisplayText()
    {
        String completeText = $"{_reference.GetDisplayText()} ";
        foreach(Word word in _words)
        {
            completeText = completeText + " " + word.GetDisplayText();
        }
        return completeText;
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }













}