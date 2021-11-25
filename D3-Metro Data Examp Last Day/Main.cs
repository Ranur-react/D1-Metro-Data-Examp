using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		AppMenu MenuApps=new AppMenu("STMIK Jayanusa");
		bool ulang=true;
		while(ulang){
		  //MenuApp.menu=\\\;
			ulang=MenuApps.displayMenu();	
		}
	}
}
public class AppMenu{
	public String appTitle;	
	private static String[] menu={"Mahasiswa","Jurusan","Matakuliah","Nilai","Keluar"}; //saya igin membuat data ini dinamis ditambahkan disaatn Objek ini dipanggil taip tidak tau yang bagaiaman mengganti nilai array variabel  sebuah objek ketika pemanggilan objek , masih bingung
	public AppMenu(){
		appTitle="Aplikasi Input Nilai Matakuliah";
	}
	public AppMenu(String n){
		appTitle+=(" "+n);
	}
	private String eachMenu(){
		int n=0;
		String resp="";
		foreach(String x in menu){
			resp+="| "+x+"("+n+") |";
		++n;
		}
		return resp;
	} 
	public bool displayMenu(){
		bool state=true;
		//call all Objke/class
		Table tb=new Table();
		tbody tr=new tbody();
		tbodyLine tl=new tbodyLine();
		tbodySpace ts=new tbodySpace();
		//seting class table
		   tb.setAlign("center");
		   tb.setWidth(120);
		   tr.setWidth(120);
		   ts.setWidth(120);
		   tl.setWidth(120);
		//--------end
		   tb.fieldHeader(appTitle);
		int menulenth = -1 + menu.Length;
		tr.setAlign("left");
		tr.field(" Note:  Press Key  Number Pad  0 - "+menulenth+"  Button to Change Menu ");
		tr.setAlign("center");
		tr.field(eachMenu());
		ts.setAlign("left");
		ts.field("Masukan Nomor Menu : ");
		int menuSelect=Convert.ToInt16(Console.ReadLine());
		
			switch(menuSelect){
				case 0:
					ts.field("Kamu Memilih Menu :\""+menu[menuSelect]+" ("+menuSelect+")\" yang masih dalam mode Development (Interface)");
					tl.field("");
					//Interface  on the class
					Matakuliahmhs mhs=new Matakuliahmhs();
					break;
				case 1:
					ts.field("Kamu Memilih Menu :\""+menu[menuSelect]+" ("+menuSelect+")\" yang masih dalam mode Development (Abstract)");
					//example Abstract on the class
					Jurusan JR=new Jurusan();
					break;
				case 2:
					ts.field("Kamu Memilih Menu :\""+menu[menuSelect]+" ("+menuSelect+")\"");
				//	Input Matakuliah class;
					Matakuliah mtk =new Matakuliah();
					break;		
				case 3:
					ts.field("Kamu Memilih Menu :\""+menu[menuSelect]+" ("+menuSelect+")\"");
				//	Input Nilai class;
					break;	
				 default:
					state=false;
					ts.field("kamu Mengakhiri Aplikasi");
					break;
			}	
		return state;
	}
}

//pemanfaat Abstarct pada Menu Data Jurusan
abstract public class Fakultas{
		public abstract void setFakultas();
}
public class Jurusan:Fakultas{
	public override void setFakultas(){
		Console.WriteLine("---(abstract)Jurusan dan Mahasiswa dibuat oleh Developer lainnya ---");
	}
}
//pemanfaat Interface pada Menu Data Mahasiswa
 interface  Mahasiswa{
		 void setMahasiswa();
}
class Matakuliahmhs : Mahasiswa{
	public void setMahasiswa(){
		Console.WriteLine("---(interface) Jurusan dan Mahasiswa dibuat oleh Developer lainnya ---");
	}
}
//pemanfaatna 

public class Matakuliah{
	public Matakuliah(){
	//constructor
		formInput();
	}
	public void formInput(){
		bool state=true;
		//call all Objke/class
		Table tb=new Table();
		tbody tr=new tbody();
		tbodyLine tl=new tbodyLine();
		tbodySpace ts=new tbodySpace();
		//seting class table
		   tb.setAlign("center");
		   tb.setWidth(120);
		   tr.setWidth(120);
		   ts.setWidth(120);
		   tl.setWidth(120);
		//--------end
		 tb.fieldHeader("Form Input Matakuliah");
		tr.setAlign("left");
		tr.field(" Note:  Press Key Q/q for Exit this Menu ,\"(10 max input data) \" ");
		//Show data Matakuliah before input
		DataMatakuliah[] Mtk=new DataMatakuliah[10];
		int n=0;
				while(state){
					String[] textBox={"Kode Matakuliah", "Nama Matakuliah","Jumlah SKS"};
					String[] getText=new String[3];
					int index=0;	
					foreach(String i in textBox){
						ts.setAlign("left");
						ts.setWidth(120);
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
						Mtk[n]=new DataMatakuliah(getText);
						tb.setAlign("center");
					tr.setWidth(60);
					tl.setWidth(60);
					//--------end
						tr.field("Daftar Matakuliah");
						tl.field(Mtk[n].getKode());
					}
					//ShowMatakuliah();
					

				}
			}
	public void ShowMatakuliah(){
		Table tb=new Table();
		tbody tr=new tbody();
		tbodyLine tl=new tbodyLine();
		tbodySpace ts=new tbodySpace();
		//seting class table
		   tb.setWidth(120);
		   ts.setWidth(60);

	       tb.setAlign("center");
		   tr.setWidth(60);
		   tl.setWidth(60);
		//--------end
		DataMatakuliah[] DM =new DataMatakuliah[10];
			
			tr.field("Daftar Matakuliah");
			tl.field(DM[0].getKode());
	}
}



//objek menyimpan matakuliah
public class DataMatakuliah:Matakuliah{
	public String kode;
	public String nama;
	public int sks;
	public DataMatakuliah(){
	//constructor
		kode="noName";
		nama="noAddress";
		sks=0;
	}
	public  DataMatakuliah(String[] n){
	//constructor
		kode=n[0];
		nama=n[1];
		sks=int.Parse(n[2]);
	}
	public String[] DisplayMatakuliahAll(){
		String[] Output=new String[3];
			Output[0]=kode;
			Output[1]=nama;
			Output[2]=sks.ToString();
		return Output;
	}
	public void setKode(String n){
		kode=n;
	}
	public String getKode(){
		return kode;
	}
	public void setNama(String n){
		nama=n;
	}
	public String getNama(){
		return nama;
	}
	public void setSks(int n){
		sks=n;
	}
	public int getSks(){
		return sks;
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