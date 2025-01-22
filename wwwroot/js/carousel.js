﻿let currentIndex = 0;

function moveSlide(direction) {
    const slides = document.querySelector('.carousel-slides');
    const totalSlides = slides.children.length;

    
    currentIndex += direction;

   
    if (currentIndex < 0) {
        currentIndex = totalSlides - 1;
    } else if (currentIndex >= totalSlides) {
        currentIndex = 0;
    }

   
    const newTransform = -currentIndex * 100; 
    slides.style.transform = `translateX(${newTransform}%)`;
}
