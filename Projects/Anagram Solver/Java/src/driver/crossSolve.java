package driver;
import java.io.*;
import java.util.*;

class crossSolve
{
    String alpha = new String("abcdefghijklmnopqrstuvwxyz");
    void permuter(StringBuffer word)
    {
        int blanks,i,j;
        blanks=0;
        StringBuffer positions = new StringBuffer();
        crossSolve ques=new crossSolve();
        positions.delete(0,positions.length());
        for(i=0;i<word.length();i++)
        {
            if(word.charAt(i)=='?')
            {
                blanks++;
                positions.insert(positions.length(),i);
            }
        }
        StringBuffer posibs=new StringBuffer(blanks);
        
        ques.filler(word,blanks,blanks,positions,posibs,0,0);
    }
    void filler(StringBuffer name,int times,int len,StringBuffer places,StringBuffer temp,int pos,int character)
    {
        StringBuffer changer = new StringBuffer();
        while(times>0)
        {
            while(character!=26)
            {
                temp.insert(pos,alpha.charAt(character));
                pos++;
                times--;
                if(times==0)
                {
                    
                }
            }
        }
    }
    public static void main(String args[])throws IOException
    {
        crossSolve test = new crossSolve();
        StringBuffer sb=new StringBuffer("m??");
        test.permuter(sb);
    }
}
