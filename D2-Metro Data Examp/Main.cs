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
		private int sizePaper=60;
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
		
		Table tb=new Table();
		
		//Contoh inherithance untuk mengganti lebar Layout Table
		tb.Width(60);
			//tb.setBodyElement("x");
		int menulenth = -1 + menu.Length;
		Console.WriteLine(" Note:  Press Key  Number Pad  0 - "+menulenth+"  Button to Change Menu ");
		tb.field(appTitle);
		int n=0;
	}
}
public class Layout{
	//Overriding Example on a method
	public 	int x=60;
	public String DefaultBodySpace=" ";
	public Layout(){
		//constructor;
	}
	public Layout(int v){
		x=v;
	}
	public void Width(int v){
		x=v;
	}
	public void setBodyElement(String x){
		DefaultBodySpace=x;
	}
	public  String MarginSpace(){
		String space="| ";
		  for(int i=0;i<x;i++){
		  	 space+=DefaultBodySpace;
		  }
		 space+=" |";
		return space;
	}
		public  String MarginSpace(String margin,String bdy){
			//int x=getLayoutSize();
		
			int y=bdy.Length;
		String space="| ";
			int z=0;
		  for(int i=0;i<x;i++){
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
public class Table:Layout{
	public Table(){
	//consructor
	}	
	public void field(String body){
		Console.WriteLine(MarginSpace("=",""));
		Console.WriteLine(MarginSpace());
		Console.WriteLine(MarginSpace(" ",body));
		Console.WriteLine(MarginSpace());
		Console.WriteLine(MarginSpace("=",""));
	}
}
	
	
	