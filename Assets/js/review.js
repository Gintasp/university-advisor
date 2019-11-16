//Helper to load items into dropdown from REST API
const loadDropdownItems = (url, selector, placeholder) => {
    $.ajax({
        url,
        success: data => {
            let optionString = `<option selected disabled hidden>${placeholder}</option>`;
            const responseData = JSON.parse(data);
            responseData.map(item => {
                optionString += `<option value="${item.Id}">${item.Title}</option>`
            });

            $(selector).html(optionString);
        }
    });
}

//Populate lecturer dropdown with selected univeristy's lecturers from API
$('#lecturer-university')
    .on('change', e => loadDropdownItems(`/university/${e.target.value}/lecturers`, '#lecturer', 'Lecturer'));

//Populate study program dropdown with selected university programs data from API
$('.university-select')
    .on('change', e => loadDropdownItems(`/university/${e.target.value}/programs`, '.program-select', 'Study program'));

//Populate course dropdown with selected study program courses from REST API
$('.program-select')
    .on('change', e => loadDropdownItems(`/program/${e.target.value}/courses`, '.course-select', 'Course'));

//Generic function to prevent form submit
const submitSelected = (e, selector) => {
    const select = $(selector);
    const selectedValue = Number(select.find(':selected').val());
    if (Number.isNaN(selectedValue)) {
        e.preventDefault();
    }
};

//Prevent form submit if study program is not selected
$('#program-review-submit').on('click', e => submitSelected(e, '#program'));

//Handle rating stars click
const TYPE_OVERALL = 'OVERALL';
const TYPE_DIFFICULTY = 'DIFFICULTY';
const TYPE_SATISFACTION = 'SATISFACTION';
const TYPE_USEFULNESS = 'USEFULNESS';
const TYPE_INTERESTING = 'INTERESTING';
const TYPE_DELIVERY = 'DELIVERY';
const TYPE_PERSONALITY = 'PERSONALITY';
const TYPE_STRICTNESS = 'STRICTNESS';
const TYPE_COMPETENCE = 'COMPETENCE';

const handleRating = (element, type) => {
    const selectedStarsAmount = Number(element.id[0]) + 1;

    switch (type) {
        case TYPE_OVERALL:
            setInputValue('#overall-input', selectedStarsAmount);
            paintStars('#overall span', selectedStarsAmount);
            break;
        case TYPE_DIFFICULTY:
            setInputValue('#difficulty-input', selectedStarsAmount);
            paintStars('#difficulty span', selectedStarsAmount);
            break;
        case TYPE_SATISFACTION:
            setInputValue('#satisfaction-input', selectedStarsAmount);
            paintStars('#satisfaction span', selectedStarsAmount);
            break;
        case TYPE_USEFULNESS:
            setInputValue('#usefulness-input', selectedStarsAmount);
            paintStars('#usefulness span', selectedStarsAmount);
            break;
        case TYPE_INTERESTING:
            setInputValue('#interesting-input', selectedStarsAmount);
            paintStars('#interesting span', selectedStarsAmount);
            break;
        case TYPE_DELIVERY:
            setInputValue('#delivery-input', selectedStarsAmount);
            paintStars('#delivery span', selectedStarsAmount);
            break;
        case TYPE_PERSONALITY:
            setInputValue('#personality-input', selectedStarsAmount);
            paintStars('#personality span', selectedStarsAmount);
            break;
        case TYPE_STRICTNESS:
            setInputValue('#strictness-input', selectedStarsAmount);
            paintStars('#strictness span', selectedStarsAmount);
            break;
        case TYPE_COMPETENCE:
            setInputValue('#competence-input', selectedStarsAmount);
            paintStars('#competence span', selectedStarsAmount);
            break;
    }
}

//Helper to change stars color
const paintStars = (selector, amount) => {
    for (let i = 1; i <= 10; i++) {
        if (i <= amount) {
            $(selector + `:nth-child(${i + 1})`).css('color', 'orange');
        } else {
            $(selector + `:nth-child(${i + 1})`).css('color', '#333');
        }
    }
}

//Helper to set hidden input's value
const setInputValue = (selector, amount) => {
    const elements = Object.values(document.querySelectorAll(selector));
    elements.map(el => el.value = amount);
}

$(function () {
    $('[data-toggle="tooltip"]').tooltip({
        animation: true,
        delay: {hide: 600}
    });
});