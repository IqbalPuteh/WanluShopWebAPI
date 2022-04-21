#Repository WanluShopWebAPI

Deskripsi Pendek :

Repository ini berisi proyek applikasi Ibu Wan Lu Outlet - yang merupakan hasil dari pengerjaan test teknis dari PT. Simply Dots untuk posisi Senior Teknikal .NET

#Project Tehnical Documentation

- Pengembangan applikasi mengunakan Visual Studio 2022 dengan mengunakan framework .NET v 6
- Applikasi ini mengunakan database MS-SQL version 15.
- Connection String untuk arah koneksi Database "WanluClothDB.mdf" telah di hardcode di dalam applikasi.
  Pada applikasi ini alamat/lokasi telah di setting dengan format sbb: "Lokasi(folder) Repository/WanluShopWebAPI/DB".
  Database yang di gunakan beserta data samplenya juga di sertakan di repository ini.
- WebAPI dapat di akses dengan menjalankan applikasi ini dengan mengeksekusi Build Command yang di arahkan ke IIS Express pada local komputer, seperti gambar di bawah ini

  <img width="716" alt="image" src="https://user-images.githubusercontent.com/99324365/164274744-321da8e7-f9ab-43ad-a5c5-10e7e27b3f94.png">
  
 - Untuk mengakses WebAPI yang ada maka browser harus mengarah ke address berikut ini http://localhost:14388/swagger/index.html (hal ini otomatis terjadi jika melakukan perintah diatas)
 - Di dalam WanluShopWebAPI terdapat 6 Method GET (gambar terlampir) yang dapat di gunakan.
   
   <img width="746" alt="image" src="https://user-images.githubusercontent.com/99324365/164276033-c8986e56-2a1e-445d-8d31-525c5b327ece.png">
   
  - Untuk WebAPI GET Method nomer 01-GetPriceMinMax tidak memerlukan passing parameter 
    Get Method WebAPI ini akan menghasilkan data dari pakaian dengan harga paling tinggi dan paling murah.
    
  - Untuk WebAPI GET Method nomer 02-GetCustomerFirstLast memerlukan passing parameter {tipe string} "Nama Kota/City" untuk cabang yang di inginkan.
    Get Method WebAPI ini akan menghasilkan data pelanggan yang pertama kali mendaftar (pelanggan terlama) dan pelanggan yang terakhir kali mendaftar (pelanggan terbaru) berdasarkan cabang.
    
  - Untuk WebAPI GET Method nomer 03-GetMonthlyTopTenItemSale memerlukan passing parameter {tipe string} "Nama Kota/City" untuk cabang, "Month" untuk bulan dan "Year" tahun yang di inginkan.
    Get Method WebAPI ini akan menghasilkan data dari 10 data pakaian yang paling banyak dibeli dalam 1 bulan di setiap cabang (berdasarkan quantitynya).
    
  - Untuk WebAPI GET Method nomer 04-GetTop10MonthlyCusts memerlukan passing parameter {tipe string} "Nama Kota/City" untuk cabang, "Month" untuk bulan dan "Year" tahun yang di inginkan.
    Get Method WebAPI ini akan menghasilkan data dari 10 data pelanggan yang paling besar belanjanya dalam 1 bulan di setiap cabang (berdasarkan akumulasi total belanja pelanggan tsb).
  
  - Untuk WebAPI GET Method nomer 05-GetYearlyTran memerlukan passing parameter {tipe string} "Nama Kota/City" untuk cabang dan "Year" tahun yang di inginkan.
    Get Method WebAPI ini akan menghasilkan data dari data total penjualan setiap cabang dalam 1 tahun.
    
  - Untuk WebAPI GET Method nomer 06-Top5MonthlySalesItem, tidak memerlukan passing parameter. 
    Get Method WebAPI ini akan menghasilkan data dari 5 data pakaian yang mengalami peningkatan tertinggi penjualan dalam bulan ini dibandingkan bulan sebelumnya.
    Perlu untuk di ketahui bahwa keterbatasan dari fungsi ini tidak dapat membandingkan history bulan bulan sebelumnya.


                                                               === EoF ===
   
   

   
   
