using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		//call all Objke/class
		Table tb=new Table();
		tbody tr=new tbody();
		tbodyLine tl=new tbodyLine();
		tbodySpace ts=new tbodySpace();
		//seting class table
		   tb.setAlign("center");
		   tb.setWidth(120);
		//--------end
		   tb.fieldHeader("Aplikasi Multple Input Data Sederhana ");
		//----input data karyawan
		DataKaryawan[] tb_karyawan=new DataKaryawan[10];
		bool state=true;
		int n=0;
		while(state){
			String[] textBox={"Nama", "Alamat","Nomor HP"};
			String[] getText=new String[3];
			int index=0;	
			foreach(String i in textBox){
		   		tb.setWidth(120);
				ts.setAlign("left");
				ts.field("Masukan "+i+" :");
				String getInput=Console.ReadLine();
					if(getInput=="Q"|getInput=="q"){
						state=false;
						break;
					}else{
						getText[index]=getInput;
						index++;
					}
				}
			if(state){
				tb_karyawan[n]=new DataKaryawan(getText);
			}
			
		}
	}

}

public class DataKaryawan{
	public String nama;
	public String alamat;
	public int hp;
	public DataKaryawan(){
	//constructor
		nama="noName";
		alamat="noAddress";
		hp=0;
	}
	public  DataKaryawan(String[] n){
	//constructor
		nama=n[0];
		alamat=n[1];
		hp=int.Parse(n[2]);
	}
	public String[] DisplayKaryawanAll(){
		String[] Output=new String[3];
			Output[0]=nama;
			Output[1]=alamat;
			Output[2]=hp.ToString();
		return Output;
	}
	public void setNama(String n){
		nama=n;
	}
	public String getNama(){
		return nama;
	}
	public void setAlamat(String n){
		alamat=n;
	}
	public String getAlamat(){
		return alamat;
	}
	public void setHp(int n){
		hp=n;
	}
	public int getHp(){
		return hp;
	}
}

//Table Design  - - - - - - -
public class Layout{
	//Overriding Example on a method
	private String align="center";
	public 	int x=60;
	public String DefaultBodySpace=" ";
	public Layout(){
		//constructor;
	}
	public Layout(int v){
		x=v;
	}
	public void setAlign(String x){
		align=x;
	}
	public void setWidth(int v){
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
			  //rata tengah/ center align
			  if(align=="center"||align=="CENTER"||align=="Center"){
				  if( i >= ((x-y)/2)  && i < ( (  (x-y) /2)+y)  ){
					  space+=bdy[z];
					   z++;
				  }else{
					 space+=margin;				 			  
				  }
			  }
			  //rata kiri /left align
			  else if(align=="left"||align=="LEFT"||align=="Left"){
				  if( i < y){
					  space+=bdy[z];
					   z++;
				  }else{
					 space+=margin;				 			  
				  }
			  }
			  //rata Kanan /right align
			  else{
				  if( i > (x-y)){
					  space+=bdy[z];
					   z++;
				  }else{
					 space+=margin;				 			  
				  }
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
	public void fieldHeader(String body){
		Console.WriteLine(MarginSpace("=",""));
		Console.WriteLine(MarginSpace());
		Console.WriteLine(MarginSpace(" ",body));
		Console.WriteLine(MarginSpace());
		Console.WriteLine(MarginSpace("=",""));
	}

}
public class tbody : Table{
	public tbody(){
		//constructor
	}
	public virtual void field(String body){
		Console.WriteLine(MarginSpace(" ",""));
		Console.WriteLine(MarginSpace(" ",body));
		Console.WriteLine(MarginSpace("-",""));
	}
}
public class tbodyLine : tbody{
	public tbodyLine(){
		//constructor
	}
	public override void field(String body){
		Console.WriteLine(MarginSpace(" ",""));
		Console.WriteLine(MarginSpace(" ",body));
		Console.WriteLine(MarginSpace("_",""));
	}
}
public class tbodySpace : tbody{
	public tbodySpace(){
		//constructor
	}
	public override void field(String body){
		Console.WriteLine(MarginSpace(" ",""));
		Console.WriteLine(MarginSpace(" ",body));
		Console.WriteLine(MarginSpace(" ",""));
	}
}