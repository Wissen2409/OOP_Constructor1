
// eğer siz bir default ctor yazmazsanız derleyici sizin yerinize bir ctor yazar.

// Soru : peki şuanda neden hata alıyoruz ?

//Biz parametreli bir ctor yazsak bile, derleyici default ctor yazmayı bırakır
// bu durumda nesneyi illaki yazmış olduğumuz parametreli ctor üzerinden üretmeliyiz
Product p = new Product(1,"Telefon",100);

