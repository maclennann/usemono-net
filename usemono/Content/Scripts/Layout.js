$('.nav a').click(function () {
    var navButton = $('.navbar-toggle');
    if (navButton.is(':visible')) {
        navButton.trigger('click');
    }
});