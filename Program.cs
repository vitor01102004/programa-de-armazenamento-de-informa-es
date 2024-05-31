//ESSE PROGRAMA VAI ARMAZENAR IMPUTS DO USUSARIO E EXECUTAR EKES 2 VEZES, VAI ME MOSTRAR O RESULTADO NO CONSOLE,E TAMBEM VAI ARMAZENAR EM UM ARQUIVO .TEXT 
using System;
using System.IO;
class Minprojeto{
     private static void Main(){
        string path= @"C:\Users\vitor\Desktop\salvar.txt.txt";
        string acao = "";// aq a variavel acao vai receber oq o teclado receber do ususario(tudo isso podendo ser atribuido dps, pois chamei uma string vazia)
        string nome="", cpf="", email="", telefone="";

        Console.WriteLine("*****************************************");
        Console.WriteLine("*****************************************");
        Console.WriteLine("pressione o G - para gravar");
        Console.WriteLine("digite o L - para Ler");
        Console.WriteLine("digiter S - para sair");
        Console.WriteLine("*****************************************");
        Console.WriteLine("*****************************************");
        acao=Console.ReadLine().ToUpper();//aq acao esta armazenando a informacao do usuario

        while (acao!="S"){
            

            if (acao=="G"){ //todos os valores  serao guardados rm cada variavel em sua ordem
              Console.WriteLine("digite seu nome:");
              nome=Console.ReadLine();
              Console.WriteLine("digite seu cpf");
              cpf=Console.ReadLine();
              Console.WriteLine("digite seu email");
              email=Console.ReadLine();
              Console.WriteLine("digite seu telefone");
              telefone=Console.ReadLine();
              Console.WriteLine("----------------------------------------------------------------------------");


            StreamWriter sw=new StreamWriter(path,true);//o segundo parametro serve para se eu quiser que ele mantenha o arquivo ou apague ele de vez, no caso, eu mantive o arquivo
            sw.WriteLine("nome:"  +nome);
            sw.WriteLine("cpf:"  +cpf);
            sw.WriteLine("email:"  +email);
            sw.WriteLine("telefone:"  +telefone);
            
            sw.Close();//dps que salvar, tem que fechar o arquivo, pq se estiver aberto, n posso mudar ele, ja que o mesmo se encontra em uso.
              
            }
            else if (acao=="L"){
                
                StreamReader sr=new StreamReader(path);//usei uma nova propriedade, uma nova funcionalidade da linguagem
                while(sr.EndOfStream != true){// o endofstream quer dizer o fim do laco, ou seja, quando chegar ao fim do laco, faca isso.
                    Console.WriteLine(sr.ReadLine());//a logida do sr.readline, quer dizer que quando o valor do laco for armazenado no objeto sr, o consolevai escrever a leitura das informacoes 
                }
                sr.Close();//para fechar o meu streamreader. esse vai ler oq foi salvo no meu caminho, ou seja, tudo que seja salvo no arquivo
            }
           



            Console.WriteLine();
            Console.WriteLine("TOQUE EM QUALQUER TECLA PARA LIMPAR O CONSOLE.");
            //Console.ReadKey();
            //vai limpar o console para poder comecar tudo de novo.
            
            
{       Console.Clear();
        Console.WriteLine("*****************************************");
        Console.WriteLine("*****************************************");
        Console.WriteLine("pressione o G - para Gravar");
        Console.WriteLine("digite o L - para Ler");
        Console.WriteLine("digiter S - para Sair");
        Console.WriteLine("*****************************************");
        Console.WriteLine("*****************************************");
        acao=Console.ReadLine().ToUpper();
   
        
    }
}  
}
 }
    
    
    
     //else if (acao.ToUpper()=="L"){
                //Console.WriteLine(nome);
               // Console.WriteLine(cpf);
               // Console.WriteLine(email);
               // Console.WriteLine(telefone);
           // }
