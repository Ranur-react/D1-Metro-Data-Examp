```
//Tugas:
 // Membuat Aplikasi Hitung sederhana yang ada menu dengan Swistch Case, panggil method, dan menampilkan menu kayak nmor 1. Menu1, 2. menu2;
  //Tema bebas namun membahas semua yang menyangkup yang kita pelajari hari ini.

using System;
using System.Collections;
using System.Collections.Generic;
public class Program
{
	public static List<String> DaftarKategori=new List<String>();
	public static int jumlahdatabarang=0;
	public static List<String> namab= new List<String>(),kategorib= new List<String>(),satuanb= new List<String>();
	public static List<double> hargab= new List<double>();
	public static List<int> stockb= new List<int>();

	public static List<int> nomorbeli= new List<int>();
	public static List<int> jumlahbeli= new List<int>();
	public static List<double> jumlahbayar= new List<double>();

	//public static String[] DaftarBarang=new String[10],new String[5];
	//public static List<List<String>> DaftarBarang= new List<List<String>>();
	public static String[] menu={"Kategori","Data Barang","Penjualan","Exit"};
	public static String MarginSpace(int x,String bdy){
		String space="| ";
		  for(int i=0;i<x;i++){
		  	 space+=bdy;
		  }
		 space+="|";
		return space;
	}
	public static void LihatKategori(){
		int no=1;
				//Console.WriteLine(DaftarKategori.Count > 0 ? "" : MarginSpace(60,"-"));
				Console.WriteLine("\t\tList Kategori :");
			for(int n=0;n<DaftarKategori.Count;n++){
				Console.WriteLine("\t\t"+no+". "+DaftarKategori[n]);
				no++;
			}
				//Console.WriteLine(DaftarKategori.Count > 0 ? "" : MarginSpace(60,"-"));
	}
		public static String TampilPanggilKategori(){
		String listkateg="";
			for(int n=0;n<DaftarKategori.Count;n++){
				int no=n+1;
				listkateg+= DaftarKategori[n]+"("+n+") ";
			}
		return listkateg;
	}

	public static  void Kategori(){
		LihatKategori();
		bool ulang=true;
		do{
			Console.WriteLine(MarginSpace(60,"-"));
			Console.WriteLine("| \t\t\tTambahkan Kategori \t\t |");
			Console.WriteLine("| Note: (Enter= continue , Q|q = stop ) \t\t");
			Console.WriteLine(MarginSpace(60,"-"));
			LihatKategori();
			Console.WriteLine("");
			Console.WriteLine(" Tambah Nama Kategori :");
			String getData=Console.ReadLine();

			if(getData == "q"||getData == "Q"){
				ulang=false;
			}else{
			DaftarKategori.Add(getData);
			}
		}
		while(ulang);
	}
	public static bool Inputbarang(){
		//List<String> tb_barang=new List<String>();
		bool state=true;
		String[] TextInput={"Nama Barang","Kategori Barang","Jumlah Stock","Satuan","Harga"};
		int index=0;
		foreach(String t in TextInput){
			if(index==1){
				Console.WriteLine("Pilih Kategori ( "+TampilPanggilKategori()+" )");
			}
			Console.Write("\n -"+t+":");
			String getdata=Console.ReadLine();
			if(getdata=="Q"|getdata=="q"){
				state=false;
				break;
			}else{
				switch(index){
					case 0:
						//Console.WriteLine("-"+t+" Ditambahkan");
						namab.Add(getdata);
						break;
					case 1:

						kategorib.Add(DaftarKategori[int.Parse(getdata)]);
						break;
					case 2:
						//Console.WriteLine("-"+t+" Ditambahkan");
						stockb.Add(int.Parse(getdata));
						break;
					case 3:
						//Console.WriteLine("-"+t+" Ditambahkan");
						satuanb.Add(getdata);
						break;
					default:
						//Console.WriteLine("-"+t+" Ditambahkan");
						hargab.Add(double.Parse(getdata));
						break;
						}
				index++;
			}
		}
		//LihatBarang();
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
		//LihatKategori();
		bool ulang=true;
		do{
			Console.WriteLine(MarginSpace(60,"-"));
			LihatBarang();
			Console.WriteLine(MarginSpace(60,"-"));
			Console.WriteLine("| \t\t\tTambahkan Barang / Spepart \t\t |");
			Console.WriteLine("| Note: (Enter= continue , Q|q = stop ) \t\t");
			Console.WriteLine(MarginSpace(60,"-"));
			Console.WriteLine("");
			//Console.WriteLine("  - - - Result Tambah  Barang  - - -");
			//Console.WriteLine("  - - - "+Inputbarang().Count+"  - - -");


			//LihatBarang();
			//Inputbarang();
			//Console.WriteLine("  - - - Tambah  Barang  - - -");
				if(!Inputbarang()){
				ulang=false;
					Console.WriteLine("Stop Tambah  Barang . . !!");
			    }
				//DaftarBarang.Add(Inputbarang());

		}
		while(ulang);
	}
	public static void pilihbarangbeli(){
			bool state=true;
		String[] inputJual={" Kode (Nomor) Barang","Jumlah Beli"};
			Console.WriteLine("| Note: (Enter= continue , Q|q = stop ) \t\t");
			Console.WriteLine(MarginSpace(60,"-"));
			int no=1;
			do{
				foreach(String x in inputJual){
					Console.WriteLine("| \t\t Masukan "+x+": \t\t\t |");
					String getdata=Console.ReadLine();
					if(getdata=="Q"||getdata=="q"){
						state=false;
						break;
					}
					switch(no){
						case 1:
							nomorbeli.Add(int.Parse(getdata));
							break;
						default:
							jumlahbeli.Add(int.Parse(getdata));
							break;
					}
				}
						}
		while(state);
			if(!state){
					Console.WriteLine("| \t\t Detail belanja: \t\t\t |");
					int nox=1;
					double totalbelanja=0;
					for(int h=0;h<nomorbeli.Count;h++){
						Console.WriteLine("| \t\t Detail belanja: \t\t\t |");
						Console.WriteLine("| \t\t ["+nox+"]. "+namab[h-1]+", "+hargab[h-1]+"X "+jumlahbeli[h]+"  \t\t\t |");
						double jumlah=hargab[h-1]*jumlahbeli[h];
						Console.WriteLine("| \t\t Jumlah: Rp."+jumlah+"   \t\t\t |");
							nox++;
						totalbelanja+=jumlah;
					}
					Console.WriteLine("| \t\t Total Belanja: Rp."+totalbelanja+" \t\t\t |");
					Console.WriteLine("| \t\t Jumalh Bayar: \t\t\t |");
			    	double jbayar=double.Parse(Console.ReadLine());
					double kembalian=jbayar-totalbelanja;
					Console.WriteLine("| \t\t Kembalian: Rp. "+kembalian+"\t\t\t |");

				}


	}
	public static void penjualan(){
			Console.WriteLine(MarginSpace(60,"-"));
			LihatBarang();
			Console.WriteLine(MarginSpace(60,"-"));
			Console.WriteLine("| \t\t Penjualan Spepart Bengkel \t\t\t |");
			pilihbarangbeli();
	}
	public static bool menuappp(){
		bool state=true;
		int menulenth = -1 + menu.Length;
		Console.WriteLine(" Note:  Press Key  Number Pad  0 - "+menulenth+"  Button to Change Menu ");
		Console.WriteLine(MarginSpace(60,"="));
		Console.WriteLine(MarginSpace(15,"\t"));
		Console.WriteLine("|      \t\t Aplikasi Penjualan Bengkel \t\t\t  \t |");
		Console.WriteLine(MarginSpace(60,"="));
		int n=0;
		foreach(String x in menu){
			Console.Write("| "+x+"("+n+") ");
			++n;
		}
		Console.WriteLine();
		Console.WriteLine(MarginSpace(60,"="));
		Console.WriteLine("Masukan Nomor Menu : ");
		int menuSelect=Convert.ToInt16(Console.ReadLine());
			switch(menuSelect){
				case 0:
					Console.WriteLine("Kamu Memilih Menu :\""+menu[menuSelect]+" ("+menuSelect+")\"");
					Kategori();
					break;
				case 1:
					Console.WriteLine("Kamu Memilih Menu :\""+menu[menuSelect]+" ("+menuSelect+")\"");
					Barang();
					break;
				case 2:
					Console.WriteLine("Kamu Memilih Menu :\""+menu[menuSelect]+" ("+menuSelect+")\"");
					penjualan();
					break;
				 default:
					state=false;
					Console.WriteLine("kamu Mengakhiri Aplikasi");
					break;
			}
		return state;

	}
	public static void Main()
	{
		bool ulang=true;
		while(ulang){
			ulang=menuappp();
		}
	}
}


```
