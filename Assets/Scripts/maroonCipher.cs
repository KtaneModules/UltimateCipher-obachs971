﻿using Words;
public class maroonCipher : cipherBase
{
    protected override string Name { get { return "Maroon"; } }
    protected override string ColorblindLetter { get { return "Q"; } }

    static int moduleIdCounter = 1;

    protected override void Initialize()
    {
        moduleId = moduleIdCounter++;
        answer = new Data().PickWord(6);
        Log("MAROON", "Generated Word: {0}", answer);
        pages = marooncipher(answer);
    }
}
