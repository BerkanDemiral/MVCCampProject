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
![adminLogin](https://user-images.githubusercontent.com/54038172/134556730-2e071b94-0127-41bb-a86f-1efc42e52712.png)

* Admin ve Writer login sayfalarında eğer kullancıı yanlış bir kullanıcı adı ve şifre girerse bunun uyarısını veren alert yapısı bulunmakta. Bu yapı daha sonrasında Jquery Ajax destekli olarak TOASTR kullanılacaktır! 

![writerLogin](https://user-images.githubusercontent.com/54038172/134557203-8ba94141-1d58-485e-80f4-5db9e23cba8b.PNG)

![session](https://user-images.githubusercontent.com/54038172/134557229-1d10b0b7-7fe0-473e-940a-e85307579e21.PNG)
* Login Controller kısmında ise giriş yapan kullanıcının bilgilerinin alınmasını sağlayan Session yapısı kullandım. Bu sayede admin paneline ve yazar paneline yönlendirilen kullanıcılar kendilerine ait kısımların görüntülenmesini sağlayacak.
