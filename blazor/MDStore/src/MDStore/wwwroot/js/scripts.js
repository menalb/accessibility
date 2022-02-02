window.blazorHelpers = {
    scrollToFragment: (elementId) => {
        var element = document.getElementById(elementId);
        console.log(element);
        if (element) {
            element.scrollIntoView({
                behavior: 'smooth'
            });
            element.focus();
        }
    }
};