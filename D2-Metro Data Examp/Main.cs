using System;
using System.Collections.Generic;					
public class Program
{
	public static void Main()
	{
		MenuApp MenuApps=new MenuApp("Aplikasi Penjualan Bengkel");
		MenuApps.displayMenu();
		bool ulang=true;
		//while(ulang){
		  //MenuApp.menu=\\\;
			//ulang=menuappp();		
		//}
	}
}



//OOP Implementations
public class MenuApp{
		private static String[] menu={"Kategori","Data Barang","Penjualan","Exit"}; //saya igin membuat data ini dinamis ditambahkan disaatn Objek ini dipanggil taip tidak tau yang bagaiaman mengganti nilai array variabel  sebuah objek ketika pemanggilan objek , masih bingung
		public String appTitle;
	public MenuApp(){
		//constructor----
		appTitle="Aplikasi Penjualan";
	}
		//overriding used in constructor
	public MenuApp(String variabel){
		//constructor with params
		appTitle=variabel;
	}
	public void displayMenu(){
		bool state=true;
		int menulenth = -1 + menu.Length;
		Console.WriteLine(" Note:  Press Key  Number Pad  0 - "+menulenth+"  Button to Change Menu ");
		Console.WriteLine(MarginSpace(60,0,"=",""));
		Console.WriteLine(MarginSpace());
		//Console.WriteLine(MarginSpace(6,appTitle.Length,"=",appTitle));
		//Console.WriteLine("|      \t\t "+appTitle+" \t\t\t  \t |");
		Console.WriteLine(MarginSpace(60,appTitle.Length,"=",appTitle));

		int n=0;
	}
//Overriding Example on a method
	public static String MarginSpace(){
		String space="| ";
		  for(int i=0;i<60;i++){
		  	 space+="\t";
		  }
		 space+="|";
		return space;
	}
		public static String MarginSpace(int x,int y,String margin,String bdy){
		String space="| ";
			int z=0;
		  for(int i=0;i<x;i++){
			  
			 // Console.WriteLine( i >= ((x-y)/2)  && i < ( (  (x-y) /2)+y)  );
			  if( i >= ((x-y)/2)  && i < ( (  (x-y) /2)+y)  ){
				  space+=bdy[z];
				   z++;
				  
			  }else{
				 space+=margin;				 			  
			  }
			  
		  }
		 space+=" |";
		return space;
	}
}