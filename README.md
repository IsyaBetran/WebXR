Proyek: XR Immersive Experience (AR & VR 360)
Tentu, ini adalah dokumentasi untuk repositori proyek realitas tertambah (AR) dan realitas virtual (VR) 360 yang dikembangkan menggunakan Unity. Proyek ini mengeksplorasi penggabungan elemen digital ke dunia nyata serta lingkungan imersif 360 derajat.

🚀 XR Immersive Experience: AR & VR 360
Repositori ini berisi implementasi teknologi Augmented Reality (AR) dan Virtual Reality (VR) 360 yang dibangun menggunakan Unity Engine. Proyek ini dirancang untuk memberikan pengalaman interaktif yang mulus melalui integrasi sensor dan optimasi visual.

🛠️ Fitur Utama
1. Augmented Reality (AR) Integration
Menggunakan pustaka Zappar for Unity untuk menghadirkan interaksi AR yang responsif.

Image Tracking: Mendeteksi dan melacak target gambar untuk memicu konten digital.

Instant Tracking: Memungkinkan penempatan objek 3D di permukaan datar tanpa memerlukan marker khusus.

Face Tracking: Implementasi filter atau objek yang mengikuti kontur wajah pengguna.

2. VR 360 Degree Viewer
Pengalaman imersif berbasis video/foto 360 derajat yang dioptimalkan untuk perangkat seluler maupun headset VR.

Gyroscope-based Camera: Navigasi kamera yang sinkron dengan gerakan fisik perangkat.

Fixed-Upright Player: Sistem kontrol yang memastikan pemain tetap berada pada sumbu tegak lurus (upright position) untuk menjaga kenyamanan pengguna dan mencegah motion sickness dalam mode VR 360.

Interactive Hotspots: Titik interaksi di dalam lingkungan 360 untuk navigasi antar scene.

⚠️ Technical Concerns (Zappar Free Version)
Proyek ini menggunakan Zappar versi gratis (Free/Starter Tier). Harap perhatikan batasan berikut jika ingin melakukan deployment atau pengembangan lebih lanjut:

Watermarking: Terdapat logo Zappar pada saat aplikasi berjalan.

Domain Whitelisting: Untuk WebAR, pastikan domain sudah terdaftar di hub Zappar agar proyek dapat diakses.

Usage Limits: Terdapat batas jumlah view per bulan sesuai kebijakan paket gratis Zappar.

🏗️ Tech Stack
Engine: Unity 6.4 (LTS recommended)

AR Library: Zappar for Unity Universal AR

Platform: Android / iOS / WebGL (WebAR)

Language: C#

🚀 Memulai (Getting Started)
Clone Repositori:

Setup Zappar:

Pastikan Anda memiliki akun di Zappar Hub.

Masukkan API Key atau konfigurasikan Project ID pada Zappar > Settings di dalam editor Unity.

Build Settings:

Untuk Android/iOS: Pastikan Camera Permission sudah diatur di Player Settings.

Untuk WebAR: Gunakan template WebGL yang disediakan oleh Zappar.

👨‍💻 Kontribusi
Proyek ini terbuka untuk pengembangan lebih lanjut, terutama dalam optimasi pelacakan sensor dan peningkatan kualitas aset visual. Jika Anda memiliki saran atau menemukan bug, silakan buka Issue atau kirimkan Pull Request.
