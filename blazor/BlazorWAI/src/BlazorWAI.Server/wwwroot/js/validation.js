export function ScrollToFirstInvalidElement(form) {

    var field = form.getElementsByClassName('invalid');

    if (!field) {
        console.warn('element was not found', form);
    }
    else if (field.length > 0 && field[0]) {
        field[0].scrollIntoView({
            behavior: "smooth",
            block: "start",
            inline: "nearest"
        });
        field[0].focus();
    }
}