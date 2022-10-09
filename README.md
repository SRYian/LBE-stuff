# LBE-stuff

## Contents
1. [Unity-Installation](#unity-installing-just-in-case--launch-unity-hub)
2. [Project-Setup](#making-the-project-2d)
3. [Scene-Creation](#first-scene)
4. [Unity-Object-Component](#objects-components-sprite-renderers-already-in-the-previous-section)
5. [Player-Movement](#making-the-players-script)
6. [Player-Movement testing](#test-the-player-script-in-this-case-involves-the-players-movement)
7. [Tilemap-Setup](#configuring-tilemap)
8. [Tilemap-Drawing](#making-the-map-using-the-walls-from-tilemap)
9. [Map-Collision](#wallcoll-scripts--finish-line-triggers)
10. [Finishing-Build](#build-to-desired-platform-pc-for-this-game)
10. [ඞ](#the-end)

## Unity Installing (just in case) + launch unity hub

Link : https://unity.com/download

Klik pilihan sesuai OS yang kalian gunakan.
![image](https://user-images.githubusercontent.com/80830860/194204319-a9e47691-bd1f-494e-8814-3121bf3740e1.png)

Setelah selesai install, buka Unity Hub.

![image](https://user-images.githubusercontent.com/80830860/194204458-1613e29c-5aff-42b0-ab5b-7e68a81424e6.png)

## making the project (2d)

Setelah Unity Hub terbuka, klik "New project"
![image](https://user-images.githubusercontent.com/80830860/194204509-b72f0ccf-1ae4-475f-8542-318de630edab.png)

Klik template apa yang ingin digunakan untuk project. Untuk project kali ini, pilihlah "2D".
![image](https://user-images.githubusercontent.com/80830860/194204707-3d107c8f-0119-4859-8ecf-d84b10556247.png)
Beri nama project sesuai yang diinginkan beserta directory-nya. Sudah semua? Klik "Create Project"!

## first scene

Selamat datang di project-mu! Silakan lihat-lihat sekitar terlebih dahulu~
![image](https://user-images.githubusercontent.com/80830860/194207690-abfdf661-2837-4284-8033-bba2cae02556.png)

Sudah? Yuk, kita buat scene pertama yang akan kita gunakan di project kali ini~

![image](https://user-images.githubusercontent.com/80830860/194207928-55ec2d05-bbd7-4da1-b316-e5b2d49b72d5.png)

Wah, ternyata Unity sudah membuatkan kita scene untuk langsung dipakai. Namun, gimana kalau misal kita mau menggunakan scene lain nantinya?

Klik kanan di window Project ~> Create ~> Scene. Selamat, scene baru telah terbuat! (Disarankan untuk membuat scene di folder Scenes yang terdapat didalam folder Assets agar file lebih rapi!)

![image](https://user-images.githubusercontent.com/80830860/194208096-57afad1e-e56a-4c4a-a50a-92937b3665ba.png)

![image](https://user-images.githubusercontent.com/80830860/194208462-576253f7-0810-4c5e-9ada-d92fb5e97627.png)

## making an object (leads to player)

Sekarang, mari kita buat suatu object yang akan menjadi player kita nantinya.
Di tab Hierarchy, klik kanan ~> Create Empty. Pilihan tersebut akan membuat suatu objek (dengan default name GameObject) yang tidak berisi apa-apa.

![image](https://user-images.githubusercontent.com/80830860/194211227-5d75139a-f40c-4ea4-8f68-a16b8af6aa6b.png)

![image](https://user-images.githubusercontent.com/80830860/194211605-5f81ca87-ed6e-4e67-af43-5d47ead0532e.png)

Waduh, objeknya terlihat transparan di tab Scene maupun Game, ya? Tidak apa-apa, ayo kita beri sesuatu di objek tersebut agar dapat terlihat di kedua tab tersebut!

Klik GameObject dari tab Hierarchy. Tab Inspector akan memberi tahu kita komponen apa saja yang telah terikat pada object tersebut.

Kemudian klik "Add Component" dan ketik "Sprite Renderer" pada tempat yang telah disediakan, dan klik Sprite Renderer.

![image](https://user-images.githubusercontent.com/80830860/194212154-48577817-7740-483b-bb7b-f5a7e5f023f7.png)

Komponen Sprite Renderer tersebut bekerja sebagaimana yang telah tertulis di namanya, untuk me-render sprite yang tersedia.

Sekarang, kembali ke tab Assets dan buatlah folder bernama "Sprites". Kemudian, masukkan suatu gambar yang ingin kalian gunakan sebagai sprite dari objek yang akan kita gunakan nantinya ke folder tersebut.

![image](https://user-images.githubusercontent.com/80830860/194212488-7b7f9115-642c-46fa-a73c-6161ee3503a7.png)

Nah, bagaimana caranya agar objek tersebut menggunakan gambar yang telah kita masukkan tadi?

Klik dan tahan gambar tersebut dan drag ke tempat "Sprite" di komponen Sprite Renderer dari objek.

![image](https://user-images.githubusercontent.com/80830860/194212757-65297856-01f5-4c8b-bd12-d33f2ce6b3a8.png)

Hore! Objek tersebut sekarang memiliki gambar yang dapat terlihat di tab Scene dan Game~

## object's components (sprite renderer's already in the previous section)

Nah, objek-nya sudah terlihat di tab Scene dan Game, kan? Sekarang, ayo kita lanjutkan dengan penambahan beberapa component ke object tersebut~

Sebelumnya, setting dulu tag object ini di tab Inspector menjadi "Player", dan setting scale X dan Y-nya menjadi 0.4~ (Z tidak perlu karena ini game 2D xixixi)

![image](https://user-images.githubusercontent.com/80830860/194721354-22ce200e-5ae0-483f-96f3-094014a3674c.png)

![image](https://user-images.githubusercontent.com/80830860/194721586-7d4bff15-877d-4bfc-994b-ac96f84d4ec9.png)

Selanjutnya, ayo kita tambahkan RigidBody2D. Langkah-nya sama seperti sebelumnya saat menambahkan Sprite Renderer yaa~

![image](https://user-images.githubusercontent.com/80830860/194721208-f66950a3-37fb-44be-9ab1-14f9211d1005.png)

Kemudian, setting Gravity Scale-nya menjadi 0 agar objek tersebut tidak jatuh (Kita kan mau buat maze, masa ga digerakin tiba-tiba jatuh sendiri? :D).

![image](https://user-images.githubusercontent.com/80830860/194721307-4cb62490-e412-4a9c-a7d5-ec5c2bba7a7b.png)

Satu lagi, object ini belum mempunyai hitbox untuk dapat menyentuh object lainnya. Oleh karena itu, kita butuh component yang bernama "Collider 2D". Collider ini tersedia dalam banyak bentuk, namun karena sprite yang sedang digunakan adalah lingkaran, maka collider yang akan digunakan adalah "Circle Collider 2D"~

![image](https://user-images.githubusercontent.com/80830860/194721453-2543338f-3603-47ca-86c8-f2725cd79671.png)

Wah, tapi kok hitbox-nya lebih besar daripada sprite yang ada? Ayo kita perbaiki dengan me-resize hitbox-nya!

![image](https://user-images.githubusercontent.com/80830860/194721464-6f7990e8-9972-4d29-8b94-ff95807c793a.png)

Klik "Edit Collider" dan akan muncul 4 titik masing-masing di atas, bawah, kiri, dan kanan lingkaran hijau. Gunakan titik tersebut untuk me-resize hitbox-nya~

Before?

![image](https://user-images.githubusercontent.com/80830860/194721507-0a44e142-e4cd-453c-b616-1e193176233c.png)

After!

![image](https://user-images.githubusercontent.com/80830860/194721627-f4fbe6a5-d00f-4652-8f41-9343766cad9b.png)

Selamat! Hitbox telah terbuat... namun circle ternyata overrated jadi ayo kita jadikan amogus :3
Gunakan apa yang telah dipelajari untuk mencapai hasil dibawah ini~

![image](https://user-images.githubusercontent.com/80830860/194741453-64dff9c5-5b72-403c-9015-caf8b449fe79.png)

## making the player's script 

Saatnya coding 💀

Bukalah tab Assets dan buatlah folder bernama "Scripts". Dalam folder scripts, buatlah folder lagi yang bernama "Movement".
Didalam folder Movement klik kanan ~> Create ~> C# Script dan namakan script PlayerMovementScript.cs.
![image](https://user-images.githubusercontent.com/92420947/194622251-7334b46e-71ab-4c41-bcc2-ca4b4ccb4f4c.png)

Kemudian, klik dua kali script tersebut untuk membukanya pada Visual Studio.
Setelah terbuka, isikan script dengan kode berikut

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Vector2 inputDirection;
    [SerializeField]private float speed=3.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        //Get component from the objects attached
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        FlipSpite();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {   
        //DeclAre variable for capturing input(unity eventsystem)
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        //Normalize input directions
        inputDirection = new Vector2(horizontal, vertical).normalized;
        //Set velocity
        rb.velocity = inputDirection * speed;
    }

    void FlipSpite()
    {
        
        Debug.Log(inputDirection.x+" "+sprite.flipX);
        if (inputDirection.x < 0)
        {
            Debug.Log("idk1");
            sprite.flipX = false;
        }
        else if (inputDirection.x > 0)
        {
            Debug.Log("idk2");
            sprite.flipX = true;
        }
    }

}

```

## test the player script (in this case involves the player's movement)

Untuk mencoba player script yang telah dibuat, klik GameObject player, kemudian klik "Add Component" dan ketik "PlayerMovementScript.cs" pada tempat yang telah disediakan, dan klik scriptnya.

![image](https://user-images.githubusercontent.com/92420947/194630433-4b880b92-5d3c-46ef-9cb7-ce1771a782ce.png)

Selamat, script telah ditambahkan dan sekarang player dapat bergerak sesuai input keyboard!

![image](https://im2.ezgif.com/tmp/ezgif-2-835e293293.gif)

## configuring tilemap

Nah, beralih ke bagian tilemap. Pada tab Hierarchy, klik kanan, select 2D Object ~> Tilemap ~> Rectangular

![image](https://user-images.githubusercontent.com/92420947/194599776-8083733e-a69f-40cd-82c4-a953f59216e2.png)

Sekarang muncul gameobject dan gridline pada scene

![image](https://user-images.githubusercontent.com/92420947/194601411-70335c6b-713c-4d7a-a21b-a9564bbe7773.png)

Selanjutnya, tilemap sudah dibuat tapi masih belum memiliki isi. Untuk mengisi tilemap, diperlukan sebuah brush yang diakses lewat Tile Palete.

Untuk membuka Tile Palette, pada menu paling atas(File, etc. ) klik Window ~> 2D ~> Tile Palette

![image](https://user-images.githubusercontent.com/92420947/194599551-94f5586a-63c2-4014-9341-c603f3f78618.png)

Setelah tile palette terbuka, klik Create New Palette dan beri nama palette yang akan dibuat. Lalu klik Create dan save Palette pada folder baru bernama Tilemaps

![image](https://user-images.githubusercontent.com/92420947/194603837-4acf9885-cf44-4e6b-9f41-09cf7a62e2b2.png)

Akhirnya sampai kepada langkah untuk membuat brush. Pada panel Project, cari asset yang bernama square. Hasil search yang tampil merupakan sprite bawaan unity yang akan digunakan untuk kebutuhan tilemap.

![image](https://user-images.githubusercontent.com/92420947/194605583-44504678-4424-46e7-ba1d-d54f602e452a.png)

Selanjutnya, drag and drop image square kedalam panel Tile Palette, save asset pada folder Tilemaps. 

Pastikan sprite square memiliki tipe collider yang tepat dengan menseleksi spritenya pada panel Projects, membuka inspector, dan mengubah collider type menjadi sprite
![image](https://user-images.githubusercontent.com/92420947/194613241-540a4016-af0b-4d6a-9202-63114b82e498.png)


YAY! Tilemap berhasil dibuat!

## making the map using the walls from tilemap

Saatnya menggambar tilemap!

Tunggu dulu! Sebelum menggambar, pastikan brush yang benar sudah terpilih.
Pada panel Tile Palette klik "Paint with active brush" (shortcut key B) untuk memilih brush yang digunakan untuk menggambar tilemap. 

![image](https://user-images.githubusercontent.com/92420947/194611455-3472d6b3-804a-48cb-9b10-485b01fbb297.png)

Jangan lupa untuk memilih tile box yang sudah ada pada Tile Palette dengan cara melakukan klik kiri. 

Setelah brush terpilih, saatnya menggambar pada scene!
Buka kembali panel Scene, dengan brush yang sudah terpilih sprite box dapat ditempatkan dimanapun dalam grid layaknya menggunakan kuas.

![image](https://user-images.githubusercontent.com/92420947/194616094-78202584-e5de-4096-9725-d904edbc9b5c.png)

Penggambaran tile inilah yang akan digunakan untuk membangun map maze.

Berikut penggambaran map yang akan digunakan untuk bagian selanjutnya tutorial ini
![image](https://user-images.githubusercontent.com/92420947/194616768-b61af141-f284-46f1-a6b9-7e2c581794a9.png)

## wallcoll scripts + finish line (triggers)

Player telah terbuat, map telah terbuat, apa ya yang kurang? Kalau dicoba, saat player menyentuh salah satu dinding, player akan menembus dinding tersebut dan tidak terjadi apa-apa.

Maka, agar lebih menantang, buatlah script WallCollider.cs agar jika player menyentuh dinding tersebut, game akan langsung berhenti dan pindah ke scene lain. Dalam kasus ini, pemain akan langsung kalah saat menyentuh dinding tersebut.

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")  
        {
            Debug.Log("wall");
            SceneManager.LoadScene("Dying Screen");
        }
    }
}
```
Debug.Log disitu hanya akan sebagai tes saat dijalankan di Unity apakah player menyentuh dinding tersebut atau tidak.

Dan juga terdapat SceneManager.LoadScene untuk me-load scene lain saat dinding tersebut disentuh oleh player.

Berikut merupakan scene dimana saat player menyentuh dinding yang tidak seharusnya disentuh, dalam kata lain Dying Screen.

![image](https://user-images.githubusercontent.com/80830860/194742057-90ea0eb0-7526-418e-8524-bd434d82d782.png)

Bagaimana cara membuatnya? Karena Scene Making telah terdapat caranya di atas tadi, yuk langsung dibuat scene-nya dan berikut merupakan cara membuat scene yang terdapat button didalamnya.

### Dying Screen and Finish Screen

Pertama, buatlah script agar button yang akan kita buat nanti dapat berfungsi.

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DyingScreen : MonoBehaviour
{
    public void RetryButton()
    {
        Debug.Log("retry");
        SceneManager.LoadScene("Playing Scene");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}
```

Di script atas, terdapat dua button yang akan kita gunakan nanti, yaitu Retry dan Exit. Untuk Retry, langsung dapat menggunakan SceneManager.LoadScene untuk dapat kembali ke Playing Screen.

Untuk Exit, dapat menggunakan Application.Quit() untuk exit dari aplikasinya. Jangan lupa gunakan Debug.Log untuk mengecek apakah button tersebut dapat digunakan atau tidak~

Sekarang, ayo kita implementasikan script yang telah dibuat tadi ke button di scene!

Gunakan UI -> Image untuk membuat button yang akan digunakan.

![image](https://user-images.githubusercontent.com/80830860/194742251-c293bb66-5920-442c-bca5-6efec288c35e.png)

Canvas akan otomatis terbuat dan sekarang, klik Canvas sekali dan masukkan script yang telah terbuat ke component Canvas tersebut.

![image](https://user-images.githubusercontent.com/80830860/194742347-3ca4d42e-9ce8-4690-a9f8-abddecbd3e62.png)

(Gambar hanya sebagai ilustrasi, silahkan kreasikan sesuka hati!)

Kemudian, klik kembali Image yang dibuat tadi, dan masukkan component Button.

![image](https://user-images.githubusercontent.com/80830860/194742371-26619019-8f88-47e9-a875-aadbe2675b5d.png)

Selanjutnya, dengan Image masih terhighlight, klik + di Inspector bagian "On Click ()" dan drag canvas ke tempat object yang tersedia.

Before?

![image](https://user-images.githubusercontent.com/80830860/194742425-c27fcbb1-bb40-48cd-a8f1-9e3ec6c4d5db.png)

After!

![image](https://user-images.githubusercontent.com/80830860/194742433-914374e5-2427-46bd-aca5-25b6a85db27a.png)

Button masih belum dapat digunakan karena kita belum melaksanakan langkah yang tidak kalah pentingnya. Klik function apa yang akan digunakan button tersebut untuk dijalankan!

![image](https://user-images.githubusercontent.com/80830860/194742478-0bd54e39-8685-415e-8590-72bf8fd2a152.png)

Sebagai langkah terakhir, masukkan Scene yang telah terbuat ke Build Settings agar dapat diakses oleh SceneManager.

![image](https://user-images.githubusercontent.com/80830860/194742630-5ce9db25-f732-4ffe-b027-bef81c81796e.png)

Dan klik "Add Open Scenes" hingga semua scene yang telah kalian buat masuk ke daftar!

![image](https://user-images.githubusercontent.com/80830860/194742691-3a55d9c7-afb5-4feb-9ce7-a6e31364615a.png)

Cobalah run di Unity~

Implementasikan yang telah dipelajari diatas untuk membuat Finish Screen sebagai "syarat menang" dari game ini!

## build to desired platform (pc for this game)

Wah, tak terasa game kita telah selesai. Tinggal kita jadikan game ini sebagai sebuah aplikasi, nih. Gimana caranya?

Masuk kembali ke Build Settings (atau Ctrl + Shift + B)

![image](https://user-images.githubusercontent.com/80830860/194742765-a48ffb12-7d69-4f2f-b8ef-5b071b69d456.png)

Klik platform yang diinginkan (untuk kesempatan kali ini, gunakan "Windows, Mac, Linux"), dan klik "Build". Select folder tempat project tersebut akan di-build.

![image](https://user-images.githubusercontent.com/80830860/194742874-92242784-d10f-4def-837a-848650668e51.png)

Sudah ter-built? Coba aplikasimu dengan menjalankan file yang bernama sama dengan project-mu tadi!

# The End
That's all folks!
![gambar](https://user-images.githubusercontent.com/92420947/194773040-361d5071-5575-43e1-ab90-bd667b024366.png)

