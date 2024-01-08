// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


    const images = [
    'img/img0.jpg',
        'img/img1.jpg',
        'img/img3.png',
        'img/img4.jpg',
    ];
    let imageIndex = 0;

    function showNextImage() {
        document.getElementById('imageDisplay').src = images[imageIndex];
    imageIndex++;
    if (imageIndex === images.length) {
        imageIndex = 0;
        }
    }
    showNextImage();
    setInterval(showNextImage, 2000);
