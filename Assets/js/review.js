const uniSelect = $('#university');

//Populate study program dropdown with selected university programs data from API
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

let count;

function starmark(item) {
    count = Number(item.id[0]) + 1;
    var subid = item.id.substring(1);
    for (var i = 0; i < 10; i++) {
        if (i < count) {
            document.getElementById(i + subid).style.color = "orange";
        }
        else {
            document.getElementById(i + subid).style.color = "black";
        }
    }
}
