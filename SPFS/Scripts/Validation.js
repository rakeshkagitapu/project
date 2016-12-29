$(document).ready(function () {

    $('.decimalNumeric').keyup(function () {

        if (this.value.match(/[^(10|\d)(\.\d{1,2})?]/g)) {
            this.value = this.value.replace(/[^(10|\d)(\.\d{1,2})?]/g, '');
        }
    });

    $('.onlyNumeric').keyup(function () {

        if (this.value.match(/[^0-9]/g)) {
            this.value = this.value.replace(/[^0-9]/g, '');
        }
    });

});