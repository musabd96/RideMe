


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
var mm = String(today.getMonth() + 1).padStart(2, '0'); // January is 0!
var yyyy = today.getFullYear();

// Format it as yyyy-mm-dd for the input's value
var todayDate = yyyy + '-' + mm + '-' + dd;

// Set the minimum value of the date input to today's date
document.querySelector('.pickup-date').setAttribute('min', todayDate);
document.querySelector('.pickup-date-popup').setAttribute('min', todayDate);

var pickupDateInput = document.querySelector('.pickup-date');
var pickupDatePopupInput = document.querySelector('.pickup-date-popup');
var returnDateInput = document.querySelector('.return-date');
var returnDatePopupInput = document.querySelector('.return-date-popup');

// Disable return date inputs initially
returnDateInput.disabled = true;
returnDatePopupInput.disabled = true;

// Add an event listener to the Pickup Date input
pickupDateInput.addEventListener('change', function () {
    var selectedDate = new Date(pickupDateInput.value);
    selectedDate.setDate(selectedDate.getDate() + 1);

    // Format the minimum date for the Return Date input
    var minDate = selectedDate.toISOString().split('T')[0];

    // Set the minimum value of the Return Date input
    returnDateInput.setAttribute('min', minDate);

    // Enable return date input
    returnDateInput.disabled = false;
});

pickupDatePopupInput.addEventListener('change', function () {
    var selectedDate = new Date(pickupDatePopupInput.value);
    selectedDate.setDate(selectedDate.getDate() + 1);

    // Format the minimum date for the Return Date input
    var minDate = selectedDate.toISOString().split('T')[0];

    // Set the minimum value of the Return Date input
    returnDatePopupInput.setAttribute('min', minDate);

    // Enable return date input
    returnDatePopupInput.disabled = false;
});
