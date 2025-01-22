let currentIndex = 0;

function moveSlide(direction) {
    const slides = document.querySelector('.carousel-slides');
    const totalSlides = slides.children.length;

    // Yeni indexi hesapla
    currentIndex += direction;

    // Index sınırlarını kontrol et (sondan başa veya baştan sona döner)
    if (currentIndex < 0) {
        currentIndex = totalSlides - 1;
    } else if (currentIndex >= totalSlides) {
        currentIndex = 0;
    }

    // Yeni slide pozisyonunu ayarla
    const newTransform = -currentIndex * 100; // Her bir slide %100 genişlik kaplar
    slides.style.transform = `translateX(${newTransform}%)`;
}
