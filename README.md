Herkese merhaba!

Murat Yücedağ tarafından hazırlanan Udemy'de sunduğu "ASP.Net Core MultiShop Mikroservis E-Ticaret" projesini başarıyla tamamlamış bulunmaktayım. 

🚀 MultiShop projem, modern mikroservis mimarisine sahip, ASP.NET Core kullanılarak geliştirilen bir e-ticaret platformudur. 

🛠️ Öne Çıkan Mikroservisler ve Özellikler

🛒 Catalog Servisi: MongoDB tabanlı veri yönetimi ile ürün listeleme ve yönetim işlevlerini sağlar. AutoMapper kullanılarak veri dönüşümleri optimize edilmiştir.
🛍️ Basket Servisi: Redis ile kullanıcıların alışveriş sepetlerinin hızlı ve etkin bir şekilde yönetimi sağlanır. Redis sayesinde kullanıcı işlemleri senkronize ve verimli hale gelir.
📦 Order ve Payment Servisleri: Sipariş ve ödeme işlemlerini kapsar. Güvenlik, JWT (JSON Web Token) ile sağlanırken, hızlı veri işleme için Dapper gibi hafif bir ORM tercih edilmiştir.
📦 Cargo Servisi: MySQL kullanılarak kargo süreçlerini yönetir ve kargo verilerini depolar.
💬 Comment Servisi: PostgreSQL ile yorum işlevselliğini destekler ve kullanıcı geri bildirimlerini toplar.
🔒 Identity Server: IdentityServer4 kullanılarak OAuth2 protokolü ile kimlik doğrulama ve yetkilendirme işlevleri gerçekleştirilir.
🌐 API Gateway: Mikroservislerin iletişimini yönetir, istekleri yönlendirir ve merkezi bir erişim noktası sağlar.

Backend Teknolojileri
🧩 ASP.NET Core 6.0: Mikroservislerin temelini sağlar.
🔒 IdentityServer4 ve JWT: Güvenli kimlik doğrulama ve yetkilendirme için kullanılır.
🌀 Ocelot Gateway: Mikroservisler arası merkezi API geçidi sunar.
⚙️ RabbitMQ: Mikroservisler arası iletişimi yönetir.
💾 Dapper: Hafif ve hızlı veri erişimi sağlar.

Frontend Teknolojileri
🌐 HTML, CSS, JavaScript, Bootstrap: Kullanıcı dostu ve esnek arayüz tasarımı için kullanılır.
Altyapı ve Araçlar
🐳 Docker & Portainer: Mikroservislerin yönetimi ve dağıtımı için altyapı sağlar.
⚙️ Postman & Swagger: API testleri ve dokümantasyon oluşturma amacıyla kullanılır.
☁️ Google Cloud Storage: Medya dosyalarını güvenle depolar.

Veritabanı Teknolojileri
📂 MongoDB: Ürün bilgilerini ve katalog verilerini yönetir.
🛒 Redis: Sepet yönetiminde hızlı veri erişimi sağlar.
💬 PostgreSQL: Yorum ve kullanıcı geri bildirimlerini depolar.
📦 MySQL: Kargo ve sipariş süreçlerinin verilerini depolar.

Mimari ve Tasarım Desenleri
🏛️ Onion Architecture: Uygulamanın katmanlı yapısını destekleyerek bağımlılığı azaltır ve daha sürdürülebilir bir yapı sunar.
📋 CQRS (Command Query Responsibility Segregation) Design Pattern: Komut ve sorgu işlemlerini ayırarak daha yüksek performans ve ölçeklenebilirlik sağlar.
🗄️ Mediator Pattern: Mikroservisler arası iletişimi merkezi bir aracı ile yönetir.
🗃️ Repository Pattern: Veri erişimini yöneterek kod tekrarını azaltır ve veri işleme operasyonlarını daha düzenli hale getirir.

linkedin : https://www.linkedin.com/in/uğurkaankoç/

