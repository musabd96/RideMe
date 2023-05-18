// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


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

// BOOKING FORM

// Get today's date
var today = new Date();
var dd = String(today.getDate()).padStart(2, '0');
var mm = String(today.getMonth() + 1).padStart(2, '0');
var yyyy = today.getFullYear();

// Set the minimum value for the "Pick-up Date" input field
var pickupDateInput = document.getElementById('pickup-date');
pickupDateInput.min = yyyy + '-' + mm + '-' + dd;

// Set the initial value for the "Return Date" input field to be disabled
var returnDateInput = document.getElementById('return-date');
returnDateInput.disabled = true;

// Open the date picker when clicking on the "Pick-up Date" input field
pickupDateInput.addEventListener('click', function () {
    this.focus();
});

// Enable the "Return Date" input field when a pick-up date is chosen
pickupDateInput.addEventListener('change', function () {
    var selectedDate = new Date(this.value);
    selectedDate.setDate(selectedDate.getDate() + 1);

    var returnYear = selectedDate.getFullYear();
    var returnMonth = String(selectedDate.getMonth() + 1).padStart(2, '0');
    var returnDay = String(selectedDate.getDate()).padStart(2, '0');
    var returnDateValue = returnYear + '-' + returnMonth + '-' + returnDay;

    returnDateInput.disabled = false;
    returnDateInput.min = returnDateValue;
});


document.addEventListener("DOMContentLoaded", function () {
    var bookNowButton = document.querySelector("#book-now-btn");
    bookNowButton.addEventListener("click", function (event) {
        event.preventDefault();

        var pickupLocation = document.getElementById("pickup-location");
        var dropoffLocation = document.getElementById("dropoff-location");
        var pickupDate = document.getElementById("pickup-date");
        var pickupTime = document.getElementById("pickup-time");
        var returnDate = document.getElementById("return-date");
        var returnTime = document.getElementById("return-time");


        // Validate the form fields
        var isEmptyField = false;

        if (pickupLocation.value.trim() === "-Select City or Airport-") {
            pickupLocation.classList.remove("shake"); // Remove shake class if already added
            void pickupLocation.offsetWidth; // Trigger reflow to restart the animation
            pickupLocation.classList.add("shake");
            isEmptyField = true;
        }
        if (dropoffLocation.value.trim() === "-Select City or Airport-") {
            dropoffLocation.classList.remove("shake");
            void dropoffLocation.offsetWidth;
            dropoffLocation.classList.add("shake");
            isEmptyField = true;
        }

        if (pickupDate.value.trim() === "") {
            pickupDate.classList.remove("shake");
            void pickupDate.offsetWidth;
            pickupDate.classList.add("shake");
            isEmptyField = true;
        }

        if (pickupTime.value.trim() === "") {
            pickupTime.classList.remove("shake");
            void pickupTime.offsetWidth;
            pickupTime.classList.add("shake");
            isEmptyField = true;
        }

        if (returnDate.value.trim() === "") {
            returnDate.classList.remove("shake");
            void returnDate.offsetWidth;
            returnDate.classList.add("shake");
            isEmptyField = true;
        }

        if (returnTime.value.trim() === "") {
            returnTime.classList.remove("shake");
            void returnTime.offsetWidth;
            returnTime.classList.add("shake");
            isEmptyField = true;
        }



        if (isEmptyField) {
            return; 
        }

        // Save the data to sessionStorage
        sessionStorage.setItem("pickupLocation", pickupLocation.value);
        sessionStorage.setItem("dropoffLocation", dropoffLocation.value);
        sessionStorage.setItem("pickupDate", pickupDate.value);
        sessionStorage.setItem("pickupTime", pickupTime.value);
        sessionStorage.setItem("returnDate", returnDate.value);
        sessionStorage.setItem("returnTime", returnTime.value);

        // Navigate to the booking page
        window.location.href = "booking";
    });
});





document.addEventListener("DOMContentLoaded", function () {
    var pickupLocation = sessionStorage.getItem("pickupLocation");
    var dropoffLocation = sessionStorage.getItem("dropoffLocation");
    var pickupDate = sessionStorage.getItem("pickupDate");
    var pickupTime = sessionStorage.getItem("pickupTime");
    var returnDate = sessionStorage.getItem("returnDate");
    var returnTime = sessionStorage.getItem("returnTime");

    // Update the displayed values in the dropdown div
    document.getElementById("pickup-location-display").innerText = pickupLocation;
    document.getElementById("dropoff-location-display").innerText = dropoffLocation;
    document.getElementById("pickup-date-display").innerText = pickupDate;
    document.getElementById("pickup-time-display").innerText = pickupTime;
    document.getElementById("return-date-display").innerText = returnDate;
    document.getElementById("return-time-display").innerText = returnTime;

    // Show the dropdown div
    var dropdownDiv = document.getElementById("selected-data-dropdown");
    dropdownDiv.style.display = "block";

    // Clear the stored data from sessionStorage
    sessionStorage.clear();
});
