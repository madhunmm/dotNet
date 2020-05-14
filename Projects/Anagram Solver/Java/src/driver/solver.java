package driver;
import java.io.*;
import javax.swing.JComboBox;
import java.io.BufferedReader;
import java.util.*;
class solver
{
    int count=0;
    void permute(StringBuffer word,StringBuffer last,int len,JComboBox combo1,ArrayList[][] list1)throws IOException
    {
        int i,j,k,ind=0;
        StringBuffer temp = new StringBuffer(len);
        StringBuffer changer = new StringBuffer(len);
        for(i=0;i<word.length();i++)
        {
            if(last.length()==len)
            {
                changer.delete(0,changer.length());
                
                for(j=0;j<(len-word.length());j++)
                {
                    changer.insert(j,last.charAt(j));
                }
                last.delete(0,last.length());
                for(k=0;k<changer.length();k++)
                {
                    last.insert(k,changer.charAt(k));
                }
            }
            k=0;
            while(k<last.length())
            {
                k++;
            }
            
            last.insert(k,word.charAt(i));
            temp.delete(0,temp.length());
            k=0;
            ind=0;
            while(k<word.length())
            {
                if(k!=i)
                {
                    temp.insert(ind,word.charAt(k));
                    ind++;
                    k++;
                }
                else
                    k++;
            }
            if(temp.length()<=0)
            {
                solver solver1 = new solver();
                if(solver1.valid(last,list1))
                {
                    if(!(solver1.present(last,combo1)))
                    {
                        combo1.addItem(last.toString());
                        count++;
                    }
                }
            }
            
            permute(temp,last,len,combo1,list1);
        }
    }
    boolean valid(StringBuffer word,ArrayList[][] lister)throws IOException
    {
        String temp = new String();
        ArrayList checker=new ArrayList();
        int i,j,ind1,ind2;
        char starter;
        starter=word.charAt(0);
        ind1=starter-'a';
        if(word.length()<=6)
            ind2=0;
        else
            ind2=1;
        checker=lister[ind1][ind2];
        for(i=0;i<checker.size();i++)
        {
            temp=checker.get(i).toString();
            if(temp.equals(word.toString()))
                return(true);
        }
        return(false);
    }
    void createDictionary(ArrayList[][] dict)throws IOException
    {
        BufferedReader in = new BufferedReader(new FileReader("dictionary.txt")); 
        String temp = new String();
        int i,j;
         
        while(temp!=null)
        {
            try
            {
                temp=in.readLine();
                if(temp ==null)
                    break;
            }
            catch(Exception EOFException)
            {
                System.out.println(EOFException);
            }
            i=0;
            while(true)
            {
                if(temp.charAt(0)==('a'+i))
                {
                    if(temp.length()<=6)
                        dict[i][0].add(temp);
                    else
                        dict[i][1].add(temp);
                    break;
                }
                else
                    i++;
            }
        }
            
    }
    void initialize(ArrayList[][] list1)
    {
        for(int i=0;i<26;i++)
        {
            for(int j=0;j<2;j++)
            {
                list1[i][j] = new ArrayList();
            }
        }
    }
    boolean present(StringBuffer word,JComboBox combo1)
    {
        for(int i=0;i<combo1.getItemCount();i++)
        {
            if(combo1.getItemAt(i).equals(word.toString()))
                return(true);
        }
        return(false);
    }
}

