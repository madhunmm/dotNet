package driver;

import java.io.*;
import java.util.*;
import javax.swing.JComboBox;

class CrosswordBuddy
{
    int count;
    void crossSolve(String word,ArrayList[][] dict,JComboBox combo1)
    {
        int i,j,len,p;
        len=word.length();

        if(len<=2)
            j=0;
        else if(len==3)
            j=1;
        else if(len==4)
            j=2;
        else if(len==5)
            j=3;
        else if(len==6)
            j=4;
        else if(len==7)
            j=5;
        else if(len==8)
            j=6;
        else if(len==9)
            j=7;
        else if(len==10)
            j=8;
        else if(len==11)
            j=9;
        else if(len==12)
            j=10;
        else if(len==13)
            j=11;
        else if(len==14)
            j=12;
        else if(len==15)
            j=13;
        else
            j=14;
        if(word.charAt(0)!='?')
        {
            i=word.charAt(0)-'a';
            for(p=0;p<dict[i][j].size();p++)
            {
                String temp = new String();
                int flag=0;
                temp = dict[i][j].get(p).toString();
                if(temp.length()==word.length())
                {
                    for(int q=0;q<word.length();q++)
                    {
                        if(word.charAt(q)!='?')
                        {
                            if(temp.charAt(q)!=word.charAt(q))
                            {
                                flag=1;
                            }
                        }
                    }
                }
                if(flag==0)
                {
                    combo1.addItem(temp);
                    count++;
                }
            }
        }
        else
        {
            for(i=0;i<26;i++)
            {
                for(p=0;p<dict[i][j].size();p++)
                {
                    String temp = new String();
                    int flag=0;
                    temp = dict[i][j].get(p).toString();
                    if(temp.length()==word.length())
                    {
                        for(int q=0;q<word.length();q++)
                        {
                            if(word.charAt(q)!='?')
                            {
                                if(temp.charAt(q)!=word.charAt(q))
                                {
                                    flag=1;
                                }
                            }
                        }
                    }
                    if(flag==0)
                    {
                        combo1.addItem(temp);
                        count++;
                    }
                }
            }
        }
    }
}
    