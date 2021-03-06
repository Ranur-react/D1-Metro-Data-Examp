using System;
using System.Collections.Generic;					
public class Program
{
	public static void Main()
	{
		MenuApp MenuApps=new MenuApp("Aplikasi Penjualan Kasir");
		
		bool ulang=true;
		while(ulang){
		  //MenuApp.menu=\\\;
			ulang=MenuApps.displayMenu();	
		}
	}
}



//OOP Implementations
public class MenuApp{
		private static String[] menu={"Kategori","Data Barang","Penjualan","Exit"}; //saya igin membuat data ini dinamis ditambahkan disaatn Objek ini dipanggil taip tidak tau yang bagaiaman mengganti nilai array variabel  sebuah objek ketika pemanggilan objek , masih bingung
	public static List<String> DaftarKategori=new List<String>();
	public static List<String> namab= new List<String>(),kategorib= new List<String>(),satuanb= new List<String>();
	public static List<double> hargab= new List<double>();
	public static List<int> stockb= new List<int>();
	
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
		// contoh Polymorphism pemanggilan  class yang saling berelasi( ex: memanggil parent method dengan child ) 
		Table tb=new Table();
		tbody tr=new tbody();
		tbodySpace ts =new tbodySpace();
		tbodyLine tl=new tbodyLine();
		//Contoh inherithance untuk mengganti lebar Layout Table
		tb.Width(60);
			//tb.setBodyElement("x");
		int menulenth = -1 + menu.Length;
		Console.WriteLine(" Note:  Press Key  Number Pad  0 - "+menulenth+"  Button to Change Menu ");
		tb.fieldHeader(appTitle);
		tr.field(eachMenu());
		ts.field("Masukan Nomor Menu : ");
		int menuSelect=Convert.ToInt16(Console.ReadLine());
		
			switch(menuSelect){
				case 0:
					ts.field("Kamu Memilih Menu :\""+menu[menuSelect]+" ("+menuSelect+")\"");
					tl.field("");
					Kategori();
					break;
				case 1:
					ts.field("Kamu Memilih Menu :\""+menu[menuSelect]+" ("+menuSelect+")\"");
					Barang();
					break;
				case 2:
					ts.field("Kamu Memilih Menu :\""+menu[menuSelect]+" ("+menuSelect+")\"");
				//	penjualan();
					break;					
				 default:
					state=false;
					ts.field("kamu Mengakhiri Aplikasi");
					break;
			}	
		
		return state;
	}
	public static void LihatKategori(){
		int no=1;
		tbody tr=new tbody();
		tbodySpace ts =new tbodySpace();
		tbodySpace tsMall =new tbodySpace();
		tbodyLine tlMall=new tbodyLine();
		tbodyLine tl=new tbodyLine();
		tsMall.Width(20);
		tlMall.Width(20);
		tr.Width(20);
				tlMall.field("List Kategori :");
			for(int n=0;n<DaftarKategori.Count;n++){
				tsMall.field(no+". "+DaftarKategori[n]);
				no++;
			}
		tr.field("");
	}
	public static String TampilPanggilKategori(){
		String listkateg="";
			for(int n=0;n<DaftarKategori.Count;n++){
				int no=n+1;
				listkateg+= DaftarKategori[n]+"("+n+") ";
			}
		return listkateg;
	}
	public static bool Inputbarang(){
		Table tb=new Table();
		tbody tr=new tbody();
		tbodySpace ts =new tbodySpace();
		tbodyLine tl=new tbodyLine();
		
		bool state=true;
		String[] TextInput={"Nama Barang","Kategori Barang","Jumlah Stock","Satuan","Harga"};
		int index=0;
		foreach(String t in TextInput){
			if(index==1){
				ts.field("Pilih Kategori ( "+TampilPanggilKategori()+" )");
			}
			ts.field("\n -"+t+":");
			String getdata=Console.ReadLine();
			if(getdata=="Q"|getdata=="q"){
				state=false;
				break;
			}else{
				switch(index){
					case 0:
						namab.Add(getdata);
						break;
					case 1:
						
						kategorib.Add(DaftarKategori[int.Parse(getdata)]);
						break;
					case 2:
						stockb.Add(int.Parse(getdata));
						break;
					case 3:
						satuanb.Add(getdata);
						break;
					default:
						hargab.Add(double.Parse(getdata));
						break;
						}
				index++;
			}
		}		
		LihatBarang();
		return state;
	}
	public static void LihatBarang(){
		int no=1;
			Console.WriteLine("\t\tList Barang :"+namab.Count);
			for(int n=0;n<namab.Count;n++){
				Console.WriteLine("\t\t"+no+". ");
				Console.WriteLine("\t\t\t * Nama Barang         :\t"+namab[n]);
				Console.WriteLine("\t\t\t * Kategori            :\t"+kategorib[n]);
				Console.WriteLine("\t\t\t * Stock               :\t"+stockb[n]+" "+satuanb[n]);
				Console.WriteLine("\t\t\t * Harga Modal         :\t"+hargab[n]);
				double hargaJual=hargab[n]+(0.25*hargab[n]);
				Console.WriteLine("\t\t\t * Harga Jual (Up 25%) :\t"+hargaJual);
				no++;
			}
	}
	public static  void Barang(){
		Table tb=new Table();
		tbody tr=new tbody();
		tbodySpace ts =new tbodySpace();
		tbodyLine tl=new tbodyLine();
		//Contoh inherithance untuk mengganti lebar Layout Table
		tb.Width(60);
		//LihatKategori();
		bool ulang=true;
		do{
			tr.field("");
			//LihatBarang();
			tr.field("");
			tl.field("| Tambahkan Barang / Spepart |");
			ts.field("| Note: (Enter= continue , Q|q = stop ) \t\t");
			ts.field("");
				if(!Inputbarang()){
				ulang=false;
					Console.WriteLine("Stop Tambah  Barang . . !!");
			    }
		}
		while(ulang);
	}
	public static  void Kategori(){
		LihatKategori();
		bool ulang=true;
		tbodySpace ts =new tbodySpace();
		tbodyLine tl=new tbodyLine();
		do{
			ts.field("Tambahkan Kategori");
						tl.field(" ");

			tl.field("| Note: (Enter= continue , Q|q = stop ) \t\t");
			LihatKategori();
			ts.field(" Tambah Nama Kategori :");
			String getData=Console.ReadLine();
			
			if(getData == "q"||getData == "Q"){
				ulang=false;
			}else{
			DaftarKategori.Add(getData);
			}
		}
		while(ulang);
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
	
	
	