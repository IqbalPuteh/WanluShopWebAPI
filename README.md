#Repository WanluShopWebAPI

Deskripsi Pendek
Repository ini berisi proyek applikasi Ibu Wan Lu Outlet - ini adalah Repository untuk "Tugas Tehnika Test Senor .NET" dari PT. Simply Dots

#Tehnical Documentation

- Pengembangan applikasi mengunakan Visual Studio 2022 dengan mengunakan framework .NET v 6
- Applikasi ini mengunakan database MS-SQL version 15.
- Connection String untuk arah koneksi Database "WanluClothDB.mdf telah di hardcode di dalam applikasi.
  pada applikasi ini alamat/lokasi telah di setting dengan format sbb: "Lokasi(folder) Repository/WanluShopWebAPI/DB".
  
- WebAPI dapat di akses dengan menjalankan applikasi ini dengan mengeksekusi Build Command yang di arahkan ke IIS Express pada local komputer, seperti gambar di bawah ini

  <img width="716" alt="image" src="https://user-images.githubusercontent.com/99324365/164274744-321da8e7-f9ab-43ad-a5c5-10e7e27b3f94.png">
  
 - Untuk mengakses WebAPI yang ada maka browser harus mengarah ke address berikut ini http://localhost:14388/swagger/index.html (hal ini otomatis terjadi jika melakukan perintah diatas)
 - Terdapat 6 WebAPI dengan method GET (gambar terlampir), sesuai dengan urutan task yang di tertera dalam dokumen "Tehnikal Test Senior .NET"
   
   <img width="746" alt="image" src="https://user-images.githubusercontent.com/99324365/164276033-c8986e56-2a1e-445d-8d31-525c5b327ece.png">
   
  - Untuk WebAPI GET Method nomer 01-GetPriceMinMax dan 06-Top5MonthlySalesItem, tidak memerlukan passing parameter 
  - Untuk WebAPI GET Method nomer 02-GetCustomerFirstLast memerlukan passing parameter string "Nama Kota/City" yang di inginkan.
  - Untuk WebAPI GET Method nomer 03-GetMonthlyTopTenItemSale memerlukan passing parameter string "Nama Kota/City", "Bulan/Month" dan "Tahun/Year" yang di inginkan.
  - Untuk WebAPI GET Method nomer 04-GetMonthlyTopTenItemSale memerlukan passing parameter string "Nama Kota/City", "Bulan/Month" dan "Tahun/Year" yang di inginkan.
  - Untuk WebAPI GET Method nomer 05-GetYearlyTran memerlukan passing parameter string "Nama Kota/City" dan "Tahun/Year" yang di inginkan.
  - Sedikit penjelasan untuk GET Method 06-Top5MonthlySalesItem, Data yang dikeluarkan adalah data perbandingan bulan ini/sekarang dan bulan sebelumnya saja. 
    Fungsi ini tidak dapat membandingkan history bulan bulan sebelumnya.
   
   

   
   
