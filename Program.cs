﻿using System;

namespace writer
{
  class Program
  {
    static void Main(string[] args)
    {
      string output = "Nasvhille Software School";
      Writer author = new Writer("I do declare: ");

      author.Write(output);

      author.Prefix = "That's right, I said: ";
      author.Write(output);
    }
  }


}
