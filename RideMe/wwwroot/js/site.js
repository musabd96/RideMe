


var swiper = new Swiper('.swiper-container', {
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
    },
});

var swiper = new Swiper('.swiper-container', {
    // Specify options here
    pagination: {
        el: '.swiper-pagination',
    },
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',

    },
});

$(document).ready(function () {
    $('.booking-info').click(function () {
        var downArrow = $(this).find('.ri-arrow-down-s-line');
        var upArrow = $(this).find('.ri-arrow-up-s-line');

        var today = new Date();
        var dd = String(today.getDate()).padStart(2, '0');
        var mm = String(today.getMonth() + 1).padStart(2, '0');
        var yyyy = today.getFullYear();

        var todayDate = yyyy + '-' + mm + '-' + dd;

        $('.pickup-date-update').attr('min', todayDate);

        var today = new Date();
        today.setDate(today.getDate() + 1); // Add one day to today's date

        var dd = String(today.getDate()).padStart(2, '0');
        var mm = String(today.getMonth() + 1).padStart(2, '0');
        var yyyy = today.getFullYear();

        var tomorrowDate = yyyy + '-' + mm + '-' + dd;

        $('.return-date-update').attr('min', tomorrowDate);


        downArrow.toggle();
        upArrow.toggleClass('hidden');
        $('.booking').toggleClass('hidden');
        $('#return-date').prop('disabled', false);
    });
});

// Select all elements with the class "open-popup-btn"
var buttons = document.querySelectorAll(".open-popup");

// Add the click event listener to each button
buttons.forEach(function (button) {
    button.addEventListener("click", function () {
        // Retrieve car details from the clicked button
        var carId = button.getAttribute("data-id");
        var selectedCarIdInput = document.getElementById('selected-car-id');
        
        selectedCarIdInput.value = carId;
        document.querySelector(".popup-overlay").style.display = "flex";
    });
});


document.getElementById("close-popup-btn").addEventListener("click", function () {
    document.querySelector(".popup-overlay").style.display = "none";

});

// ------- HOME DATE ------////

// Get today's date
var today = new Date();
var dd = String(today.getDate()).padStart(2, '0');
var mm = String(today.getMonth() + 1).padStart(2, '0'); 
var yyyy = today.getFullYear();

var todayDate = yyyy + '-' + mm + '-' + dd;

document.querySelector('.pickup-date').setAttribute('min', todayDate);
document.querySelector('.pickup-date-popup').setAttribute('min', todayDate);

var pickupDateInput = document.querySelector('.pickup-date');
var pickupDatePopupInput = document.querySelector('.pickup-date-popup');
var returnDateInput = document.querySelector('.return-date');
var returnDatePopupInput = document.querySelector('.return-date-popup');

returnDateInput.disabled = true;
returnDatePopupInput.disabled = true;

pickupDateInput.addEventListener('change', function () {
    var selectedDate = new Date(pickupDateInput.value);
    selectedDate.setDate(selectedDate.getDate() + 1);

    var minDate = selectedDate.toISOString().split('T')[0];

    returnDateInput.setAttribute('min', minDate);

    returnDateInput.disabled = false;
});

pickupDatePopupInput.addEventListener('change', function () {
    var selectedDate = new Date(pickupDatePopupInput.value);
    selectedDate.setDate(selectedDate.getDate() + 1);

    var minDate = selectedDate.toISOString().split('T')[0];

    returnDatePopupInput.setAttribute('min', minDate);

    returnDatePopupInput.disabled = false;
});


$(document).ready(function () {
    var today = new Date();
    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0');
    var yyyy = today.getFullYear();

    var todayDate = yyyy + '-' + mm + '-' + dd;

    $('.pickup-date-update').attr('min', todayDate);
});
