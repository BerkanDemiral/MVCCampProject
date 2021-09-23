# MVCCampProject
### Proje Tanımı 1
<hr>
Bu proje kapsamında SOLID prensiplerine ve kurumsal mimari sistemine dikkat ederek bir MVC Projesi geliştirdim. 

### Proje Tanımı 2
<hr>

Proje genel olarak ekşi sözlük kalıplarında oluşturulan ama daha yenilikçi bir tasarım ile oluşturulmuş bir sözlük projesidir. Sisteme giriş yapabilen <b> yazarlar </b> ve <b>adminler</b> bulunnmaktadır. Her yazar belirli bir kategori altında istedikleri konu hakkında başlık oluşturabilmekte, diğer yazarlar ve admin ise bu başlıklar altına <b>yazılar (content) </b> oluşturabilmektedir.

Sisteme authentication şartı bulunmayan ve herkesin görebileceği bir anasayfa, kullanıcı ve admin için login sayfaları, kullanıcı için register sayfası, yazarlar için oluşturulan panel ve admin için oluşturulan panel olmak üzere temel olarak 6 panel üzerine kurgulanmış bir sistem bulunmaktadır. 

### Login Sayfaları 
<hr>
![admin](https://user-images.githubusercontent.com/54038172/134563693-0b8f9c51-2ced-4b86-bcba-8a1ba82eabe0.PNG)


* Admin ve Writer login sayfalarında eğer kullancıı yanlış bir kullanıcı adı ve şifre girerse bunun uyarısını veren alert yapısı bulunmakta. Bu yapı daha sonrasında Jquery Ajax destekli olarak TOASTR kullanılacaktır! 

![writerLogin](https://user-images.githubusercontent.com/54038172/134557203-8ba94141-1d58-485e-80f4-5db9e23cba8b.PNG)

![session](https://user-images.githubusercontent.com/54038172/134557229-1d10b0b7-7fe0-473e-940a-e85307579e21.PNG)
* Login Controller kısmında ise giriş yapan kullanıcının bilgilerinin alınmasını sağlayan Session yapısı kullandım. Bu sayede admin paneline ve yazar paneline yönlendirilen kullanıcılar kendilerine ait kısımların görüntülenmesini sağlayacak.

### Yazar ve Admin Panellerine özel Bazı Ekran Görüntüleri
<hr>

* Mesaj sayfası hem yazar hem admmin için neredeyse aynı işlemekte. Girişte alınan Session bilgilerine göre yazarlar ve admin arasında mesajlaşma yapılmasına olanak sağyalan bir message yapısı bulunmaktadır. Burada kullanıcılar kendilerine gelen mesajları ve gönderdikleri mesajları görebilmekte ve yeni mesajlar yazabilmektedirler. 
![messageAdmin](https://user-images.githubusercontent.com/54038172/134557810-706e83fc-2fec-4cc0-95f5-8f8c90daa75d.PNG)

![newMessage](https://user-images.githubusercontent.com/54038172/134558424-e111f95b-655a-4311-9957-d5413b8b21a5.PNG)

![mesajdetay](https://user-images.githubusercontent.com/54038172/134558886-5fd0c80c-3855-4a81-96ed-57d1c1fe118f.PNG)

### Yazarlar ve Onların Açtıkları Başlıklar
<hr>

* Burası admin paneli içerisindeki yazarlar sayfası. Burada yazarların fotoğraflarını, açtıkları başlıkları görebiliyor ve profillerini düzenleyebiliyoruz.
![writers](https://user-images.githubusercontent.com/54038172/134563018-a44f1bea-16eb-483b-9211-e482ec25268e.PNG)

* Burası ise tüm başşlıklar, hangi yazar açtı gibi özelliklerin görüntülendiği Heading sayfası
![headings](https://user-images.githubusercontent.com/54038172/134563340-b0d65e4f-aba0-467d-b539-feb1605a45b5.PNG)
* Eğer yazar girişi yaarsak yine bu tasarıma benzer bir tasarım ile açılan başlıkları görecek ama session ile o yazara ait girişi aldığımız için sadece yazarın açtığı başlıkları görüntüleyebilmekteyiz. 


