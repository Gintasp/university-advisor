//Populate study program dropdown with selected university programs data from API
const uniSelect = $('#university');

uniSelect.on('change', e => {
    $.ajax({
        url: `/university/${e.target.value}/programs`,
        success: data => {
            let optionString = '<option selected disabled hidden>Study program</option>';
            const responseData = JSON.parse(data);
            responseData.map(program => {
                optionString += `<option value="${program.Id}">${program.Title}</option>`
            });

            $('#program').html(optionString);
        }
    });
});

//Prevent form submit if study program is not selected
$('#review-submit').on('click', e => {
    const programSelect = $('#program');
    const selectedProgramValue = Number(programSelect.find(':selected').val());
    if (Number.isNaN(selectedProgramValue)) {
        e.preventDefault();
    }
});

//Handle rating stars click
const TYPE_OVERALL = 'OVERALL';
const TYPE_DIFFICULTY = 'DIFFICULTY';
const TYPE_SATISFACTION = 'SATISFACTION';

const handleRating = (element, type) => {
    const selectedStarsAmount = Number(element.id[0]) + 1;

    switch (type) {
        case TYPE_OVERALL:
            $('#overall-input').val(selectedStarsAmount);
            paintStars('#overall span', selectedStarsAmount);
            break;
        case TYPE_DIFFICULTY:
            $('#difficulty-input').val(selectedStarsAmount);
            paintStars('#difficulty span', selectedStarsAmount);
            break;
        case TYPE_SATISFACTION:
            $('#satisfaction-input').val(selectedStarsAmount);
            paintStars('#satisfaction span', selectedStarsAmount);
            break;
    }
}

const paintStars = (selector, amount) => {
    for (let i = 1; i <= 10; i++) {
        if (i <= amount) {
            $(selector + `:nth-child(${i + 1})`).css('color', 'orange');
        } else {
            $(selector + `:nth-child(${i + 1})`).css('color', '#333');
        }
    }
}
