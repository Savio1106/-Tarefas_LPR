using System;
// Declaração da Struct
public struct Produto {
 public string Nome;
 public int Codigo;
 public float Preço;
public int quantidade;
}
class andery {
 static void Main(){
 

 Produto[] mercado = new Produto[3];
 
 mercado[0] = new Produto {Nome="arroz",Codigo=1,Preço=35.50f, quantidade=10};
 mercado[1] =  new Produto {Nome="feijão",Codigo=2,Preço=15.50f, quantidade=5};
mercado[2] =  new Produto {Nome="miojo",Codigo=3,Preço=3.33f, quantidade=50};

 float total_preço_estoque = 0;
   
 foreach (Produto produto in mercado){
   total_preço_estoque += (produto.Preço * produto.quantidade);
 }
 Console.WriteLine("O valor total de produtos no estoque é : "
+ total_preço_estoque);
 }
  }