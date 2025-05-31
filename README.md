# 🚗 Araba Üretim Konsol Uygulaması

Bu C# konsol uygulaması, kullanıcıdan araba üretimi için gerekli bilgileri alır, `Car` sınıfı nesneleri oluşturur ve listeleyerek temel bir üretim sürecini simüle eder. Kullanıcı hatalı giriş yaptığında uyarılır ve ilgili giriş tekrar istenir.

## 📌 Özellikler

- Kullanıcıdan araba üretmek isteyip istemediği sorulur.
- Araba üretmek istenirse, kullanıcıdan aşağıdaki bilgiler istenir:
  - Seri Numarası
  - Marka
  - Model
  - Renk
  - Kapı Sayısı (Geçersiz girişlerde kullanıcı tekrar yönlendirilir)
- Üretim tarihi otomatik olarak atanır (`DateTime.Now.Date`).
- Oluşturulan arabalar bir listeye eklenir.
- Kullanıcı yeni araba üretmek istemediğinde, üretilen arabaların seri numarası ve markaları listelenir.

## 🧾 Kullanılan Yapılar

- `try-catch`: Kapı sayısı girişinde oluşabilecek hataları (format veya aralık) yakalamak için kullanılmıştır.
- `goto`: Hatalı girişlerde kullanıcıyı tekrar ilgili girdi kısmına döndürmek için kullanılmıştır.
- `List<Car>`: Üretilen arabaların saklandığı liste yapısı.
- `ToLower()`: Büyük/küçük harf duyarlılığını kaldırmak için kullanılır.
