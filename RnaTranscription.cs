using System;
using System.Collections.Generic;
using System.Text;

public static class RnaTranscription
{

    public static string ToRna(string nucleotide)
    {
        var map = new Dictionary<string, string>() { {"A", "U"}, {"C", "G"}, {"G", "C"}, {"T", "A"} };
        var rna = new StringBuilder();

        for (var index = 0; index < nucleotide.Length; index++) {
            var value = map[nucleotide[index].ToString()];
            
            rna.Append(value);
        }
        
        return rna.ToString();
    }
}