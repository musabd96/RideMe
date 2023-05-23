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

document.addEventListener('DOMContentLoaded', function () {
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

});



document.addEventListener("DOMContentLoaded", function () {
    var bookNowButton = document.querySelector("#book-now-btn");
    bookNowButton.addEventListener("click", function (event) {
        event.preventDefault();

        let pickupLocation = document.getElementById("pickup-location");
        //let dropoffLocation = document.getElementById("dropoff-location");
        let pickupDate = document.getElementById("pickup-date");
        let pickupTime = document.getElementById("pickup-time");
        let returnDate = document.getElementById("return-date");
        let returnTime = document.getElementById("return-time");

        let pickupdate = new Date(document.getElementById("pickup-date").value);
        let returndate = new Date(document.getElementById("return-date").value);
        
        if (pickupdate.getTime() && returndate.getTime()) {
            let timeDifference = returndate.getTime() - pickupdate.getTime();

            let daysBooking = timeDifference / (1000 * 3600 * 24);
            console.log('daysBooking: ', daysBooking)
            sessionStorage.setItem("daysBooking", daysBooking);
        }
           
       
        

        var isEmptyField = false;

        if (pickupLocation.value.trim() === "-Select City or Airport-") {
            pickupLocation.classList.remove("shake"); 
            void pickupLocation.offsetWidth; 
            pickupLocation.classList.add("shake");
            pickupLocation.style = "border: 1px solid #ff0000";
            isEmptyField = true;
        } else {
            //dropoffLocation.style = "border: ";
        }

        //if (dropoffLocation.value.trim() === "-Select City or Airport-") {
        //    dropoffLocation.classList.remove("shake");
        //    void dropoffLocation.offsetWidth;
        //    dropoffLocation.classList.add("shake");
        //    dropoffLocation.style = "border: 1px solid #ff0000";
        //    isEmptyField = true;
        //} else {
        //    dropoffLocation.style = "border: ";
        //}

        if (pickupDate.value.trim() === "") {
            pickupDate.classList.remove("shake");
            void pickupDate.offsetWidth;
            pickupDate.classList.add("shake");
            pickupDate.style = "border: 1px solid #ff0000";
            isEmptyField = true;
        } else {
            pickupDate.style = "border: ";
        }
            

        if (pickupTime.value.trim() === "") {
            pickupTime.classList.remove("shake");
            void pickupTime.offsetWidth;
            pickupTime.classList.add("shake");
            pickupTime.style = "border: 1px solid #ff0000";
            isEmptyField = true;
        } else {
            pickupTime.style = "border: ";
        }

        if (returnDate.value.trim() === "") {
            returnDate.classList.remove("shake");
            void returnDate.offsetWidth;
            returnDate.classList.add("shake");
            returnDate.style = "border: 1px solid #ff0000";
            isEmptyField = true;
        } else {
            returnDate.style = "border: ";
        }

        if (returnTime.value.trim() === "") {
            returnTime.classList.remove("shake");
            void returnTime.offsetWidth;
            returnTime.classList.add("shake");
            returnTime.style = "border: 1px solid #ff0000";
            isEmptyField = true;
        } else {
            returnTime.style = "border: ";
        }



        if (isEmptyField) {
            return; 
        }

        
        // Save the data to sessionStorage
        sessionStorage.setItem("pickupLocation", pickupLocation.value);
        //sessionStorage.setItem("dropoffLocation", dropoffLocation.value);
        sessionStorage.setItem("pickupDate", pickupDate.value);
        sessionStorage.setItem("pickupTime", pickupTime.value);
        sessionStorage.setItem("returnDate", returnDate.value);
        sessionStorage.setItem("returnTime", returnTime.value);

        // Navigate to the booking page
        window.location.href = "Vehicles";
    });
});


document.addEventListener("DOMContentLoaded", function () {
    var bookNowButton = document.querySelector("#book-now-snp");
    bookNowButton.addEventListener("click", function (event) {
        event.preventDefault();
        console.log('paaaa')
        let pickupLocation = document.getElementById("pickup-location-snp");
        //let dropoffLocation = document.getElementById("dropoff-location-snp");
        let pickupDate = document.getElementById("pickup-date-snp");
        let pickupTime = document.getElementById("pickup-time-snp");
        let returnDate = document.getElementById("return-date-snp");
        let returnTime = document.getElementById("return-time-snp");

        
        let pickupdate = new Date(document.getElementById("pickup-date-snp").value);
        let returndate = new Date(document.getElementById("return-date-snp").value);

        if (pickupdate.getTime() && returndate.getTime()) {
            let timeDifference = returndate.getTime() - pickupdate.getTime();
            let daysBooking = timeDifference / (1000 * 3600 * 24);
            console.log('daysBooking: ', daysBooking)
            sessionStorage.setItem("daysBooking", daysBooking);
        }

        


        var isEmptyField = false;

        if (pickupLocation.value.trim() === "-Select City or Airport-") {
            pickupLocation.classList.remove("shake");
            void pickupLocation.offsetWidth;
            pickupLocation.classList.add("shake");
            pickupLocation.style = "border: 1px solid #ff0000";
            isEmptyField = true;
        } else {
            //dropoffLocation.style = "border: ";
        }

        //if (dropoffLocation.value.trim() === "-Select City or Airport-") {
        //    dropoffLocation.classList.remove("shake");
        //    void dropoffLocation.offsetWidth;
        //    dropoffLocation.classList.add("shake");
        //    dropoffLocation.style = "border: 1px solid #ff0000";
        //    isEmptyField = true;
        //} else {
        //    dropoffLocation.style = "border: ";
        //}

        if (pickupDate.value.trim() === "") {
            pickupDate.classList.remove("shake");
            void pickupDate.offsetWidth;
            pickupDate.classList.add("shake");
            pickupDate.style = "border: 1px solid #ff0000";
            isEmptyField = true;
        } else {
            pickupDate.style = "border: ";
        }


        if (pickupTime.value.trim() === "") {
            pickupTime.classList.remove("shake");
            void pickupTime.offsetWidth;
            pickupTime.classList.add("shake");
            pickupTime.style = "border: 1px solid #ff0000";
            isEmptyField = true;
        } else {
            pickupTime.style = "border: ";
        }

        if (returnDate.value.trim() === "") {
            returnDate.classList.remove("shake");
            void returnDate.offsetWidth;
            returnDate.classList.add("shake");
            returnDate.style = "border: 1px solid #ff0000";
            isEmptyField = true;
        } else {
            returnDate.style = "border: ";
        }

        if (returnTime.value.trim() === "") {
            returnTime.classList.remove("shake");
            void returnTime.offsetWidth;
            returnTime.classList.add("shake");
            returnTime.style = "border: 1px solid #ff0000";
            isEmptyField = true;
        } else {
            returnTime.style = "border: ";
        }



        if (isEmptyField) {
            return;
        }


        // Save the data to sessionStorage
        sessionStorage.setItem("pickupLocation", pickupLocation.value);
        //sessionStorage.setItem("dropoffLocation", dropoffLocation.value);
        sessionStorage.setItem("pickupDate", pickupDate.value);
        sessionStorage.setItem("pickupTime", pickupTime.value);
        sessionStorage.setItem("returnDate", returnDate.value);
        sessionStorage.setItem("returnTime", returnTime.value);
        var carId = sessionStorage.getItem("selectedCarId", carId);
       
        // Navigate to the booking page
        window.location.href = "Vehicles"+ carId;
    });
});




document.addEventListener("DOMContentLoaded", function () {
    // Retrieve the stored data from sessionStorage
    var pickupLocation = sessionStorage.getItem("pickupLocation");
    //var dropoffLocation = sessionStorage.getItem("dropoffLocation");
    var pickupDate = sessionStorage.getItem("pickupDate");
    var pickupTime = sessionStorage.getItem("pickupTime");
    var returnDate = sessionStorage.getItem("returnDate");
    var returnTime = sessionStorage.getItem("returnTime");

    

    // Update the displayed values in the dropdown div
    document.getElementById("pickup-location-display").innerText = pickupLocation;
    //document.getElementById("dropoff-location-display").innerText = dropoffLocation;
    document.getElementById("pickup-date-display").innerText = pickupDate;
    document.getElementById("pickup-time-display").innerText = pickupTime;
    document.getElementById("return-date-display").innerText = returnDate;
    document.getElementById("return-time-display").innerText = returnTime;

   

    // Clear the stored data from sessionStorage
    //sessionStorage.clear();
});


$(document).ready(function () {
    $('.booking-info').click(function () {
        var downArrow = $(this).find('.ri-arrow-down-s-line');
        var upArrow = $(this).find('.ri-arrow-up-s-line');
        // Get the data from the booking-info div
        var pickupLocation = $(this).find('#pickup-location-display').text().trim();
        //var dropoffLocation = $(this).find('#dropoff-location-display').text().trim();
        var pickupDate = $(this).find('#pickup-date-display').text().trim();
        var pickupTime = $(this).find('#pickup-time-display').text().trim();
        var returnDate = $(this).find('#return-date-display').text().trim();
        var returnTime = $(this).find('#return-time-display').text().trim();

        if (pickupLocation === "") {
        
            pickupLocation = "-Select City or Airport-"
        }
        if (dropoffLocation === "") {

            dropoffLocation = "-Select City or Airport-"
        }
        // Insert the data into the booking form
        $('#pickup-location').val(pickupLocation);
        //$('#dropoff-location').val(dropoffLocation);
        $('#pickup-date').val(pickupDate);
        $('#pickup-time').val(pickupTime);
        $('#return-date').val(returnDate);
        $('#return-time').val(returnTime);

        // Save the data in local session storage
        sessionStorage.setItem("pickupLocation", pickupLocation);
        //sessionStorage.setItem("dropoffLocation", dropoffLocation);
        sessionStorage.setItem("pickupDate", pickupDate);
        sessionStorage.setItem("pickupTime", pickupTime);
        sessionStorage.setItem("returnDate", returnDate);
        sessionStorage.setItem("returnTime", returnTime);

        downArrow.toggle();
        upArrow.toggleClass('hidden');
        $('.booking').toggleClass('hidden');
        $('#return-date').prop('disabled', false);
    });

    // Check if there is saved data in local session storage
    if (sessionStorage.getItem("pickupLocation")) {
        // Retrieve the data from local session storage
        var pickupLocation = sessionStorage.getItem("pickupLocation");
        var dropoffLocation = sessionStorage.getItem("dropoffLocation");
        var pickupDate = sessionStorage.getItem("pickupDate");
        var pickupTime = sessionStorage.getItem("pickupTime");
        var returnDate = sessionStorage.getItem("returnDate");
        var returnTime = sessionStorage.getItem("returnTime");

        // Insert the data into the booking form
        $('#pickup-location').val(pickupLocation);
        $('#dropoff-location').val(dropoffLocation);
        $('#pickup-date').val(pickupDate);
        $('#pickup-time').val(pickupTime);
        $('#return-date').val(returnDate);
        $('#return-time').val(returnTime);
    }
});






const totalAmountElement = document.querySelectorAll('.total-amount');
const priceElements = document.querySelectorAll('.card-price');

// Assuming you have the daysBooking value stored in a variable
const daysBooking = sessionStorage.getItem('daysBooking');

// Loop through each card element and update the total amount
totalAmountElement.forEach((element, index) => {
    const price = parseFloat(priceElements[index].textContent);
    const totalAmount = price * daysBooking;
    element.textContent = totalAmount.toFixed(2);
});


document.addEventListener("DOMContentLoaded", function () {
    // Retrieve the daysBooking value from localStorage
    let rentDays = parseInt(sessionStorage.getItem("daysBooking"));
    document.getElementById("rent-days").textContent = rentDays + " Days";
    let price = parseFloat(document.getElementById("total").textContent);
    let total = price * rentDays;
    document.getElementById("total").textContent = "$" + total + ",00";

});

// Select all elements with the class "open-popup-btn"
var buttons = document.querySelectorAll(".open-popup");

// Add the click event listener to each button
buttons.forEach(function (button) {
    button.addEventListener("click", function () {
        // Retrieve car details from the clicked button
        var carId = button.getAttribute("data-id");
        var carMakeModel = button.getAttribute("data-car");
        var dailyRate = parseFloat(button.getAttribute("data-daily-rate"));

        // Store car details in session storage
        sessionStorage.setItem("selectedCarId", carId);
        sessionStorage.setItem("selectedCar", carMakeModel);
        sessionStorage.setItem("dailyRate", dailyRate);
        // Display the popup overlay
        document.querySelector(".popup-overlay").style.display = "flex";
    });
});


document.getElementById("close-popup-btn").addEventListener("click", function () {
    document.querySelector(".popup-overlay").style.display = "none";
   
});