package driver;
import java.io.*;
import java.util.*;
import javax.swing.JComboBox;

class WordFinder
{
    int count;
    void finder(Structure InputWord,ArrayList[][] dict,JComboBox combo1,int[] len)
    {
        int i,j,a,b,ind,flag;
        count=0;
        Starter first = new Starter();
        for(a=0;a<26;a++)
        {
            for(b=0;b<8;b++)
            {
                for(i=0;i<dict[a][b].size();i++)
                {
                    int pass=0;
                    String temp1 = new String();
                    temp1=dict[a][b].get(i).toString();
                    if(temp1.length()==2)
                    {
                        if(len[0]==1)
                            pass=1;
                    }
                    else if(temp1.length()==3)
                    {
                        if(len[1]==1)
                            pass=1;
                    }
                    else if(temp1.length()==4)
                    {
                        if(len[2]==1)
                            pass=1;
                    }
                    else if(temp1.length()==5)
                    {
                        if(len[3]==1)
                            pass=1;
                    }
                    else if(temp1.length()==6)
                    {
                        if(len[4]==1)
                            pass=1;
                    }
                    else if(temp1.length()==7)
                    {
                        if(len[5]==1)
                            pass=1;
                    }
                    else if(temp1.length()>7)
                    {
                        if(len[6]==1)
                            pass=1;
                    }
                    if(pass==1)
                    {
                        Structure temp = new Structure();
                        temp = first.createStructure(temp1);
                        flag=0;
                        for(j=0;j<temp.alpha.size();j++)
                        {   
                            ind=InputWord.alpha.indexOf(temp.alpha.get(j));
                            if(ind!=-1)
                            {
                                if(((Integer)(temp.number.get(j))>((Integer)(InputWord.number.get(ind)))))
                                {
                                    flag=1;
                                }
                            }
                            else
                            {
                                flag=1;
                                break;
                            }
                        }
                        if(flag==0)
                        {
                            combo1.addItem(temp.word);
                            count++;
                        }
                    }
                }
           }
        }
    }
}
