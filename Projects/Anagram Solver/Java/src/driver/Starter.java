package driver;
import java.io.*;
import java.util.*;

class Starter
{
    void createDictionary(ArrayList[][] lister)throws IOException
    {
        InputStream is = getClass().getResourceAsStream("dictionary.txt");
        BufferedReader in = new BufferedReader(new InputStreamReader(is)); 
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
                    if(temp.length()<=2)
                        lister[i][0].add(temp);
                    else if(temp.length()==3)
                        lister[i][1].add(temp);
                    else if(temp.length()==4)
                        lister[i][2].add(temp);
                    else if(temp.length()==5)
                        lister[i][3].add(temp);
                    else if(temp.length()==6)
                        lister[i][4].add(temp);
                    else if(temp.length()==7)
                        lister[i][5].add(temp);
                    else if(temp.length()==8)
                        lister[i][6].add(temp);
                    else if(temp.length()==9)
                        lister[i][7].add(temp);
                    else if(temp.length()==10)
                        lister[i][8].add(temp);
                    else if(temp.length()==11)
                        lister[i][9].add(temp);
                    else if(temp.length()==12)
                        lister[i][10].add(temp);
                    else if(temp.length()==13)
                        lister[i][11].add(temp);
                    else if(temp.length()==14)
                        lister[i][12].add(temp);
                    else if(temp.length()==15)
                        lister[i][13].add(temp);
                    else
                        lister[i][14].add(temp);
                    break;
                }
                else
                    i++;
            }
        }   
    }
    Structure createStructure(String temp)
    {
        int i,j;
        Structure node = new Structure();
        node.word = temp;
        i=0;
        while(i<temp.length())
        {
            if(!(node.alpha.contains(temp.charAt(i))))
            {
                node.alpha.add(temp.charAt(i));
            }
            i++;
        }

        for(i=0;i<node.alpha.size();i++)
        { 
            int counter = 0;
            j=0;
            while(j<temp.length())
            {
                if(temp.charAt(j)==node.alpha.get(i))
                    counter++;
                j++;
            }
            node.number.add(i,counter);
        }
        return(node);
    }
    void initialize(ArrayList[][] list1)
    {
        for(int i=0;i<26;i++)
        {
            for(int j=0;j<15;j++)
            {
                list1[i][j] = new ArrayList();
            }
        }
    }
}
