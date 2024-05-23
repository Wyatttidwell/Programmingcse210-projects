
using System;

public class Fractions{


    private int topP;
    private int bottomP;
    public Fractions (){
        topP = 1;
        bottomP = 1;
    }
    public Fractions (int whole){
        topP = whole;
        bottomP = 1;
    }
    public Fractions(int topS, int bottomS){
        topP = topS;
        bottomP = bottomS;
    }
    public string getFraction(){

        string output = $"{topP}/{bottomP}";
        return output;
    }
    public double getDecimal(){
        return (double)topP / (double)bottomP;
    }
}