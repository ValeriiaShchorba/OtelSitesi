function changeSlide(index, direction) {
    const sliders = document.querySelectorAll(".slider-images");
    const slider = sliders[index];
    const images = slider.querySelectorAll("img");

    let current = Array.from(images).findIndex((img) => img.classList.contains("active"));
    images[current].classList.remove("active");

    current += direction;

    if (current < 0) {
        current = images.length - 1;
    } else if (current >= images.length) {
        current = 0;
    }

    images[current].classList.add("active");
}

