function navBarSticky() {
    var body = document.getElementById("body-container");
    var navigation = document.getElementById("navigation");
    var title = document.getElementById("title");

    navigation.classList.remove("sticky");
    executeScroll(body, navigation, title);
}

// execute scroll
function executeScroll(body, navigation, title) {
    var banner = document.getElementById("banner");

    window.onscroll = function () {
        if (window.pageYOffset + navigation.clientHeight >= banner.scrollHeight) {
            navigation.classList.add("sticky");
            body.classList.add("sticky");
            title.classList.add("sticky");
        }
        else {
            navigation.classList.remove("sticky");
            body.classList.remove("sticky");
                
            if (title != null) {
                title.classList.remove("sticky");
            }
        }
    }
}

// toggle scroll when click on Arena Pic
function toggleScroll() {
    const isMobile = window.matchMedia("only screen and (max-width: 760px)").matches;
    var description = document.getElementById("description");
    var navigation = document.getElementById("navigation");
    var isExpanded = description.classList.contains("show");

    if (isMobile) {
        if (document.body.scrollTop === 0 && isExpanded) { // if user is at the top and paragraph is expanded, don't scroll
            return;
        }
        else {
            var arenaPic = document.getElementById("title");
            $('html,body').animate({ scrollTop: $("#title").offset().top - navigation.clientHeight + 5 }, "slow");
        }
    }
    else {
        if (document.body.scrollTop === 0 && isExpanded) {
            return;
        }
        else {
            $('html,body').animate({ scrollTop: document.body.scrollHeight }, "slow");
        }
    }
}

// collapse when click on Home
function collapse() {
    var description = document.getElementById("description");
    $('.collapse').collapse("hide");

    if (description != null) {
        description.classList.remove("in");
    }
}